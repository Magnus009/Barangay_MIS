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
                'g.DrawRectangle(New Pen(Brushes.SkyBlue, 2), intX, intY, intW, intH)
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
        Using g As Graphics = CreateGraphics()
            g.DrawRectangle(New Pen(Brushes.Black, 2), intX, intY, intW, intH)
        End Using
        picBox.Invalidate()
        initPoint = Nothing
        highestPoint = Nothing
        lowestPoint = Nothing
    End Sub
End Class