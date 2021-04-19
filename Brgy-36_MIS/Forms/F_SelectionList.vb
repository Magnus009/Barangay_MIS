Public Class F_SelectionList

    Friend Event selectedHouseNo(ByVal strHouseNo As String, ByVal strHouseholdNo As String)
    Friend Event selectedResident(ByVal strResidentID As String)
    Friend Event selectedOfficial(ByVal strOfficialID As String, ByVal strOfficialName As String)

    Private Sub loadHouses()
        Try
            With datList
                Dim dtHouses As New DataTable

                .Columns.Clear()
                strQuery = "SELECT H.HouseNo 'HOUSE No.', H.HouseholdNo '#', coalesce(R.FamilyName + ', ' + R.GivenName, '--') 'HOUSEHOLD HEAD' FROM Household H" + vbCrLf
                strQuery += "LEFT JOIN HouseholdMember HM ON H.HouseNo = HM.HouseNo" + vbCrLf
                strQuery += "AND H.HouseholdNo = HM.HouseholdNo" + vbCrLf
                strQuery += "AND HM.Role = 1" + vbCrLf
                strQuery += "LEFT JOIN Residents R ON HM.ResidentCode = R.Code" + vbCrLf
                strQuery += "WHERE H.DeletedDate IS NULL" + vbCrLf
                If txtSearch.Text <> "" Then
                    strQuery += "AND( " + vbCrLf
                    strQuery += "H.HouseNo LIKE '%" + txtSearch.Text + "%'" + vbCrLf
                    strQuery += "OR R.FamilyName LIKE '%" + txtSearch.Text + "%'" + vbCrLf
                    strQuery += "OR R.GivenName LIKE '%" + txtSearch.Text + "%'" + vbCrLf
                    strQuery += ")"
                End If
                dtHouses = SQL_SELECT(strQuery).Tables(0)
                .DataSource = dtHouses

                .Columns("#").Width = .Width * 0.1
                .Columns("HOUSE No.").Width = .Width * 0.25
                .Columns("HOUSEHOLD HEAD").Width = .Width * 0.65
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub loadResidents()
        Try
            With datList
                Dim dtResidents As New DataTable

                .Columns.Clear()
                strQuery = "SELECT Code 'ID', FamilyName + ', ' + GivenName + ' ' + MiddleName + ' ' + ExtensionName 'NAME'," + vbCrLf
                strQuery += "floor(datediff(day, BirthDate, getdate()) /365.25) 'AGE' FROM Residents" + vbCrLf
                strQuery += "WHERE DeletedDate IS NULL" + vbCrLf
                strQuery += "AND isVoter = 1" + vbCrLf
                strQuery += "AND Code NOT IN (" + vbCrLf
                strQuery += "SELECT ResidentCode FROM Officials" + vbCrLf
                strQuery += "WHERE getdate() BETWEEN TermStart AND TermEnd)" + vbCrLf
                If txtSearch.Text <> "" Then
                    strQuery += "AND( " + vbCrLf
                    strQuery += "Code LIKE '%" + txtSearch.Text + "%'" + vbCrLf
                    strQuery += "OR FamilyName LIKE '%" + txtSearch.Text + "%'" + vbCrLf
                    strQuery += "OR GivenName LIKE '%" + txtSearch.Text + "%'" + vbCrLf
                    strQuery += "OR MiddleName LIKE '%" + txtSearch.Text + "%'" + vbCrLf
                    strQuery += ")"
                End If
                dtResidents = SQL_SELECT(strQuery).Tables(0)
                .DataSource = dtResidents

                .Columns("ID").Width = .Width * 0.3
                .Columns("NAME").Width = .Width * 0.57
                .Columns("AGE").Width = .Width * 0.13
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loadOfficials()
        Try
            With datList
                Dim dtOfficial As New DataTable

                .Columns.Clear()
                strQuery = "SELECT O.Code [ID], R.FamilyName + ', ' + R.GivenName + ' ' + R.MiddleName + ' ' + R.ExtensionName [NAME], OP.Description [POSITION] FROM Officials O" + vbCrLf
                strQuery += "INNER JOIN Residents R ON O.ResidentCode = R.Code" + vbCrLf
                strQuery += "INNER JOIN M_OfficialPosition OP ON O.PositionID = OP.ID" + vbCrLf
                strQuery += "WHERE getdate() BETWEEN O.TermStart AND O.TermEnd" + vbCrLf
                If txtSearch.Text <> "" Then
                    strQuery += "AND( " + vbCrLf
                    strQuery += "O.Code LIKE '%" + txtSearch.Text + "%'" + vbCrLf
                    strQuery += "OR R.FamilyName LIKE '%" + txtSearch.Text + "%'" + vbCrLf
                    strQuery += "OR R.GivenName LIKE '%" + txtSearch.Text + "%'" + vbCrLf
                    strQuery += "OR R.MiddleName LIKE '%" + txtSearch.Text + "%'" + vbCrLf
                    strQuery += ")" + vbCrLf
                End If
                strQuery += "ORDER BY OP.ID"
                dtOfficial = SQL_SELECT(strQuery).Tables(0)
                .DataSource = dtOfficial

                .Columns("ID").Width = .Width * 0.22
                .Columns("NAME").Width = .Width * 0.4
                .Columns("POSITION").Width = .Width * 0.4
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If Me.Text.Equals("HOUSEHOLDS LIST") Then
            loadHouses()
        ElseIf Me.Text.Equals("RESIDENT'S LIST") Then
            loadResidents()
        Else
            loadOfficials()
        End If
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            If Me.Text.Equals("HOUSEHOLDS LIST") Then
                If MsgBox("Select this Household?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CHOOSE HOUSEHOLD") = vbYes Then
                    Dim strHouseNo As String = datList.CurrentRow.Cells("HOUSE No.").Value
                    Dim strHouseholdNo As String = datList.CurrentRow.Cells("#").Value

                    RaiseEvent selectedHouseNo(strHouseNo, strHouseholdNo)
                End If
            ElseIf Me.Text.Equals("RESIDENT'S LIST") Then
                If MsgBox("Select this Resident?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CHOOSE RESIDENT") = vbYes Then
                    Dim strResidentID As String = datList.CurrentRow.Cells("ID").Value

                    RaiseEvent selectedResident(strResidentID)
                End If
            Else
                If MsgBox("Select this Official?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CHOOSE OFFICIAL") = vbYes Then
                    Dim strOfficialID As String = datList.CurrentRow.Cells("ID").Value
                    Dim strOfficialName As String = datList.CurrentRow.Cells("NAME").Value

                    RaiseEvent selectedOfficial(strOfficialID, strOfficialName)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub loadSelection(intSelectionType As Integer)
        formLoadSetup(Me)

        Select Case intSelectionType
            Case 0 'Household List
                loadHouses()
                Me.Text = "HOUSEHOLDS LIST"
            Case 1 'Resident for Official
                loadResidents()
                Me.Text = "RESIDENT'S LIST"
            Case 2 'Official Lists
                loadOfficials()
                Me.Text = "OFFICIAL'S LIST"
        End Select
        Me.ShowDialog()
    End Sub
End Class