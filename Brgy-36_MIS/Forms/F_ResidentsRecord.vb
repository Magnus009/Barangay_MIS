Public Class F_ResidentsRecord

    Private Sub F_ResidentsRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)

        'CIVIL STATUS
        strQuery = "SELECT * FROM M_CivilStatus WHERE DeletedDate IS NULL"
        cboDataBinding(cboCivilStatus, strQuery, "---")
        'SAMAHAN
        strQuery = "SELECT * FROM M_Samahan WHERE DeletedDate IS NULL"
        cboDataBinding(cboSamahan, strQuery, "---")
        'HOUSEHOLD ROLE
        strQuery = "SELECT * FROM M_HouseholdRole WHERE DeletedDate IS NULL"
        cboDataBinding(cboRole, strQuery, "---")

        Call loadResidentRecords()
        AddHandler datResidents.CellFormatting, AddressOf subCellFormat
    End Sub

    Public Sub loadResidentRecords(Optional strFilter As String = "")
        Try
            With datResidents
                .Columns.Clear()
                strQuery = "SELECT R.Code 'ID', R.FamilyName + ', ' + R.GivenName + ' ' + R.MiddleName 'NAME'," & vbCrLf
                strQuery &= "CASE WHEN R.DeletedDate IS NOT NULL THEN 'deleted' END AS 'colStatus' FROM Residents R" + vbCrLf

                If strFilter <> "" Then
                    strQuery &= "WHERE" & strFilter
                End If

                .DataSource = SQL_SELECT(strQuery)
                .DataMember = "Table"

                .Columns(0).Width = .Width * 0.3
                .Columns(1).Width = .Width * 0.69
                .Columns("colStatus").Visible = False
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
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
        Call loadResidentRecords(strFilter)
    End Sub

    Private Sub dtpBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthdate.ValueChanged
        txtAge.Text = Math.Floor(DateDiff(DateInterval.Day, dtpBirthdate.Value, Now) / 365.25)
    End Sub

    Private Sub cboSex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSex.SelectedIndexChanged
        If cboSex.Text = "FEMALE" Then
            chkPregnant.Visible = True
        Else
            chkPregnant.Visible = False : chkPregnant.Checked = False
            lblDelivery.Visible = False : dtpDelivery.Visible = False
        End If
    End Sub

    Private Sub chkPregnant_CheckedChanged(sender As Object, e As EventArgs) Handles chkPregnant.CheckedChanged
        If chkPregnant.Checked Then
            lblDelivery.Visible = True
            dtpDelivery.Visible = True
        Else
            lblDelivery.Visible = False
            dtpDelivery.Visible = False
        End If
    End Sub

    Private Sub datResidents_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles datResidents.RowEnter
        Try
            Dim strResidentCode As String
            strResidentCode = datResidents.Rows(e.RowIndex).Cells("ID").Value

            formMode(0, pnlInformations)
            btnUpdate.Text = "UPDATE"
            btnUpdate.BackColor = My.Settings.Primary
            loadResidentDetails(strResidentCode)
            loadResidentHousehold(strResidentCode)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub loadResidentDetails(strResidentCode As String)
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
                txtBirthPlace.Text = .Rows(0)("BirthPlace")
                dtpBirthdate.Value = .Rows(0)("BirthDate")
                cboSex.SelectedIndex = IIf(.Rows(0)("Gender").Equals("M"), 1, 0)
                chkPregnant.Checked = .Rows(0)("isPregnant")
                dtpDelivery.Value = .Rows(0)("DeliveryDate")
                txtCitizenship.Text = .Rows(0)("Citizenship")
                cboCivilStatus.SelectedValue = IIf(IsDBNull(.Rows(0)("CivilStatus")), -1, .Rows(0)("CivilStatus"))
                txtOccupation.Text = .Rows(0)("Occupation")
                chkVoter.Checked = .Rows(0)("isVoter")
                chkInHabitant.Checked = .Rows(0)("inHabitant")
                cboSamahan.SelectedValue = IIf(IsDBNull(.Rows(0)("SamahanID")), -1, .Rows(0)("SamahanID"))
                chkPWD.Checked = .Rows(0)("isPWD")
                chkIndigent.Checked = .Rows(0)("Indigent")
                txtContactNo.Text = .Rows(0)("ContactNo")
                txtDisability.Text = .Rows(0)("Disabilities")
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

    Private Sub chkPWD_CheckedChanged(sender As Object, e As EventArgs) Handles chkPWD.CheckedChanged
        If chkPWD.Checked Then
            lblDiasability.Visible = True
            txtDisability.Visible = True
        Else
            lblDiasability.Visible = False
            txtDisability.Visible = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCode.Text = ""
        txtName.Text = ""
        Call loadResidentRecords()
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
                'Update House ContactNo.
                strQuery = "UPDATE Household" + vbCrLf
                strQuery += "SET ContactNo = '" + txtHouseContactNo.Text + "'" + vbCrLf
                strQuery += "WHERE HouseNo = " + txtHouseNo.Text + vbCrLf
                strQuery += " AND HouseholdNo = " + txtHouseholdNo.Text
                SQL_EXECUTE(strQuery)

                MsgBox("Resident Information Updated!", MsgBoxStyle.Information, "UPDATED")
                formMode(0, pnlInformations)
                btnUpdate.Text = "UPDATE"
                btnUpdate.BackColor = My.Settings.Primary
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class