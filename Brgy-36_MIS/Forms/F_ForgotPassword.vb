Public Class F_ForgotPassword
    Dim dsUserQuestions As New DataSet
    Dim strID As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim blnUpdated As Boolean

            If fn_CheckRequire(Me) Then
                MsgBox("Please complete all the required field " & vbCrLf & strRequire, vbOKOnly + vbExclamation)
            Else
                If txtAnswer1.Text <> dsUserQuestions.Tables(0).Rows(0)(2) Or txtAnswer2.Text <> dsUserQuestions.Tables(0).Rows(0)(5) Then
                    MsgBox("Answers doesn't match!", vbOKOnly + vbExclamation)
                Else
                    strQuery = ""
                    strQuery += "UPDATE dbo.M_UserAccounts" & vbCrLf
                    strQuery += "SET Password = '" + txtNewPass.Text + "'" & vbCrLf
                    strQuery += "WHERE UserID = '" + strID + "'" & vbCrLf
                    blnUpdated = SQL_EXECUTE(strQuery)

                    If blnUpdated Then
                        MsgBox("Password changed successfully!", vbOKOnly + vbInformation)
                        Me.Hide()
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtUserName_Leave(sender As Object, e As EventArgs) Handles txtUserName.Leave
        Try

            Dim dsCheckUser As New DataSet

            strQuery = ""
            strQuery += "SELECT * FROM M_UserAccounts" & vbCrLf
            strQuery += "WHERE UserName = '" + txtUserName.Text + "'"
            dsCheckUser = SQL_SELECT(strQuery)

            If dsCheckUser.Tables(0).Rows.Count <> 0 Then

                strID = dsCheckUser.Tables(0).Rows(0)(0)
                Call getUsersQuestions()
                txtNewPass.ReadOnly = False
                txtConfirmPass.ReadOnly = False
                txtAnswer1.ReadOnly = False
                txtAnswer2.ReadOnly = False
                txtQuestion1.Text = dsUserQuestions.Tables(0).Rows(0)(1)
                txtQuestion2.Text = dsUserQuestions.Tables(0).Rows(0)(4)

            Else
                MsgBox("User name doesn't exist!", vbOKOnly + vbExclamation)
                txtNewPass.ReadOnly = True
                txtConfirmPass.ReadOnly = True
                txtAnswer1.ReadOnly = True
                txtAnswer2.ReadOnly = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
    Private Sub getUsersQuestions()
        Try
            strQuery = ""
            strQuery += "SELECT UQ.QuestionID1, Q1.Question,UQ.Answer1,UQ.QuestionID2, Q2.Question, UQ.Answer2 FROM UserQuestion UQ" & vbCrLf
            strQuery += "INNER JOIN M_VerificationQuestion Q1 ON UQ.QuestionID1 = Q1.ID " & vbCrLf
            strQuery += "INNER JOIN M_VerificationQuestion Q2 ON UQ.QuestionID2 = Q2.ID " & vbCrLf
            strQuery += "WHERE UQ.UserID = '" + strID + "'"
            dsUserQuestions = SQL_SELECT(strQuery)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtConfirmPass_Leave(sender As Object, e As EventArgs) Handles txtConfirmPass.Leave
        Try
            If txtNewPass.Text <> txtConfirmPass.Text Then
                MsgBox("Password mismatch!", vbOKOnly + vbExclamation)
                txtConfirmPass.ForeColor = Color.Red
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        txtConfirmPass.ForeColor = Color.Black
    End Sub
End Class