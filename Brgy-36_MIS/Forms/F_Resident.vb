Public Class F_Resident

    Dim strCompleteAddress(4) As String
    Private Sub chkPWD_CheckedChanged(sender As Object, e As EventArgs) Handles chkPWD.CheckedChanged
        Call subDisabled()
    End Sub

    Private Sub F_Resident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)
        'CIVIL STATUS
        strQuery = "SELECT * FROM M_CivilStatus WHERE DeletedDate IS NULL"
        cboDataBinding(cboCivilStatus, strQuery, "--STATUS--")
        'SAMAHAN
        strQuery = "SELECT * FROM M_Samahan WHERE DeletedDate IS NULL"
        cboDataBinding(cboSamahan, strQuery, "--SELECT SAMAHAN--")
        'HOUSEHOLD ROLE
        strQuery = "SELECT * FROM M_HouseholdRole WHERE DeletedDate IS NULL"
        cboDataBinding(cboRole, strQuery, "--CHOOSE ROLE--")

        Call subDisabled()
        strCompleteAddress(0) = txtHouseNo.Text & " "
        strCompleteAddress(1) = txtStreet.Text & ", "
        strCompleteAddress(2) = txtBarangay.Text & ", "
        strCompleteAddress(3) = txtMunicipality.Text & ", "
        strCompleteAddress(4) = txtProvince.Text
        Call subCompleteAddress()
    End Sub

    Private Sub subDisabled()
        If chkPWD.Checked Then
            lblDiasability.Visible = True
            txtDisability.Visible = True
        Else
            lblDiasability.Visible = False
            txtDisability.Visible = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call fn_ClearField(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If fn_CheckRequire(Me) Then
                strRequire = "" : blnRequired = False
                MsgBox("Please complete the required fields(*):" & vbCrLf & strRequire, MsgBoxStyle.Exclamation, "Required Items")
            Else
                'Insert Resident Information
                Dim strResidentCode As String
                strQuery = "SELECT dbo.fn_colID ('R')"
                strResidentCode = SQL_SELECT(strQuery).Tables(0).Rows(0)(0)

                strQuery = "INSERT INTO Residents (Code, FamilyName, GivenName, MiddleName, ExtensionName, Gender, BirthDate, BirthPlace, Citizenship, CivilStatus, ContactNo, Occupation, SamahanID, isVoter, inHabitant, Indigent, isPWD, Disabilities, isPregnant, DeliveryDate, DateOfCaseStudy, CreatedDate, UpdatedDate, UpdatedBy)" + vbCrLf
                strQuery += "VALUES ('" + strResidentCode + "', " + vbCrLf
                strQuery += "'" + txtLName.Text + "', " + vbCrLf
                strQuery += "'" + txtFName.Text + "', " + vbCrLf
                strQuery += "'" + txtMName.Text + "', " + vbCrLf
                strQuery += "'" + txtEName.Text + "', " + vbCrLf
                strQuery += "'" + Strings.Left(UCase(cboSex.Text), 1) + "', " + vbCrLf
                strQuery += "'" + fn_Date(dtpBirthdate.Value) + "', " + vbCrLf
                strQuery += "'" + txtBirthPlace.Text + "', " + vbCrLf
                strQuery += "'" + txtCitizenship.Text + "', " + vbCrLf
                strQuery += cboVal(cboCivilStatus) + ", " + vbCrLf
                strQuery += "'" + txtContactNo.Text + "', " + vbCrLf
                strQuery += "'" + txtOccupation.Text + "', " + vbCrLf
                strQuery += cboVal(cboSamahan) + ", " + vbCrLf
                strQuery += chkVal(chkVoter) + ", " + vbCrLf
                strQuery += chkVal(chkInHabitant) + ", " + vbCrLf
                strQuery += chkVal(chkIndigent) + ", " + vbCrLf
                strQuery += chkVal(chkPWD) + ", " + vbCrLf
                strQuery += "'" + txtDisability.Text + "', " + vbCrLf
                strQuery += chkVal(chkPregnant) + ", " + vbCrLf
                strQuery += IIf(chkPregnant.Checked, "'" + fn_Date(dtpDelivery.Value) + "'", "NULL") + ", " + vbCrLf
                strQuery += "'" + fn_Date(dtpCaseStudy.Value) + "', " + vbCrLf
                strQuery += "getdate(), " + vbCrLf
                strQuery += "getdate(), " + vbCrLf
                strQuery += "'" + UserName + "')"



                If SQL_EXECUTE(strQuery) Then
                    'Insert Household Information
                    Dim intHouseHoldNo As Integer

                    strQuery = "SELECT coalesce(max(HouseholdNo), 0) FROM Household WHERE HouseNo = " + txtHouseNo.Text
                    intHouseHoldNo = SQL_SELECT(strQuery).Tables(0).Rows(0)(0)
                    If intHouseHoldNo = 0 Or txtHouseholdNo.Text = "" Then
                        intHouseHoldNo += 1

                        strQuery = "INSERT INTO Household (HouseNo, HouseholdNo, Barangay, Street, Municipality, Province, ContactNo, CreatedDate, UpdatedDate, UpdatedBy)" + vbCrLf
                        strQuery += "VALUES (" + txtHouseNo.Text + ", " + vbCrLf
                        strQuery += intHouseHoldNo.ToString + ", " + vbCrLf
                        strQuery += "'" + txtBarangay.Text + "', " + vbCrLf
                        strQuery += "'" + txtStreet.Text + "', " + vbCrLf
                        strQuery += "'" + txtMunicipality.Text + "', " + vbCrLf
                        strQuery += "'" + txtProvince.Text + "', " + vbCrLf
                        strQuery += "'" + txtHouseContactNo.Text + "', " + vbCrLf
                        strQuery += "getdate(), " + vbCrLf
                        strQuery += "getdate(), " + vbCrLf
                        strQuery += "'" + UserName + "')"
                        SQL_EXECUTE(strQuery)
                    End If

                    If txtHouseholdNo.Text <> "" Then
                        intHouseHoldNo = txtHouseholdNo.Text
                    End If

                    strQuery = "INSERT INTO dbo.HouseholdMember (HouseNo, HouseholdNo, ResidentCode, Role, CreatedDate, UpdatedDate, UpdatedBy)" + vbCrLf
                    strQuery += "VALUES (" + txtHouseNo.Text + ", " + vbCrLf
                    strQuery += intHouseHoldNo.ToString + ", " + vbCrLf
                    strQuery += "'" + strResidentCode + "', " + vbCrLf
                    strQuery += cboVal(cboRole) + ", " + vbCrLf
                    strQuery += "getdate(), " + vbCrLf
                    strQuery += "getdate(), " + vbCrLf
                    strQuery += "'" + UserName + "')"
                    SQL_EXECUTE(strQuery)

                    MsgBox("Resident Registered Successfully", MsgBoxStyle.Information, "Registration")
                    Me.Close()
                Else
                    Throw New Exception("Resident Registered Failed")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "REGISTRATION")
        End Try
    End Sub

    Private Sub dtpBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthdate.ValueChanged
        If dtpBirthdate.Value > Now Then
            MsgBox("Invalid Birthdate!", MsgBoxStyle.Critical, "ERROR")
        Else
            txtAge.Text = Math.Floor(DateDiff(DateInterval.Day, dtpBirthdate.Value, Now) / 365.25)
        End If
    End Sub

    Private Sub txtStreet_LostFocus(sender As Object, e As EventArgs) Handles txtStreet.LostFocus
        If txtStreet.Text <> "" Then
            If UCase(txtStreet.Text).Contains("STREET") Then
                strCompleteAddress(1) = txtStreet.Text & ", "
            Else
                strCompleteAddress(1) = txtStreet.Text & " Street , "
            End If
            Call subCompleteAddress()
        End If
    End Sub

    Private Sub txtBarangay_LostFocus(sender As Object, e As EventArgs) Handles txtBarangay.LostFocus
        If txtBarangay.Text <> "" Then
            If UCase(txtBarangay.Text).Contains("BARANGAY") Then
                Replace(UCase(txtBarangay.Text), "BARANGAY", "Brgy")
            ElseIf UCase(txtBarangay.Text).Contains("BRGY") Then
                'No Event
            Else
                txtBarangay.Text = "Brgy " & txtBarangay.Text
            End If

            strCompleteAddress(2) = txtBarangay.Text & ", "
            Call subCompleteAddress()
        End If
    End Sub

    Private Sub txtMunicipality_LostFocus(sender As Object, e As EventArgs) Handles txtMunicipality.LostFocus
        If txtMunicipality.Text <> "" Then
            strCompleteAddress(3) = txtMunicipality.Text & ", "
            Call subCompleteAddress()
        End If
    End Sub

    Private Sub txtProvince_LostFocus(sender As Object, e As EventArgs) Handles txtProvince.LostFocus
        If txtProvince.Text <> "" Then
            strCompleteAddress(4) = txtProvince.Text
            Call subCompleteAddress()
        End If
    End Sub

    Public Sub subCompleteAddress()
        txtCompleteAdd.Text = strCompleteAddress(0)
        txtCompleteAdd.Text &= strCompleteAddress(1)
        txtCompleteAdd.Text &= strCompleteAddress(2)
        txtCompleteAdd.Text &= strCompleteAddress(3)
        txtCompleteAdd.Text &= strCompleteAddress(4)
    End Sub

    Private Sub btnHouseList_Click(sender As Object, e As EventArgs) Handles btnHouseList.Click
        Dim frmHouseList As New F_SelectionList

        AddHandler frmHouseList.selectedHouseNo, AddressOf loadHouseholdDetails
        frmHouseList.loadSelection(0)
    End Sub

    Private Sub loadHouseholdDetails(ByVal strHouseNo As String, ByVal strHouseholdNo As String)
        Try

            Dim dtHouse As New DataTable
            cboRole.SelectedValue = -1
            cboRole.Enabled = True


            strQuery = "SELECT HouseholdNo, HouseNo, Barangay, ContactNo, Street, Municipality, Province FROM Household" + vbCrLf
            strQuery += "WHERE HouseNo = " + strHouseNo + vbCrLf
            strQuery += "AND HouseholdNo = " + strHouseholdNo
            dtHouse = SQL_SELECT(strQuery).Tables(0)

            With dtHouse
                If .Rows.Count <> 0 Then
                    txtHouseNo.Text = .Rows(0)("HouseNo")
                    txtHouseholdNo.Text = .Rows(0)("HouseholdNo")
                    txtBarangay.Text = .Rows(0)("Barangay")
                    txtHouseContactNo.Text = .Rows(0)("ContactNo")
                    txtStreet.Text = .Rows(0)("Street")
                    txtMunicipality.Text = .Rows(0)("Municipality")
                    txtProvince.Text = .Rows(0)("Province")

                    strCompleteAddress(1) = txtStreet.Text & " Street , "
                    strCompleteAddress(2) = txtBarangay.Text & ", "
                    strCompleteAddress(3) = txtMunicipality.Text & ", "
                    strCompleteAddress(4) = txtProvince.Text
                    Call subCompleteAddress()

                    Dim intHead As Integer
                    strQuery = "SELECT count(*) FROM HouseholdMember" + vbCrLf
                    strQuery += "WHERE HouseNo = " + strHouseNo + vbCrLf
                    strQuery += "AND HouseholdNo = " + strHouseholdNo + vbCrLf
                    strQuery += "AND Role = 1"
                    intHead = SQL_SELECT(strQuery).Tables(0).Rows(0)(0)

                    If intHead <> 0 Then
                        cboRole.SelectedValue = 2
                        cboRole.Enabled = False
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtHouseNo_TextChanged(sender As Object, e As EventArgs) Handles txtHouseNo.TextChanged
        txtHouseholdNo.Text = ""
        txtBarangay.Text = ""
        txtStreet.Text = ""
        txtMunicipality.Text = ""
        txtProvince.Text = ""
        txtHouseContactNo.Text = ""
        cboRole.SelectedIndex = -1
        cboRole.Enabled = True
        txtCompleteAdd.Text = ""
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
End Class