<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_CaseStatusReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_CaseStatusReport))
        Me.dtCaseStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsCaseStatus = New Brgy_36_MIS.dsCaseStatus()
        Me.rpvCaseStatus = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.dtCaseStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCaseStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtCaseStatusBindingSource
        '
        Me.dtCaseStatusBindingSource.DataMember = "dtCaseStatus"
        Me.dtCaseStatusBindingSource.DataSource = Me.dsCaseStatus
        '
        'dsCaseStatus
        '
        Me.dsCaseStatus.DataSetName = "dsCaseStatus"
        Me.dsCaseStatus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpvCaseStatus
        '
        Me.rpvCaseStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dsCaseStatus"
        ReportDataSource1.Value = Me.dtCaseStatusBindingSource
        Me.rpvCaseStatus.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvCaseStatus.LocalReport.ReportEmbeddedResource = "Brgy_36_MIS.rpCaseStatus.rdlc"
        Me.rpvCaseStatus.Location = New System.Drawing.Point(4, 4)
        Me.rpvCaseStatus.Name = "rpvCaseStatus"
        Me.rpvCaseStatus.Size = New System.Drawing.Size(861, 250)
        Me.rpvCaseStatus.TabIndex = 0
        '
        'F_CaseStatusReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 261)
        Me.Controls.Add(Me.rpvCaseStatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_CaseStatusReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Case Status "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtCaseStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCaseStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rpvCaseStatus As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtCaseStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsCaseStatus As Brgy_36_MIS.dsCaseStatus
End Class
