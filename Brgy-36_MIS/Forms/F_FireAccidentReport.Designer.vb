﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_FireAccidentReport
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_FireAccidentReport))
        Me.rpvFireReport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsResidentInfo = New Brgy_36_MIS.dsResidentInfo()
        Me.dtResidentInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsOfficials = New Brgy_36_MIS.dsOfficials()
        Me.dtOfficialsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dsResidentInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtResidentInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsOfficials, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOfficialsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpvFireReport
        '
        Me.rpvFireReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dsResInfo"
        ReportDataSource1.Value = Me.dtResidentInfoBindingSource
        ReportDataSource2.Name = "dsOfficials"
        ReportDataSource2.Value = Me.dtOfficialsBindingSource
        Me.rpvFireReport.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvFireReport.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rpvFireReport.LocalReport.ReportEmbeddedResource = "Brgy_36_MIS.rpFireCertificate.rdlc"
        Me.rpvFireReport.Location = New System.Drawing.Point(2, 2)
        Me.rpvFireReport.Name = "rpvFireReport"
        Me.rpvFireReport.Size = New System.Drawing.Size(673, 300)
        Me.rpvFireReport.TabIndex = 0
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
        'F_FireAccidentReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 314)
        Me.Controls.Add(Me.rpvFireReport)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_FireAccidentReport"
        Me.Text = "Fire Victim Certificate"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dsResidentInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtResidentInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsOfficials, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOfficialsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rpvFireReport As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtResidentInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsResidentInfo As Brgy_36_MIS.dsResidentInfo
    Friend WithEvents dtOfficialsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsOfficials As Brgy_36_MIS.dsOfficials
End Class
