Public Class F_Mapping

    Private initPoint As System.Nullable(Of Point) = Nothing
    'Private g As Graphics = CreateGraphics()


    Dim intH As Integer
    Dim intW As Integer
    Private Sub F_Mapping_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        initPoint = e.Location
        F_Mapping_MouseMove(sender, e)
    End Sub

    Private Sub F_Mapping_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If initPoint IsNot Nothing Then
            Using g As Graphics = CreateGraphics()
                intH = initPoint.Value.Y - e.Location.Y
                intW = initPoint.Value.X - e.Location.X
                intH = IIf(intH < 0, intH * -1, intH)
                intW = IIf(intW < 0, intW * -1, intW)

                TextBox1.Text = intH.ToString + "x" + intW.ToString
                g.DrawRectangle(Pens.Black, initPoint.Value.X, initPoint.Value.Y, intW, intH)
                g.Dispose()
            End Using
            picBox.Invalidate()
            Me.Refresh()
        End If
    End Sub

    Private Sub F_Mapping_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Using g As Graphics = CreateGraphics()
            g.DrawRectangle(Pens.Black, initPoint.Value.X, initPoint.Value.Y, intW, intH)
        End Using
        picBox.Invalidate()
        initPoint = Nothing
    End Sub
End Class