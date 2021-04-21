Public Class F_CasesRecords
    Dim intCaseType As Integer

    Dim frmCase As New F_CaseFile
    Public Sub loadCaseRecords(caseType As Integer, Optional strFilter As String = "")
        'CaseType:: [0]=>Complaints || [1]=>Incidents || [2]=>Blotters
        Try
            intCaseType = caseType
            Me.Text = Choose(caseType + 1, "COMPLAINTS", "INCIDENTS", "BLOTTERS") & " RECORDS"
            Dim dtCases As New DataTable
            strQuery = "SELECT C.CODE, C.ReportedBy AS 'REPORTED BY', convert(VARCHAR, C.IncidentDate, 111) AS 'INCIDENT DATE', S.Description AS STATUS FROM CasesHeader C" + vbCrLf
            strQuery += "INNER JOIN M_CaseStatus S ON C.StatusID = S.StatusID AND S.TypeID = " + caseType.ToString + vbCrLf
            strQuery += "WHERE C.TypeID = " + caseType.ToString
            If strFilter <> "" Then
                strQuery += strFilter
            End If
            dtCases = SQL_SELECT(strQuery).Tables(0)

            With datCases
                .Columns.Clear()
                .DataSource = dtCases

                .Columns(0).Width = .Width * 0.2
                .Columns(1).Width = .Width * 0.44
                .Columns(2).Width = .Width * 0.35
                .Columns(3).Width = .Width * 0.15
            End With


            Me.Show()
            datPeopleInvolved.ColumnHeadersDefaultCellStyle.Font = My.Settings.Font
            datDocuments.ColumnHeadersDefaultCellStyle.Font = My.Settings.Font
            btnAdd.Font = My.Settings.Substring
            btnAttach.Font = My.Settings.Substring
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub loadCaseStatus(intCaseType As Integer)
        strQuery = "SELECT StatusID, Description FROM M_CaseStatus WHERE DeletedDate IS NULL AND TypeID = " + intCaseType.ToString
        cboDataBinding(cboStatus, strQuery, "--STATUS--")
    End Sub

    Private Sub datCases_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles datCases.RowEnter
        Try
            Dim strCaseCode As String
            strCaseCode = datCases.Rows(e.RowIndex).Cells("CODE").Value
            formMode(0, pnlCaseDetails)
            btnUpdate.Text = "UPDATE"
            btnUpdate.BackColor = My.Settings.Primary
            btnAttach.Visible = False
            btnAdd.Visible = False
            datPeopleInvolved.Columns("colView").Visible = False
            datDocuments.Columns("colDelete").Visible = False
            loadCaseDetails(strCaseCode)
            'loadResidentHousehold(strResidentCode)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub loadCaseDetails(strCaseCode As String)
        Try
            Dim dtCaseHeader As New DataTable

            strQuery = "SELECT * FROM CasesHeader" + vbCr
            strQuery += "WHERE Code = '" + strCaseCode + "'"
            dtCaseHeader = SQL_SELECT(strQuery).Tables(0)

            With dtCaseHeader
                If .Rows.Count <> 0 Then
                    txtCode.Text = .Rows(0)("Code")
                    txtReportedBy.Text = .Rows(0)("ReportedBy")
                    txtReportedByID.Text = .Rows(0)("ReportedByID")
                    txtIncharge.Text = .Rows(0)("InCharge")
                    txtInchargeID.Text = .Rows(0)("InchargeID")
                    cboStatus.SelectedValue = .Rows(0)("StatusID")
                    dtpReportedDate.Value = .Rows(0)("ReportedDate")
                    dtpIncidentDate.Value = .Rows(0)("IncidentDate")
                    txtCaseReport.Text = .Rows(0)("CaseReport")

                    'load People Involved
                    Dim dtPeople As New DataTable
                    strQuery = "SELECT * FROM CasesDetails" + vbCrLf
                    strQuery += "WHERE Code = '" + txtCode.Text + "'" + vbCrLf
                    strQuery += "AND DeletedDate IS NULL"
                    dtPeople = SQL_SELECT(strQuery).Tables(0)
                    Dim rowPeople As String()

                    datPeopleInvolved.Rows.Clear()
                    For Each row As DataRow In dtPeople.Rows
                        rowPeople = New String() {row("Seq"), row("PersonInvolved"), row("Involvement"), row("isResident"), row("ContactNo"), "•••", row("Statement"), row("ResidentCode")}
                        datPeopleInvolved.Rows.Add(rowPeople)
                    Next

                    'load Case Documents
                    Dim dtDocuments As New DataTable
                    strQuery = "SELECT * FROM CasesDocuments" + vbCrLf
                    strQuery += "WHERE Code = '" + txtCode.Text + "'" + vbCrLf
                    strQuery += "AND DeletedDate IS NULL"
                    dtDocuments = SQL_SELECT(strQuery).Tables(0)
                    Dim rowDocs As String()

                    datDocuments.Rows.Clear()
                    For Each row As DataRow In dtDocuments.Rows
                        rowDocs = New String() {row(1), getFileName(row(3)), row(4), row(3), "•••", "X"}
                        datDocuments.Rows.Add(rowDocs)
                    Next
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub datDocuments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datDocuments.CellContentClick
        If e.ColumnIndex = 4 Then
            openFile(datDocuments.Rows(e.RowIndex).Cells("colSourceFile").Value)
        ElseIf e.ColumnIndex = 5 Then
            Dim msgDialog As DialogResult
            msgDialog = MsgBox("Do you want to remove this file?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "REMOVE FILE")

            If msgDialog = Windows.Forms.DialogResult.Yes Then
                datDocuments.Rows.RemoveAt(e.RowIndex)
            End If
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
            Dim frmInvolveDetails As New F_PeopleInvolved
            Dim strPersonInvolved As String()

            Dim dtSupportingDocs As New DataTable
            With dtSupportingDocs
                .Columns.Add("colPresenterID")
                .Columns.Add("colFileName")
                .Columns.Add("colDateSubmitted")
                .Columns.Add("colSourceFile")
                .Columns.Add("colOpen")
                .Columns.Add("colDelete")
            End With

            With datPeopleInvolved
                'Involved Details
                strPersonInvolved = New String() {.Rows(e.RowIndex).Cells("colID").Value, _
                                                  .Rows(e.RowIndex).Cells("colName").Value, _
                                                  .Rows(e.RowIndex).Cells("colResident").Value, _
                                                  .Rows(e.RowIndex).Cells("colInvolvement").Value, _
                                                  .Rows(e.RowIndex).Cells("colContactNo").Value, _
                                                  .Rows(e.RowIndex).Cells("colStatement").Value}
            End With

            'Supporting Documents
            For Each dgr As DataGridViewRow In datDocuments.Rows
                If dgr.Cells("colPresenterID").Value = datPeopleInvolved.Rows(e.RowIndex).Cells("colID").Value Then
                    Dim row As String()
                    row = New String() {dgr.Cells("colPresenterID").Value, _
                                        dgr.Cells("colFileName").Value, _
                                        dgr.Cells("colDateSubmitted").Value, _
                                        dgr.Cells("colSourceFile").Value, _
                                        "•••", _
                                        "X"}
                    dtSupportingDocs.Rows.Add(row)
                End If
            Next

            AddHandler frmInvolveDetails.involvementDetails, AddressOf loadInfo
            frmInvolveDetails.loadInvolvedDetails(strPersonInvolved, dtSupportingDocs)
            frmInvolveDetails.loadDetails(2, Me)
        End If
        'If e.ColumnIndex = 5 Then
        '    With F_PeopleInvolved
        '        'Involved Details
        '        .strInvolveID = datPeopleInvolved.Rows(e.RowIndex).Cells("colID").Value
        '        .txtName.Text = datPeopleInvolved.Rows(e.RowIndex).Cells("colName").Value
        '        .chkResident.Checked = datPeopleInvolved.Rows(e.RowIndex).Cells("colResident").Value
        '        .txtInvolvement.Text = datPeopleInvolved.Rows(e.RowIndex).Cells("colInvolvement").Value
        '        .txtContactNo.Text = datPeopleInvolved.Rows(e.RowIndex).Cells("colContactNo").Value
        '        .txtStatement.Text = datPeopleInvolved.Rows(e.RowIndex).Cells("colStatement").Value
        '        'Supporting Documents
        '        .datDocuments.Rows.Clear()
        '        For Each dgr As DataGridViewRow In datDocuments.Rows
        '            If dgr.Cells("colPresenterID").Value = datPeopleInvolved.Rows(e.RowIndex).Cells("colID").Value Then
        '                Dim row As String()
        '                row = New String() {dgr.Cells("colPresenterID").Value, _
        '                                    dgr.Cells("colFileName").Value, _
        '                                    dgr.Cells("colDateSubmitted").Value, _
        '                                    dgr.Cells("colSourceFile").Value, _
        '                                    "•••", _
        '                                    "X"}
        '                .datDocuments.Rows.Add(row)
        '            End If
        '        Next
        '        .loadDetails(2, Me)
        '    End With
        'End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "UPDATE" Then
            formMode(2, pnlCaseDetails)
            btnResidentList.Visible = False
            btnUpdate.Text = "SAVE"
            btnUpdate.BackColor = Color.Green
            btnResidentList.Visible = True
            btnOfficialsList.Visible = True
            btnAttach.Visible = True
            btnAdd.Visible = True
            datPeopleInvolved.Columns("colView").Visible = True
            datDocuments.Columns("colDelete").Visible = True
        Else
            Dim msgDialog As DialogResult
            msgDialog = MsgBox("Save changes?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "SAVE")

            If msgDialog = Windows.Forms.DialogResult.Yes Then
                updateCase()
                formMode(0, pnlCaseDetails)
                btnUpdate.Text = "UPDATE"
                btnUpdate.BackColor = My.Settings.Primary
                btnAttach.Visible = False
                btnAdd.Visible = False
                datPeopleInvolved.Columns("colView").Visible = False
                datDocuments.Columns("colDelete").Visible = False
                btnResidentList.Visible = False
                btnOfficialsList.Visible = False
            ElseIf msgDialog = Windows.Forms.DialogResult.No Then
                formMode(0, pnlCaseDetails)
                btnUpdate.Text = "UPDATE"
                btnUpdate.BackColor = My.Settings.Primary
                btnAttach.Visible = False
                btnAdd.Visible = False
                datPeopleInvolved.Columns("colView").Visible = False
                datDocuments.Columns("colDelete").Visible = False
                btnResidentList.Visible = False
                btnOfficialsList.Visible = False
            Else
                'NO EVENT FOR CANCEL
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmPeopleInvolved As New F_PeopleInvolved

        frmPeopleInvolved.strInvolveID = datPeopleInvolved.Rows.Count
        AddHandler frmPeopleInvolved.involvementDetails, AddressOf loadInfo
        frmPeopleInvolved.loadDetails(1, Me)

        'Dim frmPeopleInvolved As New F_PeopleInvolved
        'With frmPeopleInvolved
        '    .strInvolveID = datPeopleInvolved.Rows.Count
        '    .loadDetails(1, Me)
        'End With
    End Sub

    Private Sub loadInfo(ByVal strPeopleInvolved As String(), ByVal dtDocuments As DataTable)
        Try
            If strPeopleInvolved(0) >= datPeopleInvolved.Rows.Count Then 'ADD
                'Person Involved Details
                datPeopleInvolved.Rows.Add(strPeopleInvolved)

                'Supporting Documents
                For Each dr As DataRow In dtDocuments.Rows
                    Dim row As String()
                    row = New String() {dr(0), dr(1), dr(2), dr(3), dr(4), dr(5)}
                    datDocuments.Rows.Add(row)
                Next
            Else 'UPDATE
                'Person Involved Details
                For Each dr As DataGridViewRow In datPeopleInvolved.Rows
                    If strPeopleInvolved(0).Equals(dr.Cells(0).Value) Then
                        For i As Integer = 1 To 7
                            dr.Cells(i).Value = strPeopleInvolved(i)
                        Next
                    End If
                Next

                'Supporting Documents
                Dim strRemove As String = ""
                For Each dr As DataGridViewRow In datDocuments.Rows
                    If strPeopleInvolved(0).Equals(dr.Cells(0).Value) Then
                        strRemove += dr.Index.ToString + ","
                        'datDocuments.Rows.Remove(dr)
                    End If
                Next

                For Each strIndex As String In strRemove.Split(",").Reverse
                    If strIndex <> "" Then
                        datDocuments.Rows.RemoveAt(Convert.ToInt32(strIndex))
                    End If
                Next

                For Each dr As DataRow In dtDocuments.Rows
                    Dim row As String()
                    row = New String() {dr(0), dr(1), dr(2), dr(3), dr(4), dr(5)}
                    datDocuments.Rows.Add(row)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub updateCase()
        Try
            Dim strFile As String
            Dim intDocNo As Integer

            ''Update Case Header Record
            strQuery = "UPDATE CasesHeader" + vbCrLf
            strQuery += "SET StatusID = " + cboVal(cboStatus) + vbCrLf
            strQuery += ", CaseReport = '" + txtCaseReport.Text + "'" + vbCrLf
            strQuery += ", InchargeID = '" + txtInchargeID.Text + "'" + vbCrLf
            strQuery += ", InCharge = '" + txtIncharge.Text + "'" + vbCrLf
            strQuery += ", ReportedByID = '" + txtReportedByID.Text + "'" + vbCrLf
            strQuery += ", ReportedBy = '" + txtReportedBy.Text + "'" + vbCrLf
            strQuery += ", ReportedDate = '" + fn_Date(dtpReportedDate.Value) + "'" + vbCrLf
            strQuery += ", IncidentDate = '" + fn_Date(dtpIncidentDate.Value) + "'" + vbCrLf
            strQuery += ", UpdatedDate = getdate()" + vbCrLf
            strQuery += ", UpdatedBy = '" + UserName + "'" + vbCrLf
            strQuery += "WHERE Code = '" + txtCode.Text + "'"

            If SQL_EXECUTE(strQuery) Then
                'Update Case Details
                For Each drPeople As DataGridViewRow In datPeopleInvolved.Rows
                    Dim strResident As String = IIf(drPeople.Cells("colResident").Value = "True", "1", "0")

                    strQuery = "SELECT count(*) FROM CasesDetails" + vbCrLf
                    strQuery += "WHERE Code = '" + txtCode.Text + "' AND Seq = " + drPeople.Cells("colID").Value

                    If SQL_SELECT(strQuery).Tables(0).Rows(0)(0) <> 0 Then
                        strQuery = "UPDATE CasesDetails" + vbCrLf
                        strQuery += "SET ResidentCode = '" + drPeople.Cells("colResidentID").Value + "'" + vbCrLf
                        strQuery += ", PersonInvolved = '" + drPeople.Cells("colName").Value + "'" + vbCrLf
                        strQuery += ", isResident = " + strResident + vbCrLf
                        strQuery += ", Involvement = '" + drPeople.Cells("colInvolvement").Value + "'" + vbCrLf
                        strQuery += ", ContactNo = '" + drPeople.Cells("colContactNo").Value + "'" + vbCrLf
                        strQuery += ", Statement = '" + drPeople.Cells("colStatement").Value + "'" + vbCrLf
                        strQuery += ", UpdatedDate = getdate()" + vbCrLf
                        strQuery += ", UpdatedBy = '" + UserName + "'" + vbCrLf
                        strQuery += "WHERE Code = '" + txtCode.Text + "' AND Seq = " + drPeople.Cells("colID").Value
                    Else
                        strQuery = "INSERT INTO CasesDetails (Code, Seq, ResidentCode, PersonInvolved, isResident, Involvement, ContactNo, Statement, CreatedDate, UpdatedDate, UpdatedBy)" + vbCrLf
                        strQuery += "VALUES ('" + txtCode.Text + "', "
                        strQuery += drPeople.Cells("colID").Value + ", "
                        strQuery += "'" + drPeople.Cells("colResidentID").Value + "', "
                        strQuery += "'" + drPeople.Cells("colName").Value + "', "
                        strQuery += strResident + ", "
                        strQuery += "'" + drPeople.Cells("colInvolvement").Value + "', "
                        strQuery += "'" + drPeople.Cells("colContactNo").Value + "', "
                        strQuery += "'" + drPeople.Cells("colStatement").Value + "', "
                        strQuery += "getdate(), "
                        strQuery += "getdate(), "
                        strQuery += "'" + UserName + "')"
                    End If

                    If SQL_EXECUTE(strQuery) Then
                        intDocNo = 0

                        For Each drDocs As DataGridViewRow In datDocuments.Rows
                            If drDocs.Cells("colPresenterID").Value = drPeople.Cells("colID").Value Then
                                'Check Desktop Documents Directory
                                strFile = copyToDocsDirectory(drDocs.Cells("colSourceFile").Value)
                                intDocNo += 1
                                strQuery = "SELECT count(*) FROM CasesDocuments" + vbCrLf
                                strQuery += "WHERE Code = '" + txtCode.Text + "'" + vbCrLf
                                strQuery += "AND Seq = " + fn_checkNull(drDocs.Cells("colPresenterID").Value) + vbCrLf
                                strQuery += "AND DocNo = " + intDocNo.ToString

                                If SQL_SELECT(strQuery).Tables(0).Rows(0)(0) <> 0 Then
                                    'Update Case Docs
                                    strQuery = "UPDATE CasesDocuments" + vbCrLf
                                    strQuery += "SET FilePath = '" + strFile + "'" + vbCrLf
                                    strQuery += ", UpdatedDate = getdate()" + vbCrLf
                                    strQuery += ", UpdatedBy = '" + UserName + "'" + vbCrLf
                                    strQuery += "WHERE Code = '" + txtCode.Text + "'" + vbCrLf
                                    strQuery += "AND Seq = " + fn_checkNull(drDocs.Cells("colPresenterID").Value) + vbCrLf
                                    strQuery += "AND DocNo = " + intDocNo.ToString
                                Else
                                    strQuery = "INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, UpdatedDate, UpdatedBy)" + vbCrLf
                                    strQuery += "VALUES ('" + txtCode.Text + "', "
                                    strQuery += fn_checkNull(drDocs.Cells("colPresenterID").Value) + ", "
                                    strQuery += intDocNo.ToString + ", "
                                    strQuery += "'" + strFile + "', "
                                    strQuery += "'" + fn_Date(drDocs.Cells("colDateSubmitted").Value) + "', "
                                    strQuery += "getdate(), "
                                    strQuery += "getdate(), "
                                    strQuery += "'" + UserName + "')"
                                End If
                                SQL_EXECUTE(strQuery)
                            End If
                        Next
                    End If
                Next
            End If

            'Independent Docs
            intDocNo = 0
            For Each drDocs As DataGridViewRow In datDocuments.Rows
                If drDocs.Cells("colPresenterID").Value = "" Then
                    'Check Desktop Documents Directory

                    strFile = copyToDocsDirectory(drDocs.Cells("colSourceFile").Value)
                    intDocNo += 1
                    strQuery = "SELECT count(*) FROM CasesDocuments" + vbCrLf
                    strQuery += "WHERE Code = '" + txtCode.Text + "' AND Seq = -1 AND DocNo = " + intDocNo.ToString

                    If SQL_SELECT(strQuery).Tables(0).Rows(0)(0) <> 0 Then
                        strQuery = "UPDATE CasesDocuments" + vbCrLf
                        strQuery += "SET Code = FilePath = '" + strFile + "'" + vbCrLf
                        strQuery += ", UpdatedDate = getdate()" + vbCrLf
                        strQuery += ", UpdatedBy = '" + UserName + "'" + vbCrLf
                        strQuery += "WHERE Code = '" + txtCode.Text + "'" + vbCrLf
                        strQuery += "AND Seq = -1" + vbCrLf
                        strQuery += " AND DocNo = " + intDocNo.ToString
                    Else
                        strQuery = "INSERT INTO CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, UpdatedDate, UpdatedBy)" + vbCrLf
                        strQuery += "VALUES ('" + txtCode.Text + "', "
                        strQuery += "-1, "
                        strQuery += intDocNo.ToString + ", "
                        strQuery += "'" + strFile + "', "
                        strQuery += "'" + fn_Date(drDocs.Cells("colDateSubmitted").Value) + "', "
                        strQuery += "getdate(), "
                        strQuery += "getdate(), "
                        strQuery += "'" + UserName + "')"
                    End If
                    SQL_EXECUTE(strQuery)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub F_CasesRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtCode.Text = "" Then
            btnUpdate.Enabled = False
        Else
            btnUpdate.Enabled = True
        End If
        formLoadSetup(Me)
        loadCaseStatus(intCaseType)
    End Sub

    Private Sub btnResidentList_Click(sender As Object, e As EventArgs) Handles btnResidentList.Click
        Dim frmResidentsList As New F_SelectionList

        AddHandler frmResidentsList.selectedResident, AddressOf loadReportedBy
        frmResidentsList.loadSelection(1)
    End Sub
    Private Sub loadReportedBy(ByVal strResidentID As String)
        txtReportedByID.Text = strResidentID
        strQuery = "SELECT FamilyName + ', ' + GivenName + ' ' + MiddleName + ' ' + ExtensionName  FROM Residents WHERE Code = '" + strResidentID + "'"
        txtReportedBy.Text = SQL_SELECT(strQuery).Tables(0).Rows(0)(0)
    End Sub

    Private Sub btnOfficialsList_Click(sender As Object, e As EventArgs) Handles btnOfficialsList.Click
        Dim frmOfficialsList As New F_SelectionList

        AddHandler frmOfficialsList.selectedOfficial, AddressOf loadIncharge
        frmOfficialsList.loadSelection(2)
    End Sub

    Private Sub loadIncharge(ByVal strOfficialID As String, ByVal strOfficialName As String)
        txtInchargeID.Text = strOfficialID
        txtIncharge.Text = strOfficialName
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim strfilter As String = ""
            If dtpIncident.Checked Then
                strfilter += " AND C.IncidentDate = '" + fn_Date(dtpIncident.Value) + "'"
            End If

            If dtpReported.Checked Then
                strfilter += " AND C.ReportedDate = '" + fn_Date(dtpReported.Value) + "'"
            End If

            If txtSearch.Text <> "" Then
                strfilter += " AND ( C.Code LIKE '%" + txtSearch.Text + "%'" + vbCrLf
                strfilter += "OR C.ReportedBy LIKE '%" + txtSearch.Text + "%')"
            End If

            loadCaseRecords(intCaseType, strfilter)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class