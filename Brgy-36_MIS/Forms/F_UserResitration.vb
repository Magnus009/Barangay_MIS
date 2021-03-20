Public Class F_UserResitration

    Private Sub F_UserResitration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getQuestions()
        Call getUserLevel()
    End Sub
    Private Sub getQuestions()
        Try
            Dim dsQuestions As New DataSet

            strQuery = ""
            strQuery += "SELECT * FROM M_VerificationQuestion" & vbCrLf
            strQuery += "WHERE DeletedDate is NULL" & vbCrLf
            dsQuestions = SQL_SELECT(strQuery)


            For Each row As DataRow In dsQuestions.Tables(0).Rows
                cboQuestion1.Items.Add(row.Item("Question"))
                cboQuestion2.Items.Add(row.Item("Question"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub getUserLevel()
        Try
            Dim dsUserLevel As New DataSet

            strQuery = ""
            strQuery += "SELECT * FROM M_UserLevel" & vbCrLf
            strQuery += "WHERE DeletedDate is NULL" & vbCrLf
            dsUserLevel = SQL_SELECT(strQuery)

            For Each row As DataRow In dsUserLevel.Tables(0).Rows
                cboUserLevel.Items.Add(row.Item("Description"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim dsID As New DataSet
            Dim dsCheckUser As New DataSet
            Dim strID As String

            If fn_CheckRequire(Me) Then
                MsgBox("Please fill out all the required field" & vbCrLf & strRequire, vbOKOnly + vbExclamation)
            Else
                strQuery = ""
                strQuery += "SELECT count(UserID) FROM M_UserAccounts" & vbCrLf
                strQuery += "WHERE UserName = '" + txtUserName.Text + "'" & vbCrLf
                dsCheckUser = SQL_SELECT(strQuery)

                If dsCheckUser.Tables(0).Rows.Count <> 0 Then
                    MsgBox("User Name already exist!", vbOKOnly + vbExclamation)
                Else
                    strQuery = ""
                    strQuery += "SELECT dbo.fn_colID ('A')"
                    dsID = SQL_SELECT(strQuery)
                    strID = dsID.Tables(0).Rows(0)(0)


                    strQuery = ""
                    strQuery += "INSERT INTO dbo.M_UserAccounts " & vbCrLf
                    strQuery += "(" & vbCrLf
                    strQuery += "UserID," & vbCrLf
                    strQuery += "UserName," & vbCrLf
                    strQuery += "Password," & vbCrLf
                    strQuery += "UserLevel," & vbCrLf
                    strQuery += "CreatedDate," & vbCrLf
                    strQuery += "DeletedDate," & vbCrLf
                    strQuery += "UpdatedDate," & vbCrLf
                    strQuery += "UpdatedBy" & vbCrLf
                    strQuery += ")" & vbCrLf
                    strQuery += "VALUES " & vbCrLf
                    strQuery += "(" & vbCrLf
                    strQuery += "'" + strID + "'," & vbCrLf
                    strQuery += "'" + txtUserName.Text + "'," & vbCrLf
                    strQuery += "'" + txtPassword.Text + "'," & vbCrLf
                    strQuery += "'" + (cboUserLevel.SelectedIndex + 1).ToString + "'," & vbCrLf
                    strQuery += "getdate()," & vbCrLf
                    strQuery += "null," & vbCrLf
                    strQuery += "getdate()," & vbCrLf
                    strQuery += "'user'" & vbCrLf
                    strQuery += ")" & vbCrLf
                    SQL_EXECUTE(strQuery)

                    strQuery = ""
                    strQuery += "INSERT INTO dbo.UserQuestion " & vbCrLf
                    strQuery += "( " & vbCrLf
                    strQuery += "UserID," & vbCrLf
                    strQuery += "QuestionID1," & vbCrLf
                    strQuery += "Answer1," & vbCrLf
                    strQuery += "QuestionID2," & vbCrLf
                    strQuery += "Answer2," & vbCrLf
                    strQuery += "CreatedDate," & vbCrLf
                    strQuery += "UpdatedDate," & vbCrLf
                    strQuery += "DeletedDate," & vbCrLf
                    strQuery += "UpdatedBy" & vbCrLf
                    strQuery += ")" & vbCrLf
                    strQuery += "VALUES" & vbCrLf
                    strQuery += "( " & vbCrLf
                    strQuery += "'" + strID + "'," & vbCrLf
                    strQuery += (cboQuestion1.SelectedIndex + 1).ToString + "," & vbCrLf
                    strQuery += "'" + txtAns1.Text + "'," & vbCrLf
                    strQuery += (cboQuestion2.SelectedIndex + 1).ToString + "," & vbCrLf
                    strQuery += "'" + txtAns2.Text + "'," & vbCrLf
                    strQuery += "getdate()," & vbCrLf
                    strQuery += "getdate()," & vbCrLf
                    strQuery += "Null," & vbCrLf
                    strQuery += "'script'" & vbCrLf
                    strQuery += ")" & vbCrLf
                    SQL_EXECUTE(strQuery)

                    MsgBox("Account Registered!", vbOKOnly + vbInformation)
                End If
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
End Class