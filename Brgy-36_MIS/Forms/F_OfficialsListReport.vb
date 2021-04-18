Imports Microsoft.Reporting.WinForms

Public Class F_OfficialsListReport

    Private Sub F_OfficialsListReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.rpvOfficialsList.RefreshReport()
        loadOfficials()
    End Sub

    Private Sub loadOfficials()
        Dim dtOfficials As New DataTable

        strQuery = ""
        strQuery += "SELECT O.Code [OfficialCode], O.ResidentCode, " & vbCrLf
        strQuery += "R.FamilyName + ', ' + R.GivenName [Name], R.Gender, R.BirthDate," & vbCrLf
        strQuery += "R.BirthPlace, R.Citizenship, CS.Description [CivilStatus], R.Occupation, " & vbCrLf
        strQuery += "Rk.Description [Rank], CM.Description [Committee], O.TermStart, O.TermEnd FROM Officials O" & vbCrLf
        strQuery += "INNER JOIN Residents R ON O.ResidentCode = R.Code" & vbCrLf
        strQuery += "INNER JOIN M_OfficialPosition OP ON O.PositionID = OP.ID" & vbCrLf
        strQuery += "INNER JOIN M_CivilStatus CS ON R.CivilStatus = CS.ID" & vbCrLf
        strQuery += "INNER JOIN M_OfficialsRank Rk ON O.RankID = Rk.ID" & vbCrLf
        strQuery += "INNER JOIN M_Committee CM ON O.CommitteeID = CM.ID" & vbCrLf
        dtOfficials = SQL_SELECT(strQuery).Tables(0)

        With rpvOfficialsList
            .LocalReport.DataSources.Clear()
            .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsOfficials", dtOfficials))
            .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            .ZoomMode = ZoomMode.Percent
            .ZoomPercent = 100
        End With
    End Sub
End Class