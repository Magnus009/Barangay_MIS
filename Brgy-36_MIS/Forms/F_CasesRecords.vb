Public Class F_CasesRecords
    Dim intCaseType As Integer

    Public Sub loadCaseRecords(caseType As Integer)
        'CaseType:: [0]=>Complaints || [1]=>Incidents || [2]=>Blotters
        Try
            intCaseType = caseType
            Me.Text = Choose(caseType + 1, "COMPLAINTS", "INCIDENTS", "BLOTTERS") & " RECORDS"
            Dim dtCases As New DataTable
            strQuery = "SELECT C.CODE, C.ReportedBy AS 'REPORTED BY', convert(VARCHAR, C.IncidentDate, 111) AS 'INCIDENT DATE', S.Description AS STATUS FROM CasesHeader C" + vbCrLf
            strQuery += "INNER JOIN M_CaseStatus S ON C.StatusID = S.StatusID AND S.TypeID = " + caseType.ToString + vbCrLf
            strQuery += "WHERE C.TypeID = " + caseType.ToString
            dtCases = SQL_SELECT(strQuery).Tables(0)

            datCases.Columns.Clear()
            datCases.DataSource = dtCases

            Me.Show()
            formLoadSetup(Me)
            datPeopleInvolved.ColumnHeadersDefaultCellStyle.Font = My.Settings.Font
            datDocuments.ColumnHeadersDefaultCellStyle.Font = My.Settings.Font
            btnAdd.Font = My.Settings.Substring
            btnAttach.Font = My.Settings.Substring
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub datCases_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles datCases.RowEnter
        'Try
        '    Dim strResidentCode As String
        '    strResidentCode = datResidents.Rows(e.RowIndex).Cells("ID").Value

        '    formMode(0, pnlCaseDetails)
        '    btnUpdate.Text = "UPDATE"
        '    btnUpdate.BackColor = My.Settings.Primary
        '    loadResidentDetails(strResidentCode)
        '    loadResidentHousehold(strResidentCode)
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical)
        'End Try
    End Sub
End Class