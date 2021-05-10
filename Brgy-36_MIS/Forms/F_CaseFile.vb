Public Class F_CaseFile
    Dim intFormTask As Integer

    ''' <summary>
    ''' caseType:: [0]=>Complaints || [1]=>Incidents || [2]=>Blotters || [3]=>VAWC
    ''' </summary>
    ''' <remarks></remarks>
    Dim caseType As Integer
    Friend strComplaintBlotterCode As String

    Private Function saveFiledCase() As Boolean
        Dim blnSaved As Boolean = False
        Try
            Dim strCaseID As String = ""
            Dim strCaseCode As String
            Dim strFile As String
            Dim intDocNo As Integer

            strRequire = "" : blnRequired = False
            If fn_CheckRequire(Me) Then
                Throw New Exception("Please input on the following field(s):" + vbCrLf + strRequire)
            ElseIf cboStatus.SelectedValue = -1 Then
                Throw New Exception("Please Choose Case Status!")
            Else
                strCaseID = Choose(caseType + 1, "CP", "IN", "BL", "WC")
                strQuery = "SELECT dbo.fn_colID ('" + strCaseID + "')"
                strCaseCode = SQL_SELECT(strQuery).Tables(0).Rows(0)(0)

                'Create Case Header Record
                strQuery = "INSERT INTO CasesHeader (Code, TypeID, StatusID, CaseReport, InchargeID, InCharge, ReportedByID, ReportedBy, ReportedDate, IncidentDate, CreatedDate, UpdatedDate, UpdatedBy)" + vbCrLf
                strQuery += "VALUES ('" + strCaseCode + "', "
                strQuery += caseType.ToString + ", "
                strQuery += cboVal(cboStatus) + ", "
                strQuery += "'" + txtCaseReport.Text + "', "
                strQuery += "'" + txtInchargeID.Text + "', "
                strQuery += "'" + txtIncharge.Text + "', "
                strQuery += "'" + txtReportedByID.Text + "', "
                strQuery += "'" + txtReportedBy.Text + "', "
                strQuery += "'" + fn_Date(dtpReportedDate.Value) + "', "
                strQuery += "'" + fn_Date(dtpIncidentDate.Value) + "', "
                strQuery += "getdate(), "
                strQuery += "getdate(), "
                strQuery += "'" + UserName + "')"
                blnSaved = SQL_EXECUTE(strQuery)

                If blnSaved Then
                    'Add Case Details
                    For Each drPeople As DataGridViewRow In datPeopleInvolved.Rows
                        Dim strResident As String = IIf(drPeople.Cells("colResident").Value = "True", "1", "0")

                        strQuery = "INSERT INTO CasesDetails (Code, Seq, ResidentCode, PersonInvolved, isResident, Involvement, ContactNo, Statement, CreatedDate, UpdatedDate, UpdatedBy)" + vbCrLf
                        strQuery += "VALUES ('" + strCaseCode + "', "
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
                        blnSaved = SQL_EXECUTE(strQuery)

                        If blnSaved Then
                            intDocNo = 0

                            For Each drDocs As DataGridViewRow In datDocuments.Rows
                                If drDocs.Cells("colPresenterID").Value = drPeople.Cells("colID").Value Then
                                    'Check Desktop Documents Directory
                                    strFile = copyToDocsDirectory(drDocs.Cells("colSourceFile").Value)
                                    intDocNo += 1

                                    'Add Case Details
                                    strQuery = "INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, UpdatedDate, UpdatedBy)" + vbCrLf
                                    strQuery += "VALUES ('" + strCaseCode + "', "
                                    strQuery += fn_checkNull(drDocs.Cells("colPresenterID").Value) + ", "
                                    strQuery += intDocNo.ToString + ", "
                                    strQuery += "'" + strFile + "', "
                                    strQuery += "'" + fn_Date(drDocs.Cells("colDateSubmitted").Value) + "', "
                                    strQuery += "getdate(), "
                                    strQuery += "getdate(), "
                                    strQuery += "'" + UserName + "')"
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

                        'Add Case Details
                        strQuery = "INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, UpdatedDate, UpdatedBy)" + vbCrLf
                        strQuery += "VALUES ('" + strCaseCode + "', "
                        strQuery += "-1, "
                        strQuery += intDocNo.ToString + ", "
                        strQuery += "'" + strFile + "', "
                        strQuery += "'" + fn_Date(drDocs.Cells("colDateSubmitted").Value) + "', "
                        strQuery += "getdate(), "
                        strQuery += "getdate(), "
                        strQuery += "'" + UserName + "')"
                        SQL_EXECUTE(strQuery)
                    End If
                Next
                If caseType = 2 Then
                    If cboStatus.SelectedValue = 1 Then
                        Dim frmBlotter As New F_BlotterComplaint
                        frmBlotter.txtCode.Text = strCaseCode
                        AddHandler frmBlotter.complaintBlottered, AddressOf blottered
                        frmBlotter.ShowDialog()
                    ElseIf cboStatus.SelectedValue = 0 Then
                        Dim strSeq As String
                        strQuery = "SELECT coalesce(max(Seq), 0) + 1 FROM BlotterDetails WHERE CaseCode = '" + strCaseCode + "'"
                        strSeq = SQL_SELECT(strQuery).Tables(0).Rows(0)(0)

                        strQuery = "INSERT INTO BlotterDetails (" + vbCrLf
                        strQuery += "CaseCode, " + vbCrLf
                        strQuery += "Seq, " + vbCrLf
                        strQuery += "StatusID, " + vbCrLf
                        strQuery += "CreatedDate, " + vbCrLf
                        strQuery += "UpdatedDate, " + vbCrLf
                        strQuery += "UpdatedBy)"
                        strQuery += "VALUES (" + vbCrLf
                        strQuery += "'" + strCaseCode + "', " + vbCrLf
                        strQuery += strSeq + ", " + vbCrLf
                        strQuery += "0, " + vbCrLf
                        strQuery += "getdate(), " + vbCrLf
                        strQuery += "getdate(), " + vbCrLf
                        strQuery += "'" + UserName + "')"
                        SQL_EXECUTE(strQuery)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return blnSaved
    End Function

    Private Sub blottered(saved As Boolean)
        If saved Then
            Try
                strQuery = "UPDATE CasesHeader" + vbCrLf
                strQuery += "SET StatusID = 4" + vbCrLf
                strQuery += "WHERE Code = '" + strComplaintBlotterCode + "'"

                If SQL_EXECUTE(strQuery) Then
                    MsgBox("Complaint blottered successfully!", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub


    ''' <summary>
    ''' Open Case form <b>CaseType::</b> [0]=>Complaints || [1]=>Incidents || [2]=>Blotters
    ''' </summary>
    ''' <param name="intCaseType">Case Type (<i>Integer</i>) </param>
    Public Sub openCase(intCaseType As Integer)
        Try
            'Case Type
            Select Case intCaseType
                Case 0
                    Me.Text = "FILE COMPLAINT"
                    lblCaseCode.Text = "COMPLAINT CODE :"
                    lblCaseReport.Text = "COMPLAINT REPORT :"
                    txtCaseReport.Tag = "IN:Complaint Report*"
                Case 1
                    Me.Text = "REPORT INCIDENT"
                    lblCaseCode.Text = "INCIDENT CODE :"
                    lblCaseReport.Text = "INCIDENT REPORT :"
                    txtCaseReport.Tag = "IN:Incident Report*"
                Case 2
                    Me.Text = "FILE BLOTTER"
                    lblCaseCode.Text = "BLOTTER CODE :"
                    lblCaseReport.Text = "BLOTTER REPORT :"
                    txtCaseReport.Tag = "IN:Blotter Report*"
                Case 3
                    Me.Text = "VIOLATION AGAINST WOMEN AND CHILDRENS"
                    lblCaseCode.Text = "VAWC CODE :"
                    lblCaseReport.Text = "VIOLATION REPORT :"
                    txtCaseReport.Tag = "IN:VIOLATION Report*"
            End Select
            Me.MdiParent = _mdi_MIS
            Me.Show()

            loadCaseStatus(intCaseType)
            caseType = intCaseType
            With datPeopleInvolved
                .Columns(1).Width = .Width * 0.3
                .Columns(2).Width = .Width * 0.22
                .Columns(3).Width = .Width * 0.15
                .Columns(4).Width = .Width * 0.22
                .Columns(5).Width = .Width * 0.1
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmPeopleInvolved As New F_PeopleInvolved

        frmPeopleInvolved.strInvolveID = datPeopleInvolved.Rows.Count
        AddHandler frmPeopleInvolved.involvementDetails, AddressOf loadInfo
        frmPeopleInvolved.loadDetails(1, Me)
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

    Private Sub loadCaseStatus(intCaseType As Integer)
        strQuery = "SELECT StatusID, Description FROM M_CaseStatus WHERE DeletedDate IS NULL "
        If intCaseType = 0 Then
            strQuery += "AND TypeID = 0 AND StatusID < 4"
        ElseIf intCaseType = 2 Then
            strQuery += "AND TypeID = 2 AND StatusID < 2"
        Else
            strQuery += "AND TypeID = " + intCaseType.ToString
        End If

        cboDataBinding(cboStatus, strQuery, "--STATUS--")
        cboStatus.SelectedIndex = IIf(intCaseType = 2, 0, 1)
    End Sub

    Private Sub datDocuments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datDocuments.CellContentClick
        If e.ColumnIndex = 4 Then
            openFile(datDocuments.Rows(e.RowIndex).Cells("colSourceFile").Value)
        ElseIf e.ColumnIndex = 5 Then
            MsgBox("Do you want to remove this file?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "REMOVE FILE")
            If vbYes Then
                datDocuments.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub deleteDocs(intPresenterID As Integer, strSourceFile As String)
        'TaskMode:: [0]=>Read only  || [1]=>Create    || [2]=>Modify
        Try
            If intFormTask = 1 Then

            ElseIf intFormTask = 2 Then
                strQuery = "UPDATE CasesDocuments" + vbCrLf
                strQuery += "SET DeletedDate = getdate()" + vbCrLf
                strQuery += "WHERE Code = '" + txtCode.Text + "'" + vbCrLf
                strQuery += "AND Seq = " + intPresenterID.ToString + vbCrLf
                strQuery += "AND FilePath = '" + strSourceFile + "'"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
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
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MsgBox("Do you want to save this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "File Case")
        If vbYes Then
            If saveFiledCase() Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnOfficialsList_Click(sender As Object, e As EventArgs) Handles btnOfficialsList.Click
        Dim frmOfficialsList As New F_SelectionList

        AddHandler frmOfficialsList.selectedOfficial, AddressOf loadIncharge
        frmOfficialsList.loadSelection(2)
    End Sub

    Public Sub loadIncharge(ByVal strOfficialID As String, ByVal strOfficialName As String)
        txtInchargeID.Text = strOfficialID
        txtIncharge.Text = strOfficialName
    End Sub

    Private Sub btnResidentList_Click(sender As Object, e As EventArgs) Handles btnResidentList.Click
        Dim frmResidentsList As New F_SelectionList

        AddHandler frmResidentsList.selectedResident, AddressOf loadReportedBy
        frmResidentsList.loadSelection(1)
    End Sub

    Public Sub loadReportedBy(ByVal strResidentID As String)
        txtReportedByID.Text = strResidentID
        strQuery = "SELECT FamilyName + ', ' + GivenName + ' ' + MiddleName + ' ' + ExtensionName  FROM Residents WHERE Code = '" + strResidentID + "'"
        txtReportedBy.Text = SQL_SELECT(strQuery).Tables(0).Rows(0)(0)
    End Sub

    Private Sub chkResident_CheckedChanged(sender As Object, e As EventArgs) Handles chkResident.CheckedChanged
        btnResidentList.Visible = chkResident.Checked
        If chkResident.Checked Then
            txtReportedBy.Text = ""
            txtReportedBy.ReadOnly = True
        Else
            txtReportedBy.ReadOnly = False
        End If
    End Sub

    Private Sub F_CaseFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)
    End Sub
End Class