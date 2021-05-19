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
                        lbl.Text = "LOT " + intLotID.ToString + "-" + intLotNo.ToString
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
    End Sub

    Private Sub loadHouses()
        Try
            Dim dtLots As New DataTable
            strQuery = "SELECT 'LOT ' + CAST(LP.LotID AS VARCHAR) + '-' + CAST(LP.LotNo AS VARCHAR) [LotName], LP.LotID, LP.LotNo, LP.X, LP.Y, LP.Width, LP.Height  FROM LotPosition LP" + vbCrLf
            strQuery += "LEFT JOIN Mapping M ON LP.LotID = M.LotID" + vbCrLf
            strQuery += "AND LP.LotNo = M.LotNo"
            dtLots = SQL_SELECT(strQuery).Tables(0)

            For Each dr As DataRow In dtLots.Rows
                Dim lbl As New Label

                With lbl
                    .Text = dr("LotName").ToString
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Top = dr("Y")
                    .Left = dr("X")
                    .Width = dr("Width")
                    .Height = dr("Height")
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
End Class