<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ResidentsReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_ResidentsReport))
        Me.dtResidentInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsResidentInfo = New Brgy_36_MIS.dsResidentInfo()
        Me.rpvResidentsList = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.dtResidentInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsResidentInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtResidentInfoBindingSource
        '
        Me.dtResidentInfoBindingSource.DataMember = "dtResidentInfo"
        Me.dtResidentInfoBindingSource.DataSource = Me.dsResidentInfo
        '
        'dsResidentInfo
        '
        Me.dsResidentInfo.DataSetName = "dsResidentInfo"
        Me.dsResidentInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpvResidentsList
        '
        Me.rpvResidentsList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dsResidents"
        ReportDataSource1.Value = Me.dtResidentInfoBindingSource
        Me.rpvResidentsList.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvResidentsList.LocalReport.ReportEmbeddedResource = "Brgy_36_MIS.rpResidentsList.rdlc"
        Me.rpvResidentsList.Location = New System.Drawing.Point(2, 2)
        Me.rpvResidentsList.Name = "rpvResidentsList"
        Me.rpvResidentsList.Size = New System.Drawing.Size(898, 517)
        Me.rpvResidentsList.TabIndex = 0
        '
        'F_ResidentsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 522)
        Me.Controls.Add(Me.rpvResidentsList)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "F_ResidentsReport"
        Me.Text = "Resident's List Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtResidentInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsResidentInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rpvResidentsList As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtResidentInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsResidentInfo As Brgy_36_MIS.dsResidentInfo
End Class
