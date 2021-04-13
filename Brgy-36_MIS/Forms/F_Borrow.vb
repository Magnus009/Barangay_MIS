Public Class F_Borrow

    Private Sub F_Borrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            formLoadSetup(Me)
            AddHandler txtQTY.KeyPress, AddressOf numericOnly
            setGridHeader()

            strQuery = "SELECT * FROM M_BorrowStatus WHERE DeletedDate IS NULL"
            cboDataBinding(cboStatus, strQuery, "--STATUS--")
            cboStatus.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub setGridHeader()
        With datBorrowItems
            .Columns.Clear()
            .ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 8, FontStyle.Bold)

            .Columns.Add("colItemID", "ID")
            .Columns.Add("colItemName", "NAME")
            .Columns.Add("colBorrowedQTY", "QTY")

            .Columns(0).Width = .Width * 0.3
            .Columns(1).Width = .Width * 0.5
            .Columns(2).Width = .Width * 0.188
        End With

        With datItems
            .Columns.Clear()
            .ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 8, FontStyle.Bold)

            .Columns.Add("colItemID", "ID")
            .Columns.Add("colItemName", "NAME")
            .Columns.Add("colQTY", "STOCKS")

            .Columns(0).Width = .Width * 0.3
            .Columns(1).Width = .Width * 0.5
            .Columns(2).Width = .Width * 0.188

            loadItems()
        End With
    End Sub

    Private Sub loadItems(Optional strFilter As String = "")
        Try
            Dim dtItems As New DataTable

            With datItems
                .Rows.Clear()

                strQuery = "SELECT II.ItemID 'ID', I.Description 'NAME', II.Stocks 'STOCKS' FROM M_ItemsInventory II" + vbCrLf
                strQuery += "INNER JOIN M_Items I ON II.ItemID = I.ItemID" + vbCrLf
                strQuery += "WHERE II.DeletedDate IS NULL" + vbCrLf
                strQuery += "AND II.Stocks > 0" + vbCrLf
                If strFilter <> "" Then
                    strQuery += "AND(II.ItemID LIKE '%%'" + vbCrLf
                    strQuery += "OR I.Description LIKE '%%')"
                End If
                dtItems = SQL_SELECT(strQuery).Tables(0)

                For Each dr As DataRow In dtItems.Rows
                    Dim row As String()
                    row = New String() {dr(0), dr(1), dr(2)}
                    datItems.Rows.Add(row)
                Next

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        moveItem(datItems, datBorrowItems)
    End Sub

    Private Sub moveItem(dgvFrom As DataGridView, dgvTo As DataGridView)
        Try
            If dgvFrom.RowCount > 0 And txtQTY.Text <> 0 Then
                Dim intMoveQty As Integer


                Dim strItemID As String = dgvFrom.CurrentRow.Cells(0).Value
                Dim strItemName As String = dgvFrom.CurrentRow.Cells(1).Value
                Dim intQty As Integer = dgvFrom.CurrentRow.Cells(2).Value
                Dim intItemRow As Integer
                Dim blnNew As Boolean = True

                If txtQTY.Text > intQty Then
                    If MsgBox("Do you want to continue?" + vbCrLf + " QTY will be automatically set to maximum.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Invalid QTY") = vbNo Then
                        Exit Sub
                    End If
                End If

                intMoveQty = IIf(txtQTY.Text > intQty, intQty, txtQTY.Text)
                txtQTY.Text = intMoveQty
                If intQty > 0 Then
                    If dgvTo.RowCount > 0 Then
                        For intRow As Integer = 0 To dgvTo.RowCount - 1
                            If dgvTo.Rows(intRow).Cells(0).Value.Equals(strItemID) Then
                                blnNew = False
                                intItemRow = intRow
                                Exit For
                            Else
                                blnNew = True
                            End If
                        Next
                    End If

                    If blnNew Then
                        Dim row As String()
                        row = New String() {strItemID, strItemName, intMoveQty}
                        dgvTo.Rows.Add(row)
                    Else
                        dgvTo.Rows(intItemRow).Cells(2).Value = dgvTo.Rows(intItemRow).Cells(2).Value + intMoveQty
                    End If

                    dgvFrom.CurrentRow.Cells(2).Value = dgvFrom.CurrentRow.Cells(2).Value - intMoveQty
                    If dgvFrom.CurrentRow.Cells(2).Value = 0 Then dgvFrom.Rows.Remove(dgvFrom.CurrentRow)
                Else
                    dgvFrom.Rows.Remove(dgvFrom.CurrentRow)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        moveItem(datBorrowItems, datItems)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If fn_CheckRequire(Me) Then
                MsgBox("Please complete the required fields(*):" & vbCrLf & strRequire, MsgBoxStyle.Exclamation, "Required Items")
                strRequire = "" : blnRequired = False
            Else
                If MsgBox("Do you want to Save this Request?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "BORROW") = vbYes Then
                    Dim strBorrowID As String
                    strQuery = "SELECT dbo.fn_colID ('B')"
                    strBorrowID = SQL_SELECT(strQuery).Tables(0).Rows(0)(0)

                    strQuery = "INSERT INTO BorrowHeader (" + vbCrLf
                    strQuery += "Code, " + vbCrLf
                    strQuery += "Borrower, " + vbCrLf
                    strQuery += "isResidence, " + vbCrLf
                    strQuery += "InCharge, " + vbCrLf
                    strQuery += "StatusID, " + vbCrLf
                    strQuery += "ContactNo, " + vbCrLf
                    strQuery += "BorrowedDate, " + vbCrLf
                    strQuery += "ReturnedDate, " + vbCrLf
                    strQuery += "CreatedDate, " + vbCrLf
                    strQuery += "UpdatedDate, " + vbCrLf
                    strQuery += "UpdatedBy)" + vbCrLf
                    strQuery += "VALUES (" + vbCrLf
                    strQuery += "'" + strBorrowID + "', " + vbCrLf
                    strQuery += "'" + txtBorrower.Text + "', " + vbCrLf
                    strQuery += chkVal(chkResident) + ", " + vbCrLf
                    strQuery += "'" + txtIncharge.Text + "', " + vbCrLf
                    strQuery += cboVal(cboStatus) + ", " + vbCrLf
                    strQuery += "'" + txtContactNo.Text + "', " + vbCrLf
                    strQuery += "'" + fn_Date(dtpBorrowDate.Value) + "', " + vbCrLf
                    strQuery += "'" + fn_Date(dtpReturn.Value) + "', " + vbCrLf
                    strQuery += "getdate(), " + vbCrLf
                    strQuery += "getdate(), " + vbCrLf
                    strQuery += "'" + UserName + "')"

                    If SQL_EXECUTE(strQuery) Then
                        For Each dgvRow As DataGridViewRow In datBorrowItems.Rows
                            strQuery = "INSERT INTO BorrowDetails (" + vbCrLf
                            strQuery += "Code, " + vbCrLf
                            strQuery += "SeqNo, " + vbCrLf
                            strQuery += "ItemID, " + vbCrLf
                            strQuery += "BorrowedQTY, " + vbCrLf
                            strQuery += "CreatedDate, " + vbCrLf
                            strQuery += "UpdatedDate," + vbCrLf
                            strQuery += "UpdatedBy)" + vbCrLf
                            strQuery += "VALUES (" + vbCrLf
                            strQuery += "'" + strBorrowID + "', " + vbCrLf
                            strQuery += Convert.ToString(dgvRow.Index + 1) + ", " + vbCrLf
                            strQuery += "'" + dgvRow.Cells(0).Value + "', " + vbCrLf
                            strQuery += Convert.ToString(dgvRow.Cells(2).Value) + ", " + vbCrLf
                            strQuery += "getdate(), " + vbCrLf
                            strQuery += "getdate(), " + vbCrLf
                            strQuery += "'" + UserName + "')"
                            SQL_EXECUTE(strQuery)

                            strQuery = "UPDATE M_ItemsInventory" + vbCrLf
                            strQuery += "SET Stocks = Stocks - " + Convert.ToString(dgvRow.Cells(2).Value) + vbCrLf
                            strQuery += "WHERE ItemID = '" + dgvRow.Cells(0).Value + "'"
                            SQL_EXECUTE(strQuery)
                        Next

                        MsgBox("Record Successfully Saved!", MsgBoxStyle.Information)
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class