Imports Microsoft.Reporting.WinForms
Public Class F_PrintResidentsReport
    Dim dtResidentPrint As New DataTable
    Private Sub F_PrintResidentsReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)
        setCivilStatus()
        setGender()
        getSamahan()
        getResidents()
    End Sub
    Private Sub setCivilStatus()
        Try
            Dim dsCivilStatus As New DataSet

            strQuery = ""
            strQuery += "SELECT * FROM M_CivilStatus"

            cboDataBinding(cboCivilStatus, strQuery)
            AddHandler cboCivilStatus.SelectedIndexChanged, AddressOf cboChanged
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub setGender()
        With cboGender
            .Items.Clear()
            .Items.Add("Female")
            .Items.Add("Male")
        End With
        AddHandler cboGender.SelectedIndexChanged, AddressOf cboChanged
    End Sub

    Private Sub getResidents()
        Try
            Dim dsResidents As New DataSet

            strQuery = ""
            strQuery += "SELECT Code, FamilyName +', '+ GivenName +' '+ MiddleName AS 'Name', Gender, CS.Description as 'Civil Status' FROM Residents R" & vbCrLf
            strQuery += "INNER JOIN M_CivilStatus CS ON  R.CivilStatus = CS.ID" & vbCrLf
            If chkVoters.Checked Then
                strQuery += "AND R.isVoter = 1" & vbCrLf
            End If
            If chkInHabitant.Checked Then
                strQuery += "AND R.inHabitant = 1" & vbCrLf
            End If
            If chkPWD.Checked Then
                strQuery += "AND R.isPWD = 1" & vbCrLf
            End If
            If chkIndigent.Checked Then
                strQuery += "AND R.Indigent =1" & vbCrLf
            End If
            If chkSenior.Checked Then
                strQuery += "AND (datediff(day, BirthDate, getdate()) / 365.25) >= 60"
            End If
            If cboGender.Text <> "" Then
                If cboGender.SelectedIndex = 0 Then
                    strQuery += "AND R.Gender ='F'" & vbCrLf
                Else
                    strQuery += "AND R.Gender ='M'" & vbCrLf
                End If
            End If
            If cboCivilStatus.SelectedValue <> -1 Then
                strQuery += "AND R.CivilStatus =" + cboCivilStatus.SelectedValue.ToString & vbCrLf
            End If
            If cboSamahan.SelectedValue <> -1 Then
                strQuery += "AND R.SamahanID =" + cboSamahan.SelectedValue.ToString & vbCrLf
            End If
            dsResidents = SQL_SELECT(strQuery)

            With datResidents
                .Columns.Clear()
                .DataSource = dsResidents.Tables(0)
                .Columns("Code").Width = .Width * 0.2
                .Columns("Name").Width = .Width * 0.47
                .Columns("Gender").Width = .Width * 0.12
                .Columns("Civil Status").Width = .Width * 0.2
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loadResidentInfo()
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboChanged()
        getResidents()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
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
            strQuery += "WHERE R.DeletedDate IS null" & vbCrLf
            If chkVoters.Checked Then
                strQuery += "AND R.isVoter = 1" & vbCrLf
            End If
            If chkInHabitant.Checked Then
                strQuery += "AND R.inHabitant = 1" & vbCrLf
            End If
            If chkPWD.Checked Then
                strQuery += "AND R.isPWD = 1" & vbCrLf
            End If
            If chkIndigent.Checked Then
                strQuery += "AND R.Indigent =1" & vbCrLf
            End If
            If chkSenior.Checked Then
                strQuery += "AND (datediff(day, BirthDate, getdate()) / 365.25) >= 60"
            End If
            If cboGender.Text <> "" Then
                If cboGender.SelectedIndex = 0 Then
                    strQuery += "AND R.Gender ='F'" & vbCrLf
                Else
                    strQuery += "AND R.Gender ='M'" & vbCrLf
                End If
            End If
            If cboCivilStatus.SelectedValue <> -1 Then
                strQuery += "AND R.CivilStatus =" + cboCivilStatus.SelectedValue.ToString & vbCrLf
            End If
            If cboSamahan.SelectedValue <> -1 Then
                strQuery += "AND R.SamahanID =" + cboSamahan.SelectedValue.ToString & vbCrLf
            End If
            dtResidentPrint = SQL_SELECT(strQuery).Tables(0)

            With F_ResidentsReport.rpvResidentsList
                .RefreshReport()
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsResidents", dtResidentPrint))
                .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                .ZoomMode = ZoomMode.Percent
                .ZoomPercent = 100
            End With
            F_ResidentsReport.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub getSamahan()
        Try
            strQuery = "SELECT * FROM M_Samahan WHERE DeletedDate IS NULL"
            cboDataBinding(cboSamahan, strQuery, "--SAMAHAN--")

            AddHandler cboSamahan.SelectedIndexChanged, AddressOf cboChanged
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkIndigent_CheckedChanged(sender As Object, e As EventArgs) Handles chkIndigent.CheckedChanged
        getResidents()
    End Sub

    Private Sub chkPWD_CheckedChanged(sender As Object, e As EventArgs) Handles chkPWD.CheckedChanged
        getResidents()
    End Sub

    Private Sub chkInHabitant_CheckedChanged(sender As Object, e As EventArgs) Handles chkInHabitant.CheckedChanged
        getResidents()
    End Sub

    Private Sub cboSamahan_SelectedIndexChanged(sender As Object, e As EventArgs)
        getResidents()
    End Sub

    Private Sub chkVoters_CheckedChanged(sender As Object, e As EventArgs) Handles chkVoters.CheckedChanged
        getResidents()
    End Sub

    Private Sub chkSenior_CheckedChanged(sender As Object, e As EventArgs) Handles chkSenior.CheckedChanged
        getResidents()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        fn_ClearField(Me)
        getResidents()
    End Sub
End Class