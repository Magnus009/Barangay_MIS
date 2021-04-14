<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_IndigencyReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rpvIndigency = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rpvIndigency
        '
        Me.rpvIndigency.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rpvIndigency.LocalReport.ReportEmbeddedResource = "Brgy_36_MIS.rpIndigency.rdlc"
        Me.rpvIndigency.Location = New System.Drawing.Point(1, 3)
        Me.rpvIndigency.Name = "rpvIndigency"
        Me.rpvIndigency.Size = New System.Drawing.Size(711, 405)
        Me.rpvIndigency.TabIndex = 0
        '
        'F_IndigencyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 408)
        Me.Controls.Add(Me.rpvIndigency)
        Me.Name = "F_IndigencyReport"
        Me.Text = "F_IndigencyReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rpvIndigency As Microsoft.Reporting.WinForms.ReportViewer
End Class
