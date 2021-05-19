<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_InventoryReport
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
        Me.rpvInventoryReport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsInventory = New Brgy_36_MIS.dsInventory()
        Me.dtInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dsInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpvInventoryReport
        '
        Me.rpvInventoryReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dsInventory"
        ReportDataSource1.Value = Me.dtInventoryBindingSource
        Me.rpvInventoryReport.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvInventoryReport.LocalReport.ReportEmbeddedResource = "Brgy_36_MIS.rpInventory.rdlc"
        Me.rpvInventoryReport.Location = New System.Drawing.Point(5, 3)
        Me.rpvInventoryReport.Name = "rpvInventoryReport"
        Me.rpvInventoryReport.Size = New System.Drawing.Size(492, 254)
        Me.rpvInventoryReport.TabIndex = 0
        '
        'dsInventory
        '
        Me.dsInventory.DataSetName = "dsInventory"
        Me.dsInventory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtInventoryBindingSource
        '
        Me.dtInventoryBindingSource.DataMember = "dtInventory"
        Me.dtInventoryBindingSource.DataSource = Me.dsInventory
        '
        'F_InventoryReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 261)
        Me.Controls.Add(Me.rpvInventoryReport)
        Me.Name = "F_InventoryReport"
        Me.Text = "Inventory Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dsInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rpvInventoryReport As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtInventoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsInventory As Brgy_36_MIS.dsInventory
End Class
