Public Class F_AddSamahan
    Dim strID As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            strRequire = "" : blnRequired = False
            If fn_CheckRequire(Me) Then
                Throw New Exception("Please input on the following field(s):" + vbCrLf + strRequire)
            Else
                If btnSave.Text = "&SAVE" Then
                    strQuery = "INSERT INTO M_Samahan (Title, Description, CreatedDate, UpdatedDate, UpdatedBy)" + vbCrLf
                    strQuery += "VALUES ('" + txtTitle.Text + "', " + vbCrLf
                    strQuery += "'" + txtDescription.Text + "', " + vbCrLf
                    strQuery += "getdate(), " + vbCrLf
                    strQuery += "getdate(), " + vbCrLf
                    strQuery += "'" + UserName + "')" + vbCrLf

                    If SQL_EXECUTE(strQuery) Then
                        MsgBox("Samahan Registered Successfully!", MsgBoxStyle.Information)
                        Me.Close()
                    Else
                        Throw New Exception("Registration Failed!")
                    End If
                Else
                    strQuery = "UPDATE M_Samahan" + vbCrLf
                    strQuery += "SET Description = '" + txtDescription.Text + "'" + vbCrLf
                    strQuery += ", UpdatedDate = getdate()"
                    strQuery += ", UpdatedBy = '" + UserName + "'"
                    strQuery += "WHERE ID =" + strID

                    If SQL_EXECUTE(strQuery) Then
                        MsgBox("Updated Successfully!", MsgBoxStyle.Information)
                        Me.Close()
                    Else
                        Throw New Exception("Update Failed!")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub loadSamahan(strSamahanID As String)
        Try
            formMode(2, Me)
            Dim dtSamahan As DataTable
            strID = strSamahanID

            strQuery = "SELECT ID, Title, Description, CreatedDate FROM M_Samahan" + vbCrLf
            strQuery += "WHERE DeletedDate IS NULL" + vbCrLf
            strQuery += "AND ID = " + strSamahanID
            dtSamahan = SQL_SELECT(strQuery).Tables(0)

            With dtSamahan
                txtTitle.Text = .Rows(0)("Title")
                txtDescription.Text = .Rows(0)("Description")
                lblCreatedDate.Visible = True : txtCreatedDate.Visible = True
                txtCreatedDate.Text = Format(.Rows(0)("CreatedDate"), "yyyy/MM/dd")
            End With
            btnSave.Text = "&UPDATE"
            Me.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class