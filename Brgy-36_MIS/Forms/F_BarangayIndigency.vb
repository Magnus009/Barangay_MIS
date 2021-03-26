Public Class F_BarangayIndigency

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click

    End Sub
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dtpBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthdate.ValueChanged
        txtAge.Text = Math.Floor(DateDiff(DateInterval.Day, dtpBirthdate.Value, Now) / 365.25)
    End Sub
End Class