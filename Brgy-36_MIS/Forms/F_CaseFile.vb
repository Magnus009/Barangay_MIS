﻿Public Class F_CaseFile
    Dim intFormTask As Integer

    ''' <summary>
    ''' caseType:: [0]=>Complaints || [1]=>Incidents || [2]=>Blotters || [3]=>VAWC
    ''' </summary>
    ''' <remarks></remarks>
    Dim caseType As Integer

    Private Sub saveFiledCase()
        Try
            Dim strCaseID As String = ""
            Dim strCaseCode As String
            Dim strFile As String
            Dim intDocNo As Integer

            strRequire = "" : blnRequired = False
            If fn_CheckRequire(Me) Then
                Throw New Exception("Please input on the following field(s):" + vbCrLf + strRequire)
            Else
                strCaseID = Choose(caseType + 1, "CP", "IN", "BL", "WC")
                strQuery = "SELECT dbo.fn_colID ('" + strCaseID + "')"
                strCaseCode = SQL_SELECT(strQuery).Tables(0).Rows(0)(0)

                'Create Case Header Record
                strQuery = "INSERT INTO dbo.CasesHeader (Code, TypeID, StatusID, CaseReport, InCharge, ReportedBy, ReportedDate, IncidentDate, CreatedDate, UpdatedDate, UpdatedBy)" + vbCrLf
                strQuery += "VALUES ('" + strCaseCode + "', "
                strQuery += caseType.ToString + ", "
                strQuery += cboVal(cboStatus) + ", "
                strQuery += "'" + txtCaseReport.Text + "', "
                strQuery += "'" + txtIncharge.Text + "', "
                strQuery += "'" + txtReportedBy.Text + "', "
                strQuery += "'" + fn_Date(dtpReportedDate.Value) + "', "
                strQuery += "'" + fn_Date(dtpIncidentDate.Value) + "', "
                strQuery += "getdate(), "
                strQuery += "getdate(), "
                strQuery += "'" + UserName + "')"

                If SQL_EXECUTE(strQuery) Then
                    'Add Case Details
                    For Each drPeople As DataGridViewRow In datPeopleInvolved.Rows
                        Dim strResident As String = IIf(drPeople.Cells("colResident").Value = "True", "1", "0")

                        strQuery = "INSERT INTO CasesDetails (Code, Seq, PersonInvolved, isResident, Involvement, ContactNo, Statement, CreatedDate, UpdatedDate, UpdatedBy)" + vbCrLf
                        strQuery += "VALUES ('" + strCaseCode + "', "
                        strQuery += drPeople.Cells("colID").Value + ", "
                        strQuery += "'" + drPeople.Cells("colName").Value + "', "
                        strQuery += strResident + ", "
                        strQuery += "'" + drPeople.Cells("colInvolvement").Value + "', "
                        strQuery += "'" + drPeople.Cells("colContactNo").Value + "', "
                        strQuery += "'" + drPeople.Cells("colStatement").Value + "', "
                        strQuery += "getdate(), "
                        strQuery += "getdate(), "
                        strQuery += "'" + UserName + "')"

                        If SQL_EXECUTE(strQuery) Then
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
                                    strQuery += "'" + drDocs.Cells("colDateSubmitted").Value + "', "
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
                        strQuery += "'" + drDocs.Cells("colDateSubmitted").Value + "', "
                        strQuery += "getdate(), "
                        strQuery += "getdate(), "
                        strQuery += "'" + UserName + "')"
                        SQL_EXECUTE(strQuery)
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    ''' <summary>
    ''' Open Case form <b>CaseType::</b> [0]=>Complaints || [1]=>Incidents || [2]=>Blotters
    ''' </summary>
    ''' <param name="intCaseType">Case Type (<i>Integer</i>) </param>
    Public Sub openCase(intCaseType As Integer)
        Try
            formLoadSetup(Me)
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
        With F_PeopleInvolved
            .strInvolveID = datPeopleInvolved.Rows.Count
            .loadDetails(intFormTask, Me)
        End With
    End Sub

    Private Sub loadCaseStatus(intCaseType As Integer)
        strQuery = "SELECT StatusID, Description FROM M_CaseStatus WHERE DeletedDate IS NULL AND TypeID = " + intCaseType.ToString
        cboDataBinding(cboStatus, strQuery, "--STATUS--")
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
                .loadDetails(2, Me)
            End With
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MsgBox("Do you want to save this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "File Case")
        If vbYes Then
            saveFiledCase()
            Me.Close()
        End If
    End Sub
End Class