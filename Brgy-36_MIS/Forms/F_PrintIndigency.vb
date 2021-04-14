Imports Microsoft.Reporting.WinForms

Public Class F_PrintIndigency
    Dim dtResidentInfo As New DataTable
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            dtResidentInfo.Columns.Add("Purpose")
            dtResidentInfo.Rows(0)("Purpose") = txtPurpose.Text

            With F_IndigencyReport.rpvIndigency
                .RefreshReport()
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsResInfo", dtResidentInfo))
                .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                .ZoomMode = ZoomMode.Percent
                .ZoomPercent = 100

            End With
            F_IndigencyReport.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub F_PrintIndigency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            txtResident.Text = dtResidentInfo.Rows(0)("ResName")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmResidentList As New F_SelectionList

        AddHandler frmResidentList.selectedResident, AddressOf loadResidentsInfo
        frmResidentList.loadSelection(1)
    End Sub
End Class