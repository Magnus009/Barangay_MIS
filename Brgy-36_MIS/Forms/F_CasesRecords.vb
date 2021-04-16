Public Class F_CasesRecords
    Dim intCaseType As Integer

    Public Sub loadCaseRecords(caseType As Integer)
        'CaseType:: [0]=>Complaints || [1]=>Incidents || [2]=>Blotters
        Try
            intCaseType = caseType
            Me.Text = Choose(caseType + 1, "COMPLAINTS", "INCIDENTS", "BLOTTERS") & " RECORDS"
            Dim dtCases As New DataTable
            strQuery = "SELECT C.CODE, C.ReportedBy AS 'REPORTED BY', convert(VARCHAR, C.IncidentDate, 111) AS 'INCIDENT DATE', S.Description AS STATUS FROM CasesHeader C" + vbCrLf
            strQuery += "INNER JOIN M_CaseStatus S ON C.StatusID = S.ID" + vbCrLf
            strQuery += "WHERE C.TypeID = " + caseType.ToString
            dtCases = SQL_SELECT(strQuery).Tables(0)

            datCases.Columns.Clear()
            datCases.DataSource = dtCases

            'btnView
            Dim btnView As New DataGridViewButtonColumn
            btnView.Width = datCases.Width * 0.09
            btnView.Resizable = DataGridViewTriState.False
            btnView.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            btnView.Text = "•••"
            btnView.Name = "VIEW"
            btnView.UseColumnTextForButtonValue = True
            datCases.Columns.Add(btnView)
            Me.Show()
            formLoadSetup(Me)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub datCases_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datCases.CellContentClick
        If datCases.Columns(e.ColumnIndex).Name.Equals("VIEW") Then
            F_CaseFile.txtCode.Text = datCases.Rows(e.RowIndex).Cells(1).Value
            F_CaseFile.openCase(intCaseType)
        End If
    End Sub
End Class