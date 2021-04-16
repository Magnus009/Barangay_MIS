Imports Microsoft.Reporting.WinForms
Public Class F_PrintFireReport
    Dim dtResidentInfo As New DataTable
    Dim dtOfficials As New DataTable
    Private Sub F_PrintFireReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub btnResident_Click(sender As Object, e As EventArgs) Handles btnResident.Click
        Dim frmResidentList As New F_SelectionList

        AddHandler frmResidentList.selectedResident, AddressOf loadResidentsInfo
        frmResidentList.loadSelection(1)

    End Sub

    Private Sub loadResidentsInfo(ByVal strResidentID As String)
        Try
            strQuery = ""
            strQuery += "SELECT distinct Code, FamilyName + ', ' + GivenName + ' ' + MiddleName + ' ' + ExtensionName AS 'ResName'," & vbCrLf
            strQuery += "floor(datediff(day, BirthDate, getdate())/365.25) AS 'Age', BirthDate, CS.Description AS 'CivilStatus'," & vbCrLf
            strQuery += "HH.HouseNo + ' ' + HH.Street + ', ' + HH.Municipality + ', ' + HH.Province AS 'Address'" & vbCrLf
            strQuery += "FROM Residents R" & vbCrLf
            strQuery += "INNER JOIN M_CivilStatus CS ON R.CivilStatus = CS.ID " & vbCrLf
            strQuery += "INNER JOIN HouseholdMember HM ON R.Code = HM.ResidentCode" & vbCrLf
            strQuery += "INNER JOIN Household HH ON HM.HouseNo = HH.HouseNo" & vbCrLf
            strQuery += "AND HM.HouseholdNo = HH.HouseholdNo" & vbCrLf
            strQuery += "WHERE R.Code = '" + strResidentID + "'"
            dtResidentInfo = SQL_SELECT(strQuery).Tables(0)

            txtName.Text = dtResidentInfo.Rows(0)("ResName")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim rpParamDate As New ReportParameter("paramDate", dtpDate.Value)
            dtOfficials = loadOfficials()

            dtResidentInfo.Columns.Add("Purpose")
            dtResidentInfo.Rows(0)("Purpose") = ""


            With F_FireAccidentReport.rpvFireReport
                .RefreshReport()
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsOfficials", dtOfficials))
                .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsResInfo", dtResidentInfo))
                .LocalReport.SetParameters(rpParamDate)
                .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                .ZoomMode = ZoomMode.Percent
                .ZoomPercent = 100

            End With
            F_FireAccidentReport.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class