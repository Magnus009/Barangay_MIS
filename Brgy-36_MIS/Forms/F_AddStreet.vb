Public Class F_AddStreet

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            strRequire = "" : blnRequired = False
            If fn_CheckRequire(Me) Then
                Throw New Exception("Please input on the following field(s):" + vbCrLf + strRequire)
            Else
                strQuery = "INSERT INTO M_Street (Name, CreatedDate, UpdatedDate, UpdatedBy)" + vbCrLf
                strQuery += "VALUES ('" + txtStreet.Text + "', " + vbCrLf
                strQuery += "getdate(), " + vbCrLf
                strQuery += "getdate(), " + vbCrLf
                strQuery += "'" + UserName + "')" + vbCrLf

                If SQL_EXECUTE(strQuery) Then
                    MsgBox("Street Recorded Successfully!", MsgBoxStyle.Information)
                    Me.Close()
                Else
                    Throw New Exception("Registration Failed!")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub F_AddStreet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)
    End Sub
End Class