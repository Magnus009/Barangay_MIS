Public Class F_Officials

    Private Sub F_Officials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)
        dtpTermEnd.Value = DateAdd(DateInterval.Year, 3, dtpTermStart.Value)

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
    End Sub

    Private Sub btnResidentList_Click(sender As Object, e As EventArgs) Handles btnResidentList.Click
        Dim frmResidentList As New F_SelectionList

        AddHandler frmResidentList.selectedResident, AddressOf loadResidentsInfo
        frmResidentList.loadSelection(1)
    End Sub

    Private Sub loadResidentsInfo(ByVal strResidentID As String)
        Try
            Dim dt As New DataTable
            strQuery = "SELECT R.Code, R.FamilyName, R.GivenName, R.MiddleName, R.ContactNo," + vbCrLf
            strQuery += "H.HouseholdNo, H.HouseNo, HM.Role, H.Street, H.Barangay, H.Municipality," + vbCrLf
            strQuery += "H.Province, H.ContactNo 'HouseContactNo' FROM Residents R" + vbCrLf
            strQuery += "LEFT JOIN HouseholdMember HM ON R.Code = HM.ResidentCode" + vbCrLf
            strQuery += "LEFT JOIN Household H ON HM.HouseNo = H.HouseNo" + vbCrLf
            strQuery += "AND HM.HouseholdNo = H.HouseholdNo" + vbCrLf
            strQuery += "WHERE R.Code = '" + strResidentID + "'"
            dt = SQL_SELECT(strQuery).Tables(0)

            With dt
                txtID.Text = .Rows(0)("Code")
                txtLName.Text = .Rows(0)("FamilyName")
                txtFName.Text = .Rows(0)("GivenName")
                txtMName.Text = .Rows(0)("MiddleName")
                txtContactNo.Text = .Rows(0)("ContactNo")
                txtHouseholdNo.Text = .Rows(0)("HouseholdNo")
                txtHouseNo.Text = .Rows(0)("HouseNo")
                cboRole.SelectedValue = .Rows(0)("Role")
                txtStreet.Text = .Rows(0)("Street")
                txtBarangay.Text = .Rows(0)("Barangay")
                txtMunicipality.Text = .Rows(0)("Municipality")
                txtProvince.Text = .Rows(0)("Province")
                txtHouseContactNo.Text = .Rows(0)("HouseContactNo")
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        fn_ClearField(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If fn_CheckRequire(Me) Then
                MsgBox("Please complete the required fields(*):" & vbCrLf & strRequire, MsgBoxStyle.Exclamation, "Required Items")
                strRequire = "" : blnRequired = False
            Else

                Dim strOfficialCode As String
                strQuery = "SELECT dbo.fn_colID ('O')"
                strOfficialCode = SQL_SELECT(strQuery).Tables(0).Rows(0)(0)

                strQuery = "INSERT INTO Officials (" + vbCrLf
                strQuery += "Code, " + vbCrLf
                strQuery += "ResidentCode, " + vbCrLf
                strQuery += "Position, " + vbCrLf
                strQuery += "RankID, " + vbCrLf
                strQuery += "CommitteeID, " + vbCrLf
                strQuery += "TermStart, " + vbCrLf
                strQuery += "TermEnd, " + vbCrLf
                strQuery += "StatusID, " + vbCrLf
                strQuery += "ContactNo, " + vbCrLf
                strQuery += "CreatedDate, " + vbCrLf
                strQuery += "UpdatedDate, " + vbCrLf
                strQuery += "UpdatedBy)" + vbCrLf
                strQuery += "VALUES (" + vbCrLf
                strQuery += "'" + strOfficialCode + "', " + vbCrLf
                strQuery += "'" + txtID.Text + "', " + vbCrLf
                strQuery += cboVal(cboPosition) + ", " + vbCrLf
                strQuery += cboVal(cboRank) + ", " + vbCrLf
                strQuery += cboVal(cboCommittee) + ", " + vbCrLf
                strQuery += "'" + fn_Date(dtpTermStart.Value) + "', " + vbCrLf
                strQuery += "'" + fn_Date(dtpTermEnd.Value) + "', " + vbCrLf
                strQuery += cboVal(cboStatus) + ", " + vbCrLf
                strQuery += "'" + txtContactNo.Text + "', " + vbCrLf
                strQuery += "getdate(), " + vbCrLf
                strQuery += "getdate(), " + vbCrLf
                strQuery += "'" + UserName + "')"

                If SQL_EXECUTE(strQuery) Then
                    MsgBox("Official's record successfully saved", MsgBoxStyle.Information, "Official")
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dtpTermStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpTermStart.ValueChanged
        dtpTermEnd.Value = DateAdd(DateInterval.Year, 3, dtpTermStart.Value)
    End Sub
End Class