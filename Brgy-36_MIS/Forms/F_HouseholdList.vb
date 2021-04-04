Public Class F_HouseholdList

    Friend Event selectedHouseNo(ByVal strHouseNo As String, ByVal strHouseholdNo As String)

    Private Sub loadHouses()
        Try
            With datHouses
                Dim dtHouses As New DataTable

                .Columns.Clear()
                strQuery = "SELECT H.HouseNo 'HOUSE No.', H.HouseholdNo '#', coalesce(R.FamilyName + ', ' + R.GivenName, '--') 'HOUSEHOLD HEAD' FROM Household H" & vbCrLf
                strQuery &= "LEFT JOIN HouseholdMember HM ON H.HouseNo = HM.HouseNo" & vbCrLf
                strQuery &= "AND H.HouseholdNo = HM.HouseholdNo" & vbCrLf
                strQuery &= "AND HM.Role = 1" & vbCrLf
                strQuery &= "LEFT JOIN Residents R ON HM.ResidentCode = R.Code" & vbCrLf
                strQuery &= "WHERE H.DeletedDate IS NULL" & vbCrLf
                If cboSearch.Text <> "" And txtSearch.Text <> "" Then
                    strQuery &= "AND " & IIf(cboSearch.SelectedIndex = 5, "R.", "H.") & cboSearch.Text & " LIKE '%" & txtSearch.Text & "%'"
                End If
                dtHouses = SQL_SELECT(strQuery).Tables(0)
                .DataSource = dtHouses

                .Columns("#").Width = .Width * 0.08
                .Columns("HOUSE No.").Width = .Width * 0.25
                .Columns("HOUSEHOLD HEAD").Width = .Width * 0.65
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub F_HouseholdList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)
        Call loadHouses()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If cboSearch.Text <> "" Then
            loadHouses()
        End If
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            If MsgBox("Select this Household?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CHOOSE HOUSEHOLD") = vbYes Then
                Dim strHouseNo As String = datHouses.CurrentRow.Cells("HOUSE No.").Value
                Dim strHouseholdNo As String = datHouses.CurrentRow.Cells("#").Value

                RaiseEvent selectedHouseNo(strHouseNo, strHouseholdNo)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class