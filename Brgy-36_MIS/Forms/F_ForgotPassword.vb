Public Class F_forgotPassword

    Dim dtVerification As New DataTable
    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Try
            If txtUserName.Text <> "" Then
                strQuery = "SELECT UA.UserID, UA.UserName, Q1.Question, UQ.Answer1, Q2.Question, UQ.Answer2, UA.Password FROM M_UserAccounts UA" + vbCrLf
                strQuery += "LEFT JOIN UserQuestion UQ ON UA.UserID = UQ.UserID" + vbCrLf
                strQuery += "INNER JOIN M_VerificationQuestion Q1 ON UQ.QuestionID1 = Q1.ID" + vbCrLf
                strQuery += "INNER JOIN M_VerificationQuestion Q2 ON UQ.QuestionID2 = Q2.ID" + vbCrLf
                strQuery += "WHERE UA.UserName COLLATE Latin1_General_CS_AS = '" + txtUserName.Text + "'"
                dtVerification = SQL_SELECT(strQuery).Tables(0)

                If dtVerification.Rows.Count <> 0 Then
                    MsgBox("Answer the security question to verify", MsgBoxStyle.Information)

                    txtAnswer_1.ReadOnly = False : txtAnswer_2.ReadOnly = False
                    lblAsterisk_1.Visible = True : lblAsterisk_2.Visible = True
                    txtQuestion_1.Text = dtVerification.Rows(0)(2)
                    txtQuestion_2.Text = dtVerification.Rows(0)(4)
                End If
            Else
                Throw New Exception("Input USERNAME for verification")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            If fn_CheckRequire(Me) Then
                MsgBox("Please complete the required fields(*):" & vbCrLf & strRequire, MsgBoxStyle.Exclamation, "Required Items")
                strRequire = ""
            Else
                If txtAnswer_1.Text.ToLower = dtVerification.Rows(0)(3).ToString.ToLower And _
                    txtAnswer_2.Text.ToLower = dtVerification.Rows(0)(5).ToString.ToLower Then
                    txtOldPass.Text = dtVerification.Rows(0)(6)
                    pnlTop.Height = 230
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlTop.Height = 20
    End Sub

    Private Sub chkShowHide_P_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowHide_P.CheckedChanged
        showHidePass(chkShowHide_P, txtOldPass)
    End Sub

    Private Sub showHidePass(chk As CheckBox, txt As TextBox)
        If chk.Checked Then
            chk.Text = "&Hide"
            txt.PasswordChar = ""
        Else
            chk.Text = "&Show"
            txt.PasswordChar = "•"
        End If
    End Sub

    Private Sub chkShowHide_NP_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowHide_NP.CheckedChanged
        showHidePass(chkShowHide_NP, txtNewPass)
    End Sub

    Private Sub chkShowHide_CNP_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowHide_CNP.CheckedChanged
        showHidePass(chkShowHide_CNP, txtConfirmNewPass)
    End Sub

    Private Sub F_forgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)
        btnSubmit.BackColor = Color.Green
        btnConfirm.BackColor = Color.Green
        pnlTop.Height = 20
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            If txtNewPass.Text = "" Or txtConfirmNewPass.Text = "" Then
                Throw New Exception("Please Complete the required")
            ElseIf txtNewPass.Text <> txtConfirmNewPass.Text Then
                Throw New Exception("Please confirm your new password correctly")
            Else
                strQuery = "UPDATE M_UserAccounts" + vbCrLf
                strQuery += "SET Password = '" + txtNewPass.Text + "'"
                strQuery += ", UpdatedDate = getdate()" + vbCrLf
                strQuery += ", UpdatedBy = '" + dtVerification.Rows(0)(1) + "'" + vbCrLf
                strQuery += "WHERE UserID = '" + dtVerification.Rows(0)(0) + "'"

                If SQL_EXECUTE(strQuery) Then
                    MsgBox("Password changed successfuly!", MsgBoxStyle.Information)
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class