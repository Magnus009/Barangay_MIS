Public Class F_BarangayIndigendy

    Private Sub F_BarangayIndigendy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.dsIndigency.Tables(0).Rows(0).BeginEdit()
        Me.dsIndigency.Tables(0).Rows(0)("ResidentName") = "FRED"
        Me.dsIndigency.Tables(0).Rows(0)(1) = "TEST"
        Me.dsIndigency.Tables(0).Rows(0)(2) = "TEST"
        Me.dsIndigency.Tables(0).Rows(0)(3) = "TEST"
        Me.dsIndigency.Tables(0).Rows(0)(4) = "TEST"
        Me.dsIndigency.Tables(0).Rows(0).EndEdit()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class