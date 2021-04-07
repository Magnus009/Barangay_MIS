Public Class F_OfficialsRecord

    Private Sub F_OfficialsRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)

        'POSITION
        strQuery = "SELECT * FROM M_OfficialPosition WHERE DeletedDate IS NULL"
        cboDataBinding(cboPosition, strQuery, "---")

        'RANK
        strQuery = "SELECT * FROM M_OfficialsRank WHERE DeletedDate IS NULL"
        cboDataBinding(cboRank, strQuery, "---")

        'COMMITTEE
        strQuery = "SELECT * FROM M_OfficialsRank WHERE DeletedDate IS NULL"
        cboDataBinding(cboCommittee, strQuery, "---")

        'STATUS
        strQuery = "SELECT * FROM M_OfficialsStatus WHERE DeletedDate IS NULL"
        cboDataBinding(cboStatus, strQuery, "---")

        'HOUSEHOLD ROLE
        strQuery = "SELECT * FROM M_HouseholdRole WHERE DeletedDate IS NULL"
        cboDataBinding(cboRole, strQuery, "---")

        Call loadOfficialsRecords()
        AddHandler datOfficials.CellFormatting, AddressOf subCellFormat
    End Sub

    Public Sub loadOfficialsRecords(Optional strFilter As String = "")
        Try
            With datOfficials
                .Columns.Clear()
                strQuery = "SELECT O.Code 'ID', R.FamilyName + ', ' + R.GivenName + ' ' + R.MiddleName 'NAME',P.Description 'POSITION', " + vbCrLf
                strQuery += "CAST(year(O.TermStart) AS NVARCHAR(4)) +' - ' + CAST(year(O.TermEnd) AS NVARCHAR(4)) 'TERM'," + vbCrLf
                strQuery += "CASE WHEN R.DeletedDate IS NOT NULL THEN 'deleted' END AS 'colStatus' FROM Officials O" + vbCrLf
                strQuery += "INNER JOIN Residents R ON O.ResidentCode = R.Code" + vbCrLf
                strQuery += "INNER JOIN M_OfficialPosition P ON O.Position = P.ID"

                If strFilter <> "" Then
                    strQuery &= "WHERE" & strFilter
                End If

                .DataSource = SQL_SELECT(strQuery)
                .DataMember = "Table"

                .Columns(0).Width = .Width * 0.2
                .Columns(1).Width = .Width * 0.4
                .Columns(2).Width = .Width * 0.3
                .Columns(4).Width = .Width * 0.1
                .Columns("colStatus").Visible = False
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        Dim strFilter As String = ""

        If txtCode.Text <> "" Then
            strFilter = " R.Code = '" & txtCode.Text & "' OR"
        End If
        If txtName.Text <> "" Then
            strFilter &= " R.FamilyName + ', ' + R.GivenName + ' ' + R.MiddleName LIKE '%" & txtName.Text & "%' OR"
        End If
        If strFilter <> "" Then
            strFilter = Strings.Left(strFilter, Len(strFilter) - 2)
        End If
        Call loadOfficialsRecords(strFilter)
    End Sub

    Private Sub datResidents_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles datOfficials.RowEnter
        Try
            Dim strResidentCode As String
            strResidentCode = datOfficials.Rows(e.RowIndex).Cells("ID").Value

            formMode(0, pnlInformations)
            btnUpdate.Text = "UPDATE"
            btnUpdate.BackColor = My.Settings.Primary
            loadOfficialsDetails(strResidentCode)
            loadResidentHousehold(strResidentCode)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub loadOfficialsDetails(strResidentCode As String)
        Dim dtResident As New DataTable

        strQuery = "SELECT Code, FamilyName + ', ' + GivenName + ' ' + MiddleName + ' ' + ExtensionName 'Name'," + vbCrLf
        strQuery += "BirthPlace, BirthDate, Gender, isPregnant, coalesce(DeliveryDate,getdate()) 'DeliveryDate'," + vbCrLf
        strQuery += "Citizenship, CivilStatus, Occupation, isVoter, inHabitant," + vbCrLf
        strQuery += "SamahanID, isPWD, Indigent, ContactNo, Disabilities FROM Residents" + vbCrLf
        strQuery += "WHERE Code = '" + strResidentCode + "'"
        dtResident = SQL_SELECT(strQuery).Tables(0)

        With dtResident
            If .Rows.Count <> 0 Then
                txtID.Text = .Rows(0)("Code")
                txtFullName.Text = .Rows(0)("Name")
            End If
        End With
    End Sub

    Private Sub loadResidentHousehold(strResidentCode As String)
        Dim dtHouse As New DataTable

        strQuery = "SELECT H.HouseholdNo, HM.Role, H.HouseNo, H.Street, H.Barangay," + vbCrLf
        strQuery += "H.Municipality, H.ContactNo, H.Province FROM Household H" + vbCrLf
        strQuery += "INNER JOIN HouseholdMember HM ON H.HouseNo = HM.HouseNo" + vbCrLf
        strQuery += "AND H.HouseholdNo = HM.HouseholdNo" + vbCrLf
        strQuery += "WHERE HM.ResidentCode = '" + strResidentCode + "'"
        dtHouse = SQL_SELECT(strQuery).Tables(0)

        With dtHouse
            If .Rows.Count <> 0 Then
                txtHouseholdNo.Text = .Rows(0)("HouseholdNo")
                cboRole.SelectedValue = IIf(IsDBNull(.Rows(0)("Role")), -1, .Rows(0)("Role"))
                txtHouseNo.Text = .Rows(0)("HouseNo")
                txtStreet.Text = .Rows(0)("Street")
                txtBarangay.Text = .Rows(0)("Barangay")
                txtMunicipality.Text = .Rows(0)("Municipality")
                txtHouseContactNo.Text = .Rows(0)("ContactNo")
                txtProvince.Text = .Rows(0)("Province")
            End If
        End With
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        Call loadOfficialsRecords()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "UPDATE" Then
            formMode(2, pnlInformations)
            btnUpdate.Text = "SAVE"
            btnUpdate.BackColor = Color.Green
        Else
            Dim msgDialog As DialogResult
            msgDialog = MsgBox("Save changes?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "SAVE")

            If msgDialog = Windows.Forms.DialogResult.Yes Then
                updateInfos()
            ElseIf msgDialog = Windows.Forms.DialogResult.No Then
                formMode(0, pnlInformations)
                btnUpdate.Text = "UPDATE"
                btnUpdate.BackColor = My.Settings.Primary
            Else
                'NO EVENT FOR CANCEL
            End If
        End If
    End Sub

    Private Sub updateInfos()
        Try
            'Update Resident's Info
            strQuery = "UPDATE Residents" + vbCrLf
            strQuery += "SET BirthPlace = '" + txtBirthPlace.Text + "'" + vbCrLf
            strQuery += ", BirthDate = '" + fn_Date(dtpBirthdate.Value) + "'" + vbCrLf
            strQuery += ", isPregnant = " + chkVal(chkPregnant) + vbCrLf
            strQuery += ", DeliveryDate = " + IIf(chkPregnant.Checked, "'" + fn_Date(dtpDelivery.Value) + "'", "NULL") + vbCrLf
            strQuery += ", Citizenship = '" + txtCitizenship.Text + "'" + vbCrLf
            strQuery += ", CivilStatus = " + cboVal(cboCivilStatus) + vbCrLf
            strQuery += ", Occupation = '" + txtOccupation.Text + "'" + vbCrLf
            strQuery += ", isVoter = " + chkVal(chkVoter) + vbCrLf
            strQuery += ", inHabitant = " + chkVal(chkInHabitant) + vbCrLf
            strQuery += ", SamahanID = " + cboVal(cboSamahan) + vbCrLf
            strQuery += ", isPWD = " + chkVal(chkPWD) + vbCrLf
            strQuery += ", Indigent = " + chkVal(chkIndigent) + vbCrLf
            strQuery += ", ContactNo = '" + txtContactNo.Text + "'" + vbCrLf
            strQuery += ", Disabilities = '" + txtDisability.Text + "'" + vbCrLf
            strQuery += ", UpdatedDate = getdate()" + vbCrLf
            strQuery += ", UpdatedBy = '" + UserName + "'" + vbCrLf
            strQuery += "WHERE Code = '" + txtID.Text + "'" + vbCrLf

            If SQL_EXECUTE(strQuery) Then
                MsgBox("Officer's Information Updated!", MsgBoxStyle.Information, "UPDATED")
                formMode(0, pnlInformations)
                btnUpdate.Text = "UPDATE"
                btnUpdate.BackColor = My.Settings.Primary
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class