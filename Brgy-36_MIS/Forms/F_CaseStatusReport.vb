Imports Microsoft.Reporting.WinForms

Public Class F_CaseStatusReport

    Private Sub F_CaseStatusReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rpvCaseStatus.RefreshReport()
        loadCaseStatus()
    End Sub

    Private Sub loadCaseStatus()
        Try
            Dim dtCaseStatus As New DataTable

            strQuery = ""
            strQuery += "SELECT CH.Code, CT.Description [CaseType], CS.Description [Status]," + vbCrLf
            strQuery += "CH.ReportedBy, CH.InCharge, CH.ReportedDate, CH.IncidentDate FROM CasesHeader CH" & vbCr
            strQuery += "INNER JOIN M_CaseType CT ON CH.TypeID = CT.ID" & vbCrLf
            strQuery += "INNER JOIN M_CaseStatus CS ON CH.TypeID = CS.TypeID" & vbCrLf
            strQuery += "AND CH.StatusID = CS.StatusID"
            dtCaseStatus = SQL_SELECT(strQuery).Tables(0)

            With rpvCaseStatus
                .RefreshReport()
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsCaseStatus", dtCaseStatus))
                .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                .ZoomMode = ZoomMode.Percent
                .ZoomPercent = 100
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class