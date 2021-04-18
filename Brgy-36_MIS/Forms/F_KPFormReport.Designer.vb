<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_KPFormReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_KPFormReport))
        Me.rpvKPForm = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsOfficials = New Brgy_36_MIS.dsOfficials()
        Me.dtOfficialsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dsOfficials, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOfficialsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpvKPForm
        '
        Me.rpvKPForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dsOfficials"
        ReportDataSource1.Value = Me.dtOfficialsBindingSource
        Me.rpvKPForm.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvKPForm.LocalReport.ReportEmbeddedResource = "Brgy_36_MIS.rpKPForm.rdlc"
        Me.rpvKPForm.Location = New System.Drawing.Point(4, 3)
        Me.rpvKPForm.Name = "rpvKPForm"
        Me.rpvKPForm.Size = New System.Drawing.Size(773, 337)
        Me.rpvKPForm.TabIndex = 0
        '
        'dsOfficials
        '
        Me.dsOfficials.DataSetName = "dsOfficials"
        Me.dsOfficials.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtOfficialsBindingSource
        '
        Me.dtOfficialsBindingSource.DataMember = "dtOfficials"
        Me.dtOfficialsBindingSource.DataSource = Me.dsOfficials
        '
        'F_KPFormReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 352)
        Me.Controls.Add(Me.rpvKPForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_KPFormReport"
        Me.Text = "KP-Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dsOfficials, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOfficialsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rpvKPForm As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtOfficialsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsOfficials As Brgy_36_MIS.dsOfficials
End Class
