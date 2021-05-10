Public Class F_BorrowHistory


    Private Sub loadBorrowedItems(strFilter As String)
        Try
            Dim dtBorrowedItems As New DataTable
            strQuery = "SELECT BH.BorrowCode [CODE], BH.BorrowerName [BORROWER NAME], count(BT.ItemID) [ITEM] FROM T_BorrowHeader BH" + vbCrLf
            strQuery += "LEFT JOIN T_BorrowDetails BT ON BH.BorrowCode = BT.BorrowCode" + vbCrLf
            strQuery += "WHERE BH.DeletedDate IS NULL" + vbCrLf
            If strFilter <> "" Then
                strQuery += strFilter + vbCrLf
            End If
            strQuery += "GROUP BY BH.BorrowCode, BH.BorrowerName" + vbCrLf

            dtBorrowedItems = SQL_SELECT(strQuery).Tables(0)
            datItems.DataSource = dtBorrowedItems

            With datItems
                .Columns(0).Width = .Width * 0.25
                .Columns(1).Width = .Width * 0.54
                .Columns(2).Width = .Width * 0.2
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub F_BorrowHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            formLoadSetup(Me)
            loadBorrowedItems("")
            strQuery = "SELECT * FROM M_BorrowStatus WHERE DeletedDate IS NULL"
            cboDataBinding(cboStatus, strQuery, "--STATUS--")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub loadBorrowedDetails(strBorrowCode As String)
        Dim dtBorrowedHeader As New DataTable
        Dim dtBorrowedDetails As New DataTable

        strQuery = "SELECT * FROM T_BorrowHeader" + vbCrLf
        strQuery += "WHERE BorrowCode = '" + strBorrowCode + "'"
        dtBorrowedHeader = SQL_SELECT(strQuery).Tables(0)

        strQuery = "SELECT BT.SeqNo [SEQ No], BT.ItemID [ITEM ID], I.ItemName [ITEM NAME], BT.QTY FROM T_BorrowDetails BT" + vbCrLf
        strQuery += "INNER JOIN M_Items I ON BT.ItemID = I.ItemID" + vbCrLf
        strQuery += "WHERE BT.BorrowCode = '" + strBorrowCode + "'" + vbCrLf
        dtBorrowedDetails = SQL_SELECT(strQuery).Tables(0)

        With dtBorrowedHeader
            txtBorrowCode.Text = strBorrowCode
            txtBorrower.Text = .Rows(0)("BorrowerName")
            txtContactNo.Text = .Rows(0)("ContactNo")
            chkResident.Checked = .Rows(0)("isResidence")
            txtIncharge.Text = .Rows(0)("inCharge")
            cboStatus.SelectedValue = .Rows(0)("StatusID")
            dtpBorrowDate.Value = .Rows(0)("BorrowedDate")
            dtpReturn.Value = .Rows(0)("ReturnDate")

            If Val(cboVal(cboStatus)) < 3 Then
                btnReturn.Enabled = True

                If dtpReturn.Value < Today Then
                    strQuery = "UPDATE T_BorrowHeader" + vbCrLf
                    strQuery += "SET StatusID = 2" + vbCrLf
                    strQuery += "WHERE BorrowCode = '" + strBorrowCode + "'"
                    If SQL_EXECUTE(strQuery) Then
                        cboStatus.SelectedValue = 2
                    End If
                End If
            Else
                btnReturn.Enabled = False
            End If
        End With

        With datBorrowItems
            .ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 8, FontStyle.Bold)
            .DataSource = dtBorrowedDetails
            .Columns(0).Width = .Width * 0.2
            .Columns(1).Width = .Width * 0.3
            .Columns(2).Width = .Width * 0.3
            .Columns(3).Width = .Width * 0.19
        End With
    End Sub

    Private Sub datItems_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles datItems.RowEnter
        Try
            Dim strBorrowCode As String
            strBorrowCode = datItems.Rows(e.RowIndex).Cells(0).Value
            loadBorrowedDetails(strBorrowCode)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim strFilter As String = ""
            If dtpBorrowed.Checked Then
                strFilter += " AND BH.BorrowedDate = '" + fn_Date(dtpBorrowed.Value) + "'"
            End If

            If dtpReturned.Checked Then
                strFilter += " AND BH.ReturnDate = '" + fn_Date(dtpReturned.Value) + "'"
            End If

            If txtSearch.Text <> "" Then
                strFilter += " AND ( BH.BorrowerName LIKE '%" + txtSearch.Text + "%'" + vbCrLf
                strFilter += "OR BH.BorrowCode LIKE '%" + txtSearch.Text + "%')"
            End If
            loadBorrowedItems(strFilter)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Try
            Dim dlg As New DialogResult

            dlg = MsgBox("Return borrowed item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "RETURN")
            If dlg = Windows.Forms.DialogResult.Yes Then
                strQuery = "UPDATE T_BorrowHeader" + vbCrLf
                strQuery += "SET StatusID = 4," + vbCrLf
                strQuery += "ReturnDate = getdate()," + vbCrLf
                strQuery += "UpdatedDate = getdate()," + vbCrLf
                strQuery += "UpdatedBy = '" + UserName + "'" + vbCrLf
                strQuery += "WHERE BorrowCode = '" + txtBorrowCode.Text + "'"

                If SQL_EXECUTE(strQuery) Then
                    For Each dr As DataGridViewRow In datBorrowItems.Rows
                        strQuery = "UPDATE M_ItemsInventory" + vbCrLf
                        strQuery += "SET Stocks = Stocks + " + dr.Cells(3).Value.ToString + "," + vbCrLf
                        strQuery += "UpdatedDate = getdate()," + vbCrLf
                        strQuery += "UpdatedBy = '" + UserName + "'" + vbCrLf
                        strQuery += "WHERE ItemID = '" + dr.Cells(1).Value.ToString + "'"

                        SQL_EXECUTE(strQuery)
                    Next

                    MsgBox("Item Returned!", MsgBoxStyle.Information, "RETURNED")
                    loadBorrowedDetails(txtBorrowCode.Text)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class