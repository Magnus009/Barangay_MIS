Public Class F_CaseFile
    Dim intFormTask As Integer
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
            intFormTask = intTaskMode
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
        With F_PeopleInvolved
            .strInvolveID = datPeopleInvolved.Rows.Count
            .loadDetails(intFormTask)
        End With
    End Sub


    Private Sub F_CaseFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With datPeopleInvolved
            .Columns(1).Width = .Width * 0.3
            .Columns(2).Width = .Width * 0.22
            .Columns(3).Width = .Width * 0.15
            .Columns(4).Width = .Width * 0.22
            .Columns(5).Width = .Width * 0.1
        End With
    End Sub

    Private Sub datDocuments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datDocuments.CellContentClick
        If e.ColumnIndex = 4 Then
            openFile(datDocuments.Rows(e.RowIndex).Cells("colSourceFile").Value)
        End If
    End Sub

    Private Sub btnAttach_Click(sender As Object, e As EventArgs) Handles btnAttach.Click
        Try
            Dim strSourceFile, strFileName, strTempFile As String
            strSourceFile = openFileDialog()

            If strSourceFile <> "" Then
                strFileName = getFileName(strSourceFile)
                strTempFile = ""

                With datDocuments
                    Dim blnExist As Boolean = False
                    If .Rows.Count = 0 Then strTempFile = copyToTemp(strSourceFile)

                    For Each dr As DataGridViewRow In .Rows
                        If UCase(dr.Cells(1).Value) = UCase(strFileName) Then
                            blnExist = True
                        Else
                            strTempFile = copyToTemp(strSourceFile)
                        End If
                    Next

                    If blnExist Then
                        Throw New Exception("File already exist!")
                    Else
                        Dim row As String()
                        row = New String() {"", strFileName, Today, strTempFile, "•••", "X"}
                        .Rows.Add(row)
                    End If
                End With
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub datPeopleInvolved_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datPeopleInvolved.CellContentClick
        If e.ColumnIndex = 5 Then
            With F_PeopleInvolved
                'Involved Details
                .strInvolveID = datPeopleInvolved.Rows(e.RowIndex).Cells("colID").Value
                .txtName.Text = datPeopleInvolved.Rows(e.RowIndex).Cells("colName").Value
                .chkResident.Checked = datPeopleInvolved.Rows(e.RowIndex).Cells("colResident").Value
                .txtInvolvement.Text = datPeopleInvolved.Rows(e.RowIndex).Cells("colInvolvement").Value
                .txtContactNo.Text = datPeopleInvolved.Rows(e.RowIndex).Cells("colContactNo").Value
                .txtStatement.Text = datPeopleInvolved.Rows(e.RowIndex).Cells("colStatement").Value
                'Supporting Documents
                .datDocuments.Rows.Clear()
                For Each dgr As DataGridViewRow In datDocuments.Rows
                    If dgr.Cells("colPresenterID").Value = datPeopleInvolved.Rows(e.RowIndex).Cells("colID").Value Then
                        Dim row As String()
                        row = New String() {dgr.Cells("colPresenterID").Value, _
                                            dgr.Cells("colFileName").Value, _
                                            dgr.Cells("colDateSubmitted").Value, _
                                            dgr.Cells("colSourceFile").Value, _
                                            "•••", _
                                            "X"}
                        .datDocuments.Rows.Add(row)
                    End If
                Next
                .loadDetails(2)
            End With
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If fn_CheckRequire(Me) Then
                MsgBox("Please complete the required fields(*):" & vbCrLf & strRequire, MsgBoxStyle.Exclamation, "Required Items")
                strRequire = "" : blnRequired = False
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class