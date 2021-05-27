Public Class F_LotOwner

    Dim HouseNo, HouseholdNo As String

    Private Sub F_LotOwner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)
        lblLot.Font = New Font("Century Gothic", 12, FontStyle.Bold)
    End Sub

    Private Sub btnResidence_Click(sender As Object, e As EventArgs) Handles btnResidence.Click
        Dim frmHouseList As New F_SelectionList

        AddHandler frmHouseList.selectedHouseNo, AddressOf loadResidence
        frmHouseList.loadSelection(0)
    End Sub

    Private Sub loadResidence(ByVal strHouseNo As String, ByVal strHouseholdNo As String)
        Try
            Dim dtMember As New DataTable

            strQuery = "SELECT R.FamilyName + ' Family' [Residence] FROM HouseholdMember HM" + vbCrLf
            strQuery += "INNER JOIN Residents R ON HM.ResidentCode = R.Code" + vbCrLf
            strQuery += "AND HM.Role = 1" + vbCrLf
            strQuery += "WHERE HM.HouseNo = " + strHouseNo + vbCrLf
            strQuery += "AND HM.HouseholdNo = " + strHouseholdNo + vbCrLf
            txtResidence.Text = SQL_SELECT(strQuery).Tables(0).Rows(0)(0)

            strQuery = "SELECT R.Code [ID], R.GivenName + ' ' + R.FamilyName [NAME] FROM HouseholdMember HM" + vbCrLf
            strQuery += "INNER JOIN Residents R ON HM.ResidentCode = R.Code" + vbCrLf
            strQuery += "WHERE HM.HouseholdNo = " + strHouseholdNo + vbCrLf
            strQuery += "AND HM.HouseNo = " + strHouseNo
            dtMember = SQL_SELECT(strQuery).Tables(0)

            With datMember
                .Columns.Clear()
                .DataSource = dtMember
                .Columns(0).Width = .Width * 0.3
                .Columns(1).Width = .Width * 0.69
            End With
            HouseNo = strHouseNo
            HouseholdNo = strHouseholdNo
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim dlg As New DialogResult

            dlg = MsgBox("Do you want this residence to occupy this Lot?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "LOT OWNER")
            If dlg = Windows.Forms.DialogResult.Yes Then
                Dim strLotName As String() = lblLot.Text.Replace("LOT ", "").Split("-")
                Dim strLotID As String = strLotName(0)
                Dim strLotNo As String = strLotName(1)

                strQuery = "INSERT INTO Mapping (" + vbCrLf
                strQuery += "LotID, " + vbCrLf
                strQuery += "LotNo, " + vbCrLf
                strQuery += "HouseNo, " + vbCrLf
                strQuery += "HouseholdNo, " + vbCrLf
                strQuery += "CreatedDate, " + vbCrLf
                strQuery += "UpdatedDate, " + vbCrLf
                strQuery += "UpdatedBy)" + vbCrLf
                strQuery += "VALUES (" + vbCrLf
                strQuery += strLotID + ", " + vbCrLf
                strQuery += strLotNo + ", " + vbCrLf
                strQuery += "'" + HouseNo + "', " + vbCrLf
                strQuery += HouseholdNo + ", " + vbCrLf
                strQuery += "getdate(), " + vbCrLf
                strQuery += "getdate(), " + vbCrLf
                strQuery += "'" + UserName + "')"

                If SQL_EXECUTE(strQuery) Then
                    MsgBox("Record Saved Successfully!", MsgBoxStyle.Information, "LOT OWNER")
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class