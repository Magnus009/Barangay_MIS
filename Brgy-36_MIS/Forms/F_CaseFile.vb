Public Class F_CaseFile
    Private Sub save(intCaseType As Integer, intTaskMode As Integer)
        'CaseType:: [0]=>Complaints || [1]=>Incidents || [2]=>Blotters
        'TaskMode:: [0]=>Read only  || [1]=>Create    || [2]=>Modify

        Try
            Dim strCaseID As String = ""
            Dim strCaseCode As String

            If intTaskMode = 1 Then
                strRequire = "" : blnRequired = False
                If fn_CheckRequire(Me) Then
                    Throw New Exception("Please input on the following field(s):" + vbCrLf + strRequire)
                Else
                    Select Case Strings.Right(Me.Text, 4)
                        Case "(CP)"
                            strCaseID = "0"
                        Case "(IN)"
                            strCaseID = "1"
                        Case "(BL)"
                            strCaseID = "2"
                    End Select
                    strQuery = "SELECT dbo.fn_caseID (" + strCaseID + ")"
                    strCaseCode = SQL_SELECT(strQuery).Tables(0).Rows(0)(0)

                    'Create Case Header Record
                    strQuery = "INSERT INTO dbo.CasesHeader (Code, TypeID, StatusID, CaseReport, InCharge, ReportedBy, ReportedDate, IncidentDate, CreatedDate, UpdatedDate, UpdatedBy)" + vbCrLf
                    strQuery += "VALUES ('" + strCaseCode + "', "
                    strQuery += intCaseType + ", "
                    strQuery += cboStatus.SelectedIndex + ", "
                    strQuery += "'" + txtCaseReport.Text + "', "
                    strQuery += "'" + txtIncharge.Text + "', "
                    strQuery += "'" + txtReportedBy.Text + "', "
                    strQuery += "'" + dtpReportedDate.Value + "', "
                    strQuery += "'" + dtpIncidentDate.Value + "', "
                    strQuery += "getdate(), "
                    strQuery += "getdate(), "
                    strQuery += "'" + UserName + "')"

                    If SQL_EXECUTE(strQuery) Then
                        'Add Case Details

                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Public Sub openCase(intCaseType As Integer, intTaskMode As Integer)
        'CaseType:: [0]=>Complaints || [1]=>Incidents || [2]=>Blotters
        'TaskMode:: [0]=>Read only  || [1]=>Create    || [2]=>Modify

        Try
            'Case Type
            Select Case intCaseType
                Case 0
                    Me.Text = "FILE COMPLAINT (CP)"
                    lblCaseCode.Text = "COMPLAINT CODE :"
                    lblCaseReport.Text = "COMPLAINT REPORT :"
                    txtCaseReport.Tag = "IN:Complaint Report*"
                Case 1
                    Me.Text = "REPORT INCIDENT (IN)"
                    lblCaseCode.Text = "INCIDENT CODE :"
                    lblCaseReport.Text = "INCIDENT REPORT :"
                    txtCaseReport.Tag = "IN:Incident Report*"
                Case 2
                    Me.Text = "FILE BLOTTER (BL)"
                    lblCaseCode.Text = "BLOTTER CODE :"
                    lblCaseReport.Text = "BLOTTER REPORT :"
                    txtCaseReport.Tag = "IN:Blotter Report*"
            End Select
            'Task Mode
            formMode(intTaskMode, Me)
            If intTaskMode = 1 Then
                cboStatus.SelectedIndex = 0
            ElseIf intTaskMode = 0 Then
                btnSave.Visible = False
                btnAdd.Visible = False
                btnAttach.Visible = False
            End If

            Me.MdiParent = _mdi_MIS
            Me.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        F_PeopleInvolved.ShowDialog()
    End Sub
End Class