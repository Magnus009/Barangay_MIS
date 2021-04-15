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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.rpvIndigency = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsResidentInfo = New Brgy_36_MIS.dsResidentInfo()
        Me.dtResidentInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dsResidentInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtResidentInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpvIndigency
        '
        Me.rpvIndigency.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dsResInfo"
        ReportDataSource1.Value = Me.dtResidentInfoBindingSource
        Me.rpvIndigency.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvIndigency.LocalReport.ReportEmbeddedResource = "Brgy_36_MIS.rpIndigency_test.rdlc"
        Me.rpvIndigency.Location = New System.Drawing.Point(1, 3)
        Me.rpvIndigency.Name = "rpvIndigency"
        Me.rpvIndigency.Size = New System.Drawing.Size(711, 405)
        Me.rpvIndigency.TabIndex = 0
        '
        'dsResidentInfo
        '
        Me.dsResidentInfo.DataSetName = "dsResidentInfo"
        Me.dsResidentInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtResidentInfoBindingSource
        '
        Me.dtResidentInfoBindingSource.DataMember = "dtResidentInfo"
        Me.dtResidentInfoBindingSource.DataSource = Me.dsResidentInfo
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
        CType(Me.dsResidentInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtResidentInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rpvIndigency As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtResidentInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsResidentInfo As Brgy_36_MIS.dsResidentInfo
End Class
