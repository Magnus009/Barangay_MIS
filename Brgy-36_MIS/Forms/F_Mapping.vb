Public Class F_Mapping
    Private initPoint As System.Nullable(Of Point) = Nothing
    Private lowestPoint As System.Nullable(Of Point) = Nothing
    Private highestPoint As System.Nullable(Of Point) = Nothing

    Dim intH, intW As Integer
    Dim intY, intX As Integer
    Private Sub F_Mapping_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

        initPoint = e.Location
        highestPoint = e.Location
        lowestPoint = e.Location
        F_Mapping_MouseMove(sender, e)
    End Sub

    Private Sub F_Mapping_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If initPoint IsNot Nothing Then
            Using g As Graphics = CreateGraphics()
                Dim rect As New Rectangle(intX, intY, intW, intH)

                intH = initPoint.Value.Y - e.Location.Y
                intW = initPoint.Value.X - e.Location.X

                If e.Location.Y < initPoint.Value.Y Then
                    intY = e.Location.Y
                Else
                    intY = initPoint.Value.Y
                End If

                If e.Location.X < initPoint.Value.X Then
                    intX = e.Location.X
                Else
                    intX = initPoint.Value.X
                End If



                intH = IIf(intH < 0, intH * -1, intH)
                intW = IIf(intW < 0, intW * -1, intW)

                g.DrawRectangle(New Pen(Brushes.SkyBlue, 2), rect)
                If e.Location.X > initPoint.Value.X Or e.Location.Y > initPoint.Value.Y Then
                    If (e.Location.X > highestPoint.Value.X) Or (e.Location.Y > highestPoint.Value.Y) Then
                        highestPoint = e.Location
                    Else
                        g.Dispose()
                        Me.Refresh()
                        highestPoint = e.Location
                    End If
                Else
                    If (e.Location.X < lowestPoint.Value.X) Or (e.Location.Y < lowestPoint.Value.Y) Then
                        lowestPoint = e.Location
                    Else
                        g.Dispose()
                        Me.Refresh()
                        lowestPoint = e.Location
                    End If
                End If
            End Using
            picBox.Invalidate()
        End If
    End Sub

    Private Sub F_Mapping_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Try
            Dim dlg As New DialogResult

            dlg = MsgBox("Do you want to save this location?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "MAPPING")

            If dlg = Windows.Forms.DialogResult.Yes Then
                Dim lbl As New Label
                With lbl
                    .Top = intY
                    .Left = intX
                    .Width = intW
                    .Height = intH
                    .BackColor = My.Settings.Occupied
                    .BorderStyle = BorderStyle.FixedSingle
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Font = New Font("Century Gothic", 6)
                    Me.Controls.Add(lbl)

                    Dim intLotID, intLotNo As Integer

                    'Lot ID
                    strQuery = "SELECT coalesce(max(LotID), 0) + 1 FROM LotPosition"
                    intLotID = SQL_SELECT(strQuery).Tables(0).Rows(0)(0)
                    'Lot No
                    strQuery = "SELECT coalesce(max(LotNo), 0) + 1 FROM LotPosition WHERE LotID = " + intLotID.ToString
                    intLotNo = SQL_SELECT(strQuery).Tables(0).Rows(0)(0)

                    strQuery = "INSERT INTO LotPosition (" + vbCrLf
                    strQuery += "LotID, " + vbCrLf
                    strQuery += "LotNo, " + vbCrLf
                    strQuery += "X, " + vbCrLf
                    strQuery += "Y, " + vbCrLf
                    strQuery += "Width, " + vbCrLf
                    strQuery += "Height, " + vbCrLf
                    strQuery += "CreatedDate, " + vbCrLf
                    strQuery += "UpdatedDate, " + vbCrLf
                    strQuery += "UpdatedBy)" + vbCrLf
                    strQuery += "VALUES (" + vbCrLf
                    strQuery += intLotID.ToString + ", " + vbCrLf
                    strQuery += intLotNo.ToString + ", " + vbCrLf
                    strQuery += "'" + .Left.ToString + "', " + vbCrLf
                    strQuery += "'" + .Top.ToString + "', " + vbCrLf
                    strQuery += "'" + .Width.ToString + "', " + vbCrLf
                    strQuery += "'" + .Height.ToString + "', " + vbCrLf
                    strQuery += "getdate(), " + vbCrLf
                    strQuery += "getdate(), " + vbCrLf
                    strQuery += "'" + UserName + "')"

                    If SQL_EXECUTE(strQuery) Then
                        Dim frmLotOwner As New F_LotOwner

                        frmLotOwner.lblLot.Text = "LOT " + intLotID.ToString + "-" + intLotNo.ToString
                        frmLotOwner.ShowDialog()
                        loadHouses()
                        loadOccupiedHouses()
                    End If
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        picBox.Invalidate()
        Me.Refresh()
        initPoint = Nothing
        highestPoint = Nothing
        lowestPoint = Nothing
    End Sub

    Private Sub F_Mapping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadHouses()
        loadOccupiedHouses()
    End Sub

    Private Sub loadHouses()
        Try
            Dim lblLots As New List(Of Label)
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Label Then
                    lblLots.Add(TryCast(ctrl, Label))
                End If
            Next

            For Each lbl As Label In lblLots
                lbl.Dispose()
            Next

            Dim dtLots As New DataTable
            strQuery = "SELECT 'LOT ' + CAST(LP.LotID AS VARCHAR) + '-' + CAST(LP.LotNo AS VARCHAR) [LotName], " + vbCrLf
            strQuery += "LP.LotID, LP.LotNo, LP.X, LP.Y, LP.Width, LP.Height, R.FamilyName + ' Residence' [Residence]  FROM LotPosition LP" + vbCrLf
            strQuery += "LEFT JOIN Mapping M ON LP.LotID = M.LotID" + vbCrLf
            strQuery += "INNER JOIN HouseholdMember HM ON M.HouseNo = HM.HouseNo" + vbCrLf
            strQuery += "AND M.HouseholdNo = HM.HouseholdNo" + vbCrLf
            strQuery += "INNER JOIN Residents R ON HM.ResidentCode = R.Code" + vbCrLf
            strQuery += "AND HM.Role = 1" + vbCrLf
            strQuery += "AND LP.LotNo = M.LotNo"
            dtLots = SQL_SELECT(strQuery).Tables(0)

            For Each dr As DataRow In dtLots.Rows
                Dim lbl As New Label
                Dim tltLot As New ToolTip

                With lbl
                    .Name = dr("LotName").ToString
                    tltLot.SetToolTip(lbl, "[" + .Name + "]" + vbCrLf + dr("Residence").ToString.ToUpper)
                    .Top = dr("Y")
                    .Left = dr("X")
                    .Width = dr("Width")
                    .Height = dr("Height")
                    If .Width > 20 And .Height > 20 Then
                        .Text = dr("LotName").ToString
                        .TextAlign = ContentAlignment.MiddleCenter
                    End If
                    .Font = New Font("Century Gothic", 6)
                    .BackColor = My.Settings.Occupied
                    .BorderStyle = BorderStyle.FixedSingle
                    .ContextMenuStrip = ctxlot
                    Me.Controls.Add(lbl)
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub DivideLotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DivideLotToolStripMenuItem.Click
        Dim lblLot As New Label
        lblLot = ctxlot.SourceControl

        With lblLot
            If .Width < 20 Or .Height < 20 Then
                MsgBox("Lot Cannot be Divided!", MsgBoxStyle.Critical, "DIVIDE LOT")
            Else
                Dim dlg As New DialogResult
                dlg = MsgBox("Do you want to divide this lot?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "DIVIDE LOT")
                If dlg = Windows.Forms.DialogResult.Yes Then

                    Dim strLotName As String() = .Name.Replace("LOT ", "").Split("-")
                    Dim intLotID As Integer = Convert.ToInt32(strLotName(0))
                    Dim intLotNo As Integer = Convert.ToInt32(strLotName(1))
                    Dim intSplitOrientation As Integer = IIf(.Height > .Width, 0, 1)  '0 => Portait || 1 => Landscape
                    Dim intSplitSize As Integer = .Height / 2

                    strQuery = "UPDATE LotPosition" + vbCrLf
                    strQuery += "SET " + IIf(intSplitOrientation = 0, "Height", "Width") + " = '" + intSplitSize.ToString + "'" + vbCrLf
                    strQuery += ", UpdatedDate = getdate()" + vbCrLf
                    strQuery += ", UpdatedBy = '" + UserName + "'" + vbCrLf
                    strQuery += "WHERE LotID = " + intLotID.ToString + vbCrLf
                    strQuery += "AND LotNo = " + intLotNo.ToString

                    If SQL_EXECUTE(strQuery) Then
                        Dim strNewLotNo As String
                        strQuery = "SELECT max(LotNo) + 1 FROM LotPosition WHERE LotID = " + intLotID.ToString
                        strNewLotNo = SQL_SELECT(strQuery).Tables(0).Rows(0)(0).ToString

                        strQuery = "INSERT INTO LotPosition(" + vbCrLf
                        strQuery += "LotID, " + vbCrLf
                        strQuery += "LotNo, " + vbCrLf
                        strQuery += "X, " + vbCrLf
                        strQuery += "Y, " + vbCrLf
                        strQuery += "Width, " + vbCrLf
                        strQuery += "Height, " + vbCrLf
                        strQuery += "CreatedDate, " + vbCrLf
                        strQuery += "UpdatedDate, " + vbCrLf
                        strQuery += "UpdatedBy)" + vbCrLf
                        strQuery += "VALUES (" + vbCrLf
                        strQuery += intLotID.ToString + ", " + vbCrLf
                        strQuery += strNewLotNo + ", " + vbCrLf
                        strQuery += "'" + IIf(intSplitOrientation = 0, .Left, .Left + intSplitSize).ToString + "', " + vbCrLf
                        strQuery += "'" + IIf(intSplitOrientation = 0, .Top + intSplitSize, .Top).ToString + "', " + vbCrLf
                        strQuery += "'" + IIf(intSplitOrientation = 0, .Width, intSplitSize).ToString + "', " + vbCrLf
                        strQuery += "'" + IIf(intSplitOrientation = 0, intSplitSize, .Height).ToString + "', " + vbCrLf
                        strQuery += "getdate(), " + vbCrLf
                        strQuery += "getdate(), " + vbCrLf
                        strQuery += "'" + UserName + "')" + vbCrLf
                        If SQL_EXECUTE(strQuery) Then
                            Dim frmLotOwner As New F_LotOwner

                            frmLotOwner.lblLot.Text = "LOT " + intLotID.ToString + "-" + strNewLotNo
                            frmLotOwner.ShowDialog()
                            loadHouses()
                            loadOccupiedHouses()
                        End If
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        loadOccupiedHouses()
    End Sub

    Private Sub loadOccupiedHouses()
        Try
            Dim dtLot As New DataTable

            strQuery = "SELECT CAST(M.LotID AS VARCHAR) + '-' + CAST(M.LotNo AS VARCHAR) [LOT], M.HouseNo [HOUSE], " + vbCrLf
            strQuery += "M.HouseholdNo [#], R.FamilyName + ' Residence' [RESIDENCE] FROM Mapping M" + vbCrLf
            strQuery += "LEFT JOIN HouseholdMember HM ON M.HouseholdNo = HM.HouseholdNo" + vbCrLf
            strQuery += "AND M.HouseNo = HM.HouseNo" + vbCrLf
            strQuery += "AND HM.Role = 1" + vbCrLf
            strQuery += "INNER JOIN Residents R ON HM.ResidentCode = R.Code" + vbCrLf
            If txtSHouseNo.Text <> "" Or txtSHouseholdNo.Text <> "" Or txtSearch.Text <> "" Then
                strQuery += "WHERE"

                If txtSHouseNo.Text <> "" Then
                    strQuery += " M.HouseNo LIKE '%" + txtSHouseNo.Text + "%' AND"
                End If

                If txtSHouseholdNo.Text <> "" Then
                    strQuery += " M.HouseholdNo LIKE '%" + txtSHouseholdNo.Text + "%' AND"
                End If

                If txtSearch.Text <> "" Then
                    strQuery += " R.FamilyName LIKE '%" + txtSearch.Text + "%' AND" + vbCrLf
                End If

                strQuery = Mid(strQuery, 1, Len(strQuery) - 3)
            End If
            dtLot = SQL_SELECT(strQuery).Tables(0)

            With datRecords
                .Columns.Clear()
                .DataSource = dtLot
                '.Rows.Clear()
                'For Each dr As DataRow In dtOccupied.Rows
                '    Dim row As String()

                '    row = New String() {dr(0), dr(1), dr(2), dr(3)}
                '    .Rows.Add(row)
                'Next
                .Columns(0).Width = .Width * 0.15
                .Columns(1).Width = .Width * 0.22
                .Columns(2).Width = .Width * 0.125
                .Columns(3).Width = .Width * 0.44
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub datRecords_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles datRecords.RowEnter
        Try
            Dim lbl As New Label
            lbl = CType(Me.Controls("LOT " + datRecords.Rows(e.RowIndex).Cells(0).Value), Label)

            lbl.BackColor = Color.Lime
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub datRecords_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles datRecords.RowLeave
        Try
            Dim lbl As New Label
            lbl = CType(Me.Controls("LOT " + datRecords.Rows(e.RowIndex).Cells(0).Value), Label)

            lbl.BackColor = My.Settings.Occupied
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class