<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_BarangayIndigendy
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsIndigency = New Brgy_36_MIS.dsIndigency()
        Me.RequestDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dsIndigency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.RequestDetailsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Brgy_36_MIS.R_Indigency.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-2, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(658, 205)
        Me.ReportViewer1.TabIndex = 0
        '
        'dsIndigency
        '
        Me.dsIndigency.DataSetName = "dsIndigency"
        Me.dsIndigency.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RequestDetailsBindingSource
        '
        Me.RequestDetailsBindingSource.DataMember = "RequestDetails"
        Me.RequestDetailsBindingSource.DataSource = Me.dsIndigency
        '
        'F_BarangayIndigendy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 205)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "F_BarangayIndigendy"
        Me.Text = "F_BarangayIndigendy"
        CType(Me.dsIndigency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RequestDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsIndigency As Brgy_36_MIS.dsIndigency
End Class
