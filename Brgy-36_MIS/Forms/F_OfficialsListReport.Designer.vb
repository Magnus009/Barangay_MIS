<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_OfficialsListReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_OfficialsListReport))
        Me.rpvOfficialsList = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsResidentInfo = New Brgy_36_MIS.dsResidentInfo()
        Me.dtResidentInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsOfficialsInfo = New Brgy_36_MIS.dsOfficialsInfo()
        Me.dtOfficialsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dsResidentInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtResidentInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsOfficialsInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOfficialsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpvOfficialsList
        '
        Me.rpvOfficialsList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dsOfficials"
        ReportDataSource1.Value = Me.dtOfficialsBindingSource
        Me.rpvOfficialsList.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvOfficialsList.LocalReport.ReportEmbeddedResource = "Brgy_36_MIS.rpOfficialsList.rdlc"
        Me.rpvOfficialsList.Location = New System.Drawing.Point(7, 6)
        Me.rpvOfficialsList.Name = "rpvOfficialsList"
        Me.rpvOfficialsList.Size = New System.Drawing.Size(818, 373)
        Me.rpvOfficialsList.TabIndex = 0
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
        'dsOfficialsInfo
        '
        Me.dsOfficialsInfo.DataSetName = "dsOfficialsInfo"
        Me.dsOfficialsInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtOfficialsBindingSource
        '
        Me.dtOfficialsBindingSource.DataMember = "dtOfficials"
        Me.dtOfficialsBindingSource.DataSource = Me.dsOfficialsInfo
        '
        'F_OfficialsListReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 384)
        Me.Controls.Add(Me.rpvOfficialsList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_OfficialsListReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Officials"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dsResidentInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtResidentInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsOfficialsInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOfficialsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rpvOfficialsList As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtResidentInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsResidentInfo As Brgy_36_MIS.dsResidentInfo
    Friend WithEvents dtOfficialsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsOfficialsInfo As Brgy_36_MIS.dsOfficialsInfo
End Class
