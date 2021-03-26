Public Class F_Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dtUser As New DataTable

        strRequire = "" : blnRequired = False
        If fn_CheckRequire(Me) Then
            MsgBox("Please input users:" + vbCrLf + strRequire, MsgBoxStyle.Exclamation, "LOGIN")
        Else
            strQuery = "SELECT * FROM M_UserAccounts" & vbCrLf
            strQuery += "WHERE UserName COLLATE Latin1_General_CS_AS = '" + txtUser.Text + "'"
            dtUser = SQL_SELECT(strQuery).Tables(0)

            With dtUser
                If .Rows.Count > 0 Then
                    If txtPassword.Text = .Rows(0)("Password").ToString Then
                        Select Case True
                            Case .Rows(0)("isActive") = False
                                MsgBox("User's Account is Deactivated", MsgBoxStyle.Exclamation, "LOGIN")
                                Exit Sub
                            Case Not IsDBNull(.Rows(0)("DeletedDate"))
                                MsgBox("User's Account is Deleted", MsgBoxStyle.Exclamation, "LOGIN")
                                Exit Sub
                        End Select

                        UserName = .Rows(0)("UserName")
                        UserLevel = .Rows(0)("UserLevel").ToString
                        _mdi_MIS.Show()
                        txtUser.Clear()
                        txtPassword.Clear()
                        Me.Hide()
                    End If
                Else
                    MsgBox("Invalid User's Name", MsgBoxStyle.Exclamation, "LOGIN")
                End If
            End With
        End If
    End Sub
    Private Sub chkShowHide_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowHide.CheckedChanged
        If chkShowHide.Checked Then
            chkShowHide.Text = "&Hide"
            txtPassword.PasswordChar = ""
        Else
            chkShowHide.Text = "&Show"
            txtPassword.PasswordChar = "•"
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub F_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim App As AppDomain = AppDomain.CurrentDomain
        'AddHandler App.UnhandledException, AddressOf GlobalException_Handler
    End Sub
End Class