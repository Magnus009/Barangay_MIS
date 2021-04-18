Imports Microsoft.Reporting.WinForms
Public Class F_PrintKPForm


    Private Sub F_PrintKPForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)
    End Sub

   
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim rpParamCaseNo As New ReportParameter("paramCaseNo", txtCaseNo.Text)
        Dim rpParamFor As New ReportParameter("paramFor", txtFor.Text)
        Dim rpParamComplainants As New ReportParameter("paramComplainant", txtComplainants.Text)
        Dim rpParamRespondents As New ReportParameter("paramRespondants", txtRespondents.Text)

        With F_KPFormReport.rpvKPForm
            .RefreshReport()
            .LocalReport.SetParameters(rpParamCaseNo)
            .LocalReport.SetParameters(rpParamFor)
            .LocalReport.SetParameters(rpParamComplainants)
            .LocalReport.SetParameters(rpParamRespondents)
            .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            .ZoomMode = ZoomMode.Percent
            .ZoomPercent = 100
        End With
        F_KPFormReport.Show()
    End Sub
End Class