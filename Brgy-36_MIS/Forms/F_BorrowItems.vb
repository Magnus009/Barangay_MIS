Public Class F_BorrowItems
    Public blnisUpdate As Boolean
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call fn_ClearField(Me)
        Me.Hide()
    End Sub
    Private Sub getItems()
        strQuery = "SELECT I.ItemID, Description FROM M_Items I" & vbCrLf
        strQuery += "INNER JOIN M_ItemsInventory IV ON I.ItemID = IV.ItemID" & vbCrLf
        strQuery += "WHERE I.DeletedDate IS null and Stocks <> 0" & vbCrLf

        cboDataBinding(cboItems, strQuery)
    End Sub

    Private Sub getStatus()
            strQuery = "SELECT ID, Description FROM M_BorrowStatus " & vbCrLf
            strQuery += "WHERE DeletedDate IS null" & vbCrLf

            cboDataBinding(cboStatus, strQuery, "--STATUS--")
    End Sub

    Private Sub F_BorrowItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)
        Call getItems()
        Call getStatus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim blnExecuted As Boolean
            Dim dsBorrowID As New DataSet
            Dim strBorrowID As String

            If fn_CheckRequire(Me) Then
                MsgBox("Please fill out all the required field :" + vbCrLf + strRequire, vbOKOnly + vbExclamation)
            Else
                If MsgBox("are you sure you want to save?", vbYesNo + vbQuestion) Then

                    If blnisUpdate Then
                        strQuery = ""
                        strQuery += "UPDATE dbo.T_BorrowHistory" & vbCrLf
                        strQuery += "SET BorrowerName = '" + txtBorrower.Text + "'" & vbCrLf
                        strQuery += ", isResidence = " + Convert.ToInt32(chkisResident.Checked).ToString & vbCrLf
                        strQuery += ", inCharge = '" + txtIncharge.Text + "'" & vbCrLf
                        strQuery += ", ItemID ='" + cboItems.SelectedValue + "'" & vbCrLf
                        strQuery += ", QTY =" + txtQTY.Text & vbCrLf
                        strQuery += ", StatusID =" + cboStatus.SelectedValue & vbCrLf
                        strQuery += ", BorrowedDate = '" + Format(dtpBorrowedDate.Value, "yyyy/MM/dd") + "'" & vbCrLf
                        strQuery += ", ReturnDate ='" + Format(dtpReturnDate.Value, "yyyy/MM/dd") + "'" & vbCrLf
                        strQuery += ", UpdatedDate =getdate()" & vbCrLf
                        strQuery += "WHERE BorrowCode = '" + txtCode.Text + "'" & vbCrLf
                        blnExecuted = SQL_EXECUTE(strQuery)

                        strQuery = ""
                        strQuery += "UPDATE dbo.M_ItemsInventory" & vbCrLf
                        strQuery += "SET Stocks = Stocks -" + txtQTY.Text + vbCrLf
                        strQuery += ", UpdatedDate = getdate()" + vbCrLf
                        strQuery += "WHERE ItemID = '" + cboItems.SelectedValue + "'" + vbCrLf
                        blnExecuted = SQL_EXECUTE(strQuery)

                        If blnExecuted Then
                            MsgBox("Record saved successfully!", vbOKOnly + vbInformation)
                            F_Inventory.getBorrowHistories()
                            fn_ClearField(Me)
                            Me.Hide()
                        End If

                    Else
                        '//get Borrow ID
                        strQuery = ""
                        strQuery += "SELECT dbo.fn_colID ('B')"
                        dsBorrowID = SQL_SELECT(strQuery)
                        strBorrowID = dsBorrowID.Tables(0).Rows(0)(0)

                        '//Insert new record
                        strQuery = ""
                        strQuery += "INSERT INTO dbo.T_BorrowHistory " & vbCrLf
                        strQuery += "(" & vbCrLf
                        strQuery += "BorrowCode," & vbCrLf
                        strQuery += "BorrowerName," & vbCrLf
                        strQuery += "isResidence," & vbCrLf
                        strQuery += "inCharge," & vbCrLf
                        strQuery += "ItemID," & vbCrLf
                        strQuery += "QTY," & vbCrLf
                        strQuery += "StatusID," & vbCrLf
                        strQuery += "BorrowedDate," & vbCrLf
                        strQuery += "ReturnDate," & vbCrLf
                        strQuery += "CreatedDate," & vbCrLf
                        strQuery += "UpdatedDate," & vbCrLf
                        strQuery += "DeletedDate," & vbCrLf
                        strQuery += "UpdatedBy" & vbCrLf
                        strQuery += ")" & vbCrLf
                        strQuery += "VALUES" & vbCrLf
                        strQuery += "(" & vbCrLf
                        strQuery += "'" + strBorrowID + "'," & vbCrLf
                        strQuery += "'" + txtBorrower.Text + "'," & vbCrLf
                        strQuery += Convert.ToInt32(chkisResident.Checked).ToString + "," & vbCrLf
                        strQuery += "'" + txtIncharge.Text + "'," & vbCrLf
                        strQuery += "'" + cboItems.SelectedValue + "'," & vbCrLf
                        strQuery += txtQTY.Text + "," & vbCrLf
                        strQuery += cboStatus.SelectedValue + "," & vbCrLf
                        strQuery += "'" + Format(dtpBorrowedDate.Value, "yyyy/MM/dd") + "'," & vbCrLf
                        strQuery += "'" + Format(dtpReturnDate.Value, "yyyy/MM/dd") + "'," & vbCrLf
                        strQuery += "getdate()," & vbCrLf
                        strQuery += "getdate()," & vbCrLf
                        strQuery += "null," & vbCrLf
                        strQuery += "'admin'" & vbCrLf
                        strQuery += ")" & vbCrLf
                        blnExecuted = SQL_EXECUTE(strQuery)


                        strQuery = ""
                        strQuery += "UPDATE dbo.M_ItemsInventory" & vbCrLf
                        strQuery += "SET Stocks = Stocks -" + txtQTY.Text + vbCrLf
                        strQuery += ", UpdatedDate = getdate()" + vbCrLf
                        strQuery += "WHERE ItemID = '" + cboItems.SelectedValue + "'" + vbCrLf
                        blnExecuted = SQL_EXECUTE(strQuery)

                        If blnExecuted Then
                            MsgBox("Record saved successfully!", vbOKOnly + vbInformation)
                            F_Inventory.getBorrowHistories()
                            fn_ClearField(Me)
                            Me.Hide()
                        End If
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class