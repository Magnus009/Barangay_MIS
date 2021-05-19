
Public Class F_BarangayMap

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        pnlHouseholdDetails.Visible = True
        pnlSearch.Visible = False
        loadMap(True)
    End Sub

    Private Sub loadMap(blnAssign As Boolean)
        Try
            For Each ctrl As Control In Me.Controls
                If ctrl.GetType() = GetType(Label) Then
                    Dim lbl As New Label
                    lbl = ctrl

                    If blnAssign Then
                        Select Case UCase(lbl.Tag)
                            Case "AVAILABLE"
                                lbl.BackColor = My.Settings.Available
                            Case "OCCUPIED"
                                lbl.BackColor = My.Settings.Occupied
                            Case "UNAVAILABLE"
                                lbl.BackColor = My.Settings.Unavailable
                        End Select

                        AddHandler lbl.Click, AddressOf AssignHouse
                    Else
                        lbl.BackColor = Color.Transparent
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub AssignHouse(sender As Object, e As EventArgs)
        Try
            Dim lblSlot As New Label
            lblSlot = sender

            If UCase(lblSlot.Tag).Equals("AVAILABLE") Then
                Dim msgDialog As DialogResult
                msgDialog = MsgBox("Do you want to Assign household in this Lot?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ASSIGN")

                If msgDialog = Windows.Forms.DialogResult.Yes Then
                    Dim frmHouseList As New F_SelectionList

                    txtLotNo.Text = lblSlot.Name.Replace("lbl", "")
                    cboRemarks.Text = "AVAILABLE"
                    AddHandler frmHouseList.selectedHouseNo, AddressOf loadHouseholdDetails
                    frmHouseList.loadSelection(0)
                End If
            ElseIf UCase(lblSlot.Tag).Equals("UNAVAILABLE") Then
                txtLotNo.Text = lblSlot.Name.Replace("lbl", "")
                cboRemarks.Text = "UNAVAILABLE"
                txtHouseholdNo.Text = "---"
                txtHouseNo.Text = "---"
                txtHead.Text = "---"
            ElseIf UCase(lblSlot.Tag).Equals("OCCUPIED") Then
                Dim dt As New DataTable

                txtLotNo.Text = lblSlot.Name.Replace("lbl", "")
                cboRemarks.Text = "OCCUPIED"

                strQuery = "SELECT HouseNo, HouseholdNo FROM HouseholdMapping WHERE HouseLot = 'lbl" + txtLotNo.Text + "'"
                dt = SQL_SELECT(strQuery).Tables(0)
                loadHouseholdDetails(dt.Rows(0)(0), dt.Rows(0)(1))
            End If
            btnSave.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub loadHouseholdDetails(ByVal strHouseNo As String, ByVal strHouseholdNo As String)
        Try
            Dim dtHousehold As New DataTable
            Dim dtMember As New DataTable

            strQuery = "SELECT H.HouseholdNo, H.HouseNo, H.Street, H.Municipality, H.Province," + vbCrLf
            strQuery += "R.FamilyName + ', ' + R.GivenName + ' ' + R.MiddleName [HouseholdHead] FROM Household H" + vbCrLf
            strQuery += "INNER JOIN HouseholdMember HM ON H.HouseholdNo = HM.HouseholdNo" + vbCrLf
            strQuery += "AND H.HouseNo = HM.HouseNo" + vbCrLf
            strQuery += "AND HM.Role = 1" + vbCrLf
            strQuery += "INNER JOIN Residents R ON HM.ResidentCode = R.Code" + vbCrLf
            strQuery += "WHERE H.HouseholdNo = " + strHouseholdNo + vbCrLf
            strQuery += "AND H.HouseNo = " + strHouseNo
            dtHousehold = SQL_SELECT(strQuery).Tables(0)

            txtHouseholdNo.Text = dtHousehold.Rows(0)("HouseholdNo")
            txtHouseNo.Text = dtHousehold.Rows(0)("HouseNo")
            txtHead.Text = dtHousehold.Rows(0)("HouseholdHead")

            strQuery = "SELECT R.Code [ID], R.GivenName + ' ' + R.FamilyName [NAME] FROM HouseholdMember HM" + vbCrLf
            strQuery += "INNER JOIN Residents R ON HM.ResidentCode = R.Code" + vbCrLf
            strQuery += "WHERE HM.Role = 2" + vbCrLf
            strQuery += "AND HM.HouseholdNo = " + strHouseholdNo + vbCrLf
            strQuery += "AND HM.HouseNo = " + strHouseNo
            dtMember = SQL_SELECT(strQuery).Tables(0)

            With datMember
                .Columns.Clear()
                .DataSource = dtMember
                .Columns(0).Width = .Width * 0.3
                .Columns(1).Width = .Width * 0.69
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub F_BarangayMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadHouses()
    End Sub

    Private Sub loadHouses()
        Try
            Dim dt As New DataTable
            strQuery = "SELECT * FROM HouseholdMapping WHERE DeletedDate IS NULL"
            dt = SQL_SELECT(strQuery).Tables(0)

            For Each dr As DataRow In dt.Rows
                Dim lbl As New Label
                lbl = CType(Me.Controls(dr("HouseLot")), Label)

                lbl.Tag = dr("Remarks")
                lbl.BackColor = Color.LightGray

                AddHandler lbl.MouseHover, AddressOf LotHover
                AddHandler lbl.MouseLeave, AddressOf LotLeave
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub LotHover(sender As Object, e As EventArgs)
        Dim lbl As New Label
        lbl = sender

        lbl.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub LotLeave(sender As Object, e As EventArgs)
        Dim lbl As New Label
        lbl = sender

        lbl.BorderStyle = BorderStyle.None
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim msgDialog As DialogResult
            msgDialog = MsgBox("Do you want to save this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SAVE")

            If msgDialog = Windows.Forms.DialogResult.Yes Then
                Select Case cboRemarks.Text
                    Case "AVAILABLE"
                        strQuery = "UPDATE HouseholdMapping" + vbCrLf
                        strQuery += "SET HouseNo = NULL" + vbCrLf
                        strQuery += ", HouseholdNo = NULL" + vbCrLf
                        strQuery += ", Remarks = 'AVAILABLE'" + vbCrLf
                        strQuery += ", UpdatedDate = getdate()" + vbCrLf
                        strQuery += ", UpdatedBy = '" + UserName + "'" + vbCrLf
                        strQuery += "WHERE HouseLot = 'lbl" + txtLotNo.Text + "'" + vbCrLf
                    Case "OCCUPIED"
                        strQuery = "UPDATE HouseholdMapping" + vbCrLf
                        strQuery += "SET HouseNo = " + txtHouseNo.Text + vbCrLf
                        strQuery += ", HouseholdNo = " + txtHouseholdNo.Text + vbCrLf
                        strQuery += ", Remarks = 'OCCUPIED'" + vbCrLf
                        strQuery += ", UpdatedDate = getdate()" + vbCrLf
                        strQuery += ", UpdatedBy = '" + UserName + "'" + vbCrLf
                        strQuery += "WHERE HouseLot = 'lbl" + txtLotNo.Text + "'" + vbCrLf
                    Case "UNAVAILABLE"
                        strQuery = "UPDATE HouseholdMapping" + vbCrLf
                        strQuery += "SET HouseNo = NULL" + vbCrLf
                        strQuery += ", HouseholdNo = NULL" + vbCrLf
                        strQuery += ", Remarks = 'UNAVAILABLE'" + vbCrLf
                        strQuery += ", UpdatedDate = getdate()" + vbCrLf
                        strQuery += ", UpdatedBy = '" + UserName + "'" + vbCrLf
                        strQuery += "WHERE HouseLot = 'lbl" + txtLotNo.Text + "'"
                End Select
                If SQL_EXECUTE(strQuery) Then
                    MsgBox("Record Saved!", MsgBoxStyle.Information)
                    loadHouses()
                    loadMap(False)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        pnlHouseholdDetails.Visible = False
        pnlSearch.Visible = True
        loadMap(False)
        loadOccupiedHouses()
    End Sub

    Private Sub loadOccupiedHouses()
        Try
            Dim dtOccupied As New DataTable

            strQuery = "SELECT Replace(MAP.HouseLot, 'lbl', '') [LOT], MAP.HouseholdNo [#], MAP.HouseNo [HOUSE No.], R.FamilyName + ', ' + R.GivenName + ' ' + R.MiddleName [HOUSEHOLD HEAD] FROM HouseholdMapping MAP" + vbCrLf
            strQuery += "LEFT JOIN HouseholdMember HM ON MAP.HouseholdNo = HM.HouseholdNo" + vbCrLf
            strQuery += "AND MAP.HouseNo = HM.HouseNo" + vbCrLf
            strQuery += "AND HM.Role = 1" + vbCrLf
            strQuery += "INNER JOIN Residents R ON HM.ResidentCode = R.Code" + vbCrLf
            If txtSHouseNo.Text <> "" Or txtSHouseholdNo.Text <> "" Or txtSearch.Text <> "" Then
                strQuery += "WHERE"

                If txtSHouseNo.Text <> "" Then
                    strQuery += " MAP.HouseNo LIKE '%" + txtSHouseNo.Text + "%' AND"
                End If

                If txtSHouseholdNo.Text <> "" Then
                    strQuery += " MAP.HouseholdNo LIKE '%" + txtSHouseholdNo.Text + "%' AND"
                End If

                If txtSearch.Text <> "" Then
                    strQuery += " (R.FamilyName LIKE '%" + txtSearch.Text + "%'" + vbCrLf
                    strQuery += "OR R.GivenName LIKE '%" + txtSearch.Text + "%') AND"
                End If

                strQuery = Mid(strQuery, 1, Len(strQuery) - 3) + vbCrLf
            End If
            strQuery += "ORDER BY CAST(replace(MAP.HouseLot, 'lbl', '') AS INT)"
            dtOccupied = SQL_SELECT(strQuery).Tables(0)

            With datRecords
                .Columns.Clear()
                .DataSource = dtOccupied
                '.Rows.Clear()
                'For Each dr As DataRow In dtOccupied.Rows
                '    Dim row As String()

                '    row = New String() {dr(0), dr(1), dr(2), dr(3)}
                '    .Rows.Add(row)
                'Next
                .Columns(0).Width = .Width * 0.15
                .Columns(1).Width = .Width * 0.15
                .Columns(2).Width = .Width * 0.25
                .Columns(3).Width = .Width * 0.44
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtSHouseNo_TextChanged(sender As Object, e As EventArgs) Handles txtSHouseNo.TextChanged
        loadOccupiedHouses()
    End Sub

    Private Sub txtSHouseholdNo_TextChanged(sender As Object, e As EventArgs) Handles txtSHouseholdNo.TextChanged
        loadOccupiedHouses()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loadOccupiedHouses()
    End Sub

    Private Sub datRecords_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles datRecords.RowEnter
        Try
            Dim lbl As New Label
            lbl = CType(Me.Controls("lbl" + datRecords.Rows(e.RowIndex).Cells(0).Value), Label)

            lbl.BackColor = My.Settings.Occupied
            lbl.BorderStyle = BorderStyle.FixedSingle
            AddHandler lbl.Click, AddressOf AssignHouse
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub datRecords_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles datRecords.RowLeave
        Try
            Dim lbl As New Label
            lbl = CType(Me.Controls("lbl" + datRecords.Rows(e.RowIndex).Cells(0).Value), Label)

            lbl.BackColor = Color.Transparent
            lbl.BorderStyle = BorderStyle.None
            AddHandler lbl.Click, AddressOf AssignHouse
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class