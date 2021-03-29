Public Class F_ResidentsRecord

    Private Sub F_ResidentsRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadResidentRecords()
        formLoadSetup(Me)
    End Sub

    Public Sub loadResidentRecords(Optional strFilter As String = "")
        Try
            datResidents.Columns.Clear()
            strQuery = "SELECT R.Code 'ID', R.FamilyName + ', ' + R.GivenName + ' ' + R.MiddleName 'NAME'," & vbCrLf
            strQuery &= "CASE WHEN R.DeletedDate IS NOT NULL THEN 'deleted' END AS 'colStatus' FROM Residents R" + vbCrLf
            strQuery &= "LEFT JOIN HouseholdMember HM ON R.Code = HM.ResidentCode" & vbCrLf
            strQuery &= "LEFT JOIN Household H ON H.HouseholdNo = HM.HouseholdNo" & vbCrLf
            If strFilter <> "" Then
                strQuery &= "WHERE" & strFilter
            End If

            datResidents.DataSource = SQL_SELECT(strQuery)
            datResidents.DataMember = "Table"

            'add Button
            'Dim btnView As New DataGridViewButtonColumn

            'btnView.Text = "•••"
            'btnView.Name = "VIEW"
            'btnView.FlatStyle = FlatStyle.Flat
            'btnView.UseColumnTextForButtonValue = True
            'datResidents.Columns.Add(btnView)
            'datResidents.Columns(datResidents.ColumnCount - 1).Width = 50
            With datResidents
                .Columns(0).Width = .Width * 0.3
                .Columns(1).Width = .Width * 0.69
                .Columns("colStatus").Visible = False
            End With

            AddHandler datResidents.CellFormatting, AddressOf subCellFormat
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub datResidents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datResidents.CellClick
    '    If datResidents.Columns(e.ColumnIndex).Name.Equals("VIEW") Then
    '        F_Resident.intTaskMode = IIf(UserLevel = "0", 2, 0)
    '        F_Resident.btnSave.Text = "&UPDATE"
    '        Call F_Resident.loadResidentRecord(datResidents.Rows(e.RowIndex).Cells("ID").Value)
    '    End If
    'End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strFilter As String = ""

        If txtCode.Text <> "" Then
            strFilter = " R.Code = " & txtCode.Text & " OR"
        End If
        If txtName.Text <> "" Then
            strFilter &= " R.FamilyName + ', ' + R.GivenName + ' ' + R.MiddleName LIKE '%" & txtName.Text & "%' OR"
        End If
        If txtHouseNo.Text <> "" Then
            strFilter &= " H.HouseholdNo = " & txtHouseNo.Text & " OR"
        End If
        If strFilter <> "" Then
            strFilter = Strings.Left(strFilter, Len(strFilter) - 2)
        End If
        Call loadResidentRecords(strFilter)
    End Sub

    Private Sub datResidents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datResidents.CellClick
        F_Resident.intTaskMode = IIf(UserLevel = "0", 2, 0)
        F_Resident.btnSave.Text = "&UPDATE"
        Call F_Resident.loadResidentRecord(datResidents.Rows(e.RowIndex).Cells("ID").Value)
    End Sub

End Class