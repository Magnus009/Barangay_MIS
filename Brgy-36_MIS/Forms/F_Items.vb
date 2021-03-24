Public Class F_Items
    Public blnIsUpdate As Boolean
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim dsItemID As New DataSet
            Dim strItemID As String
            Dim blnExecuted As Boolean

           
            If fn_CheckRequire(Me) Then
                MsgBox("Please fill out all the required field :" + vbCrLf + strRequire, vbOKOnly + vbExclamation)
            Else
                If MsgBox("Are you sure you want to save?", vbYesNo + vbQuestion) Then
                    If blnIsUpdate Then
                        '//UPDATE RECORD
                        strQuery = ""
                        strQuery += "UPDATE dbo.M_Items" & vbCrLf
                        strQuery += "SET Description = '" + txtName.Text + "'," & vbCrLf
                        strQuery += "UpdatedDate = getdate()" & vbCrLf
                        strQuery += "WHERE ItemID = '" + txtItemID.Text + "'" & vbCrLf
                        blnExecuted = SQL_EXECUTE(strQuery)

                        strQuery = ""
                        strQuery += "UPDATE dbo.M_ItemsInventory" & vbCrLf
                        strQuery += "SET TotalQTY = " + txtTotalQTY.Text + "," & vbCrLf
                        strQuery += "Stocks = " + txtStocks.Text + "," & vbCrLf
                        strQuery += "UpdatedDate = getdate()" & vbCrLf
                        strQuery += "WHERE ItemID = '" + txtItemID.Text + "'" & vbCrLf
                        blnExecuted = SQL_EXECUTE(strQuery)

                        If blnExecuted Then
                            MsgBox("Record updated succesfully!", vbOKOnly + vbInformation)
                            blnIsUpdate = False
                            Call F_Inventory.getItems()
                            Call fn_ClearField(Me)
                            Me.Hide()
                        End If
                    Else
                        '//INSERT NEW RECORD
                        strQuery = ""
                        strQuery += "SELECT dbo.fn_colID ('I')"
                        dsItemID = SQL_SELECT(strQuery)
                        strItemID = dsItemID.Tables(0).Rows(0)(0)

                        strQuery = ""
                        strQuery += "INSERT INTO dbo.M_Items " & vbCrLf
                        strQuery += "( " & vbCrLf
                        strQuery += "ItemID," & vbCrLf
                        strQuery += "Description," & vbCrLf
                        strQuery += "CreatedDate," & vbCrLf
                        strQuery += "UpdatedDate," & vbCrLf
                        strQuery += "DeletedDate," & vbCrLf
                        strQuery += "UpdatedBy" & vbCrLf
                        strQuery += ")" & vbCrLf
                        strQuery += "VALUES" & vbCrLf
                        strQuery += "( " & vbCrLf
                        strQuery += "'" + strItemID + "'," & vbCrLf
                        strQuery += "'" + txtName.Text + "'," & vbCrLf
                        strQuery += "getdate()," & vbCrLf
                        strQuery += "getdate()," & vbCrLf
                        strQuery += "null," & vbCrLf
                        strQuery += "'admin'" & vbCrLf
                        strQuery += ")" & vbCrLf
                        blnExecuted = SQL_EXECUTE(strQuery)

                        strQuery = ""
                        strQuery += "INSERT INTO dbo.M_ItemsInventory " & vbCrLf
                        strQuery += "( " & vbCrLf
                        strQuery += "ItemID," & vbCrLf
                        strQuery += "TotalQTY," & vbCrLf
                        strQuery += "Stocks," & vbCrLf
                        strQuery += "CreatedDate," & vbCrLf
                        strQuery += "UpdatedDate," & vbCrLf
                        strQuery += "DeletedDate," & vbCrLf
                        strQuery += "UpdatedBy" & vbCrLf
                        strQuery += ")" & vbCrLf
                        strQuery += "VALUES" & vbCrLf
                        strQuery += "( " & vbCrLf
                        strQuery += "'" + strItemID + "'," & vbCrLf
                        strQuery += "'" + txtTotalQTY.Text + "'," & vbCrLf
                        strQuery += "'" + txtStocks.Text + "'," & vbCrLf
                        strQuery += "getdate()," & vbCrLf
                        strQuery += "getdate()," & vbCrLf
                        strQuery += "null," & vbCrLf
                        strQuery += "'admin'" & vbCrLf
                        strQuery += ")" & vbCrLf
                        blnExecuted = SQL_EXECUTE(strQuery)

                        If blnExecuted Then
                            MsgBox("Item recorded succesfully!", vbOKOnly + vbInformation)
                            Call F_Inventory.getItems()
                            Call fn_ClearField(Me)
                            Me.Hide()
                        End If

                    End If
                    

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub F_Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call fn_ClearField(Me)
        blnIsUpdate = False
        Me.Hide()
    End Sub
End Class