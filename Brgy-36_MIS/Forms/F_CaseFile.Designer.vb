﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_CaseFile
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
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblCaseCode = New System.Windows.Forms.Label()
        Me.txtIncharge = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReportedBy = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpReportedDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpIncidentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCaseReport = New System.Windows.Forms.TextBox()
        Me.lblCaseReport = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.datPeopleInvolved = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datDocuments = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAttach = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.datPeopleInvolved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCode
        '
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Location = New System.Drawing.Point(148, 12)
        Me.txtCode.MaxLength = 10
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(118, 21)
        Me.txtCode.TabIndex = 0
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCaseCode
        '
        Me.lblCaseCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCaseCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCaseCode.Location = New System.Drawing.Point(16, 14)
        Me.lblCaseCode.Name = "lblCaseCode"
        Me.lblCaseCode.Size = New System.Drawing.Size(126, 16)
        Me.lblCaseCode.TabIndex = 8
        Me.lblCaseCode.Text = "CASE CODE :"
        Me.lblCaseCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIncharge
        '
        Me.txtIncharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIncharge.Location = New System.Drawing.Point(148, 66)
        Me.txtIncharge.MaxLength = 20
        Me.txtIncharge.Name = "txtIncharge"
        Me.txtIncharge.Size = New System.Drawing.Size(213, 21)
        Me.txtIncharge.TabIndex = 4
        Me.txtIncharge.Tag = "IN;Officer In-charge*"
        Me.txtIncharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(16, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "OFFICIAL IN-CHARGE :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReportedBy
        '
        Me.txtReportedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReportedBy.Location = New System.Drawing.Point(148, 39)
        Me.txtReportedBy.MaxLength = 20
        Me.txtReportedBy.Name = "txtReportedBy"
        Me.txtReportedBy.Size = New System.Drawing.Size(213, 21)
        Me.txtReportedBy.TabIndex = 2
        Me.txtReportedBy.Tag = "IN;Reported By*"
        Me.txtReportedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(56, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "REPORTED BY :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(454, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "STATUS :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpReportedDate
        '
        Me.dtpReportedDate.CustomFormat = "yyyy/MM/dd"
        Me.dtpReportedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReportedDate.Location = New System.Drawing.Point(509, 39)
        Me.dtpReportedDate.Name = "dtpReportedDate"
        Me.dtpReportedDate.Size = New System.Drawing.Size(118, 21)
        Me.dtpReportedDate.TabIndex = 3
        Me.dtpReportedDate.Tag = "IN;"
        '
        'dtpIncidentDate
        '
        Me.dtpIncidentDate.CustomFormat = "yyyy/MM/dd"
        Me.dtpIncidentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIncidentDate.Location = New System.Drawing.Point(509, 66)
        Me.dtpIncidentDate.Name = "dtpIncidentDate"
        Me.dtpIncidentDate.Size = New System.Drawing.Size(118, 21)
        Me.dtpIncidentDate.TabIndex = 5
        Me.dtpIncidentDate.Tag = "IN;"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Location = New System.Drawing.Point(406, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "DATE REPORTED :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Location = New System.Drawing.Point(394, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "DATE OF INCIDENT :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCaseReport
        '
        Me.txtCaseReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCaseReport.Location = New System.Drawing.Point(20, 125)
        Me.txtCaseReport.MaxLength = 1000
        Me.txtCaseReport.Multiline = True
        Me.txtCaseReport.Name = "txtCaseReport"
        Me.txtCaseReport.Size = New System.Drawing.Size(608, 98)
        Me.txtCaseReport.TabIndex = 6
        Me.txtCaseReport.Tag = "IN:Case Report*"
        Me.txtCaseReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCaseReport
        '
        Me.lblCaseReport.AutoSize = True
        Me.lblCaseReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCaseReport.Location = New System.Drawing.Point(17, 106)
        Me.lblCaseReport.Name = "lblCaseReport"
        Me.lblCaseReport.Size = New System.Drawing.Size(87, 16)
        Me.lblCaseReport.TabIndex = 20
        Me.lblCaseReport.Text = "CASE REPORT :"
        Me.lblCaseReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Location = New System.Drawing.Point(20, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "PEOPLE INVOLVED :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'datPeopleInvolved
        '
        Me.datPeopleInvolved.AllowUserToAddRows = False
        Me.datPeopleInvolved.AllowUserToDeleteRows = False
        Me.datPeopleInvolved.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datPeopleInvolved.ColumnHeadersHeight = 30
        Me.datPeopleInvolved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datPeopleInvolved.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.datPeopleInvolved.Location = New System.Drawing.Point(20, 253)
        Me.datPeopleInvolved.Name = "datPeopleInvolved"
        Me.datPeopleInvolved.ReadOnly = True
        Me.datPeopleInvolved.RowHeadersVisible = False
        Me.datPeopleInvolved.Size = New System.Drawing.Size(419, 107)
        Me.datPeopleInvolved.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "NAME"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "INVOLVEMENT"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "RESIDENT"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "CONTACT No"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "VIEW"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'datDocuments
        '
        Me.datDocuments.AllowUserToAddRows = False
        Me.datDocuments.AllowUserToDeleteRows = False
        Me.datDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datDocuments.ColumnHeadersHeight = 30
        Me.datDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datDocuments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7})
        Me.datDocuments.Location = New System.Drawing.Point(445, 253)
        Me.datDocuments.Name = "datDocuments"
        Me.datDocuments.ReadOnly = True
        Me.datDocuments.RowHeadersVisible = False
        Me.datDocuments.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.datDocuments.Size = New System.Drawing.Size(183, 107)
        Me.datDocuments.TabIndex = 9
        '
        'Column6
        '
        Me.Column6.HeaderText = "FILE NAME"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "VIEW"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Location = New System.Drawing.Point(445, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 16)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "SUPPORTING DOCUMENTS :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(377, 361)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(62, 27)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "&ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnAttach
        '
        Me.btnAttach.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttach.Location = New System.Drawing.Point(514, 361)
        Me.btnAttach.Name = "btnAttach"
        Me.btnAttach.Size = New System.Drawing.Size(114, 27)
        Me.btnAttach.TabIndex = 10
        Me.btnAttach.Text = "A&TTACH FILE"
        Me.btnAttach.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(514, 399)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 52)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "&SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"NEW", "ON-GOING", "PENDING", "CLOSED"})
        Me.cboStatus.Location = New System.Drawing.Point(509, 10)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(118, 24)
        Me.cboStatus.TabIndex = 1
        Me.cboStatus.Tag = "IN:Status*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(46, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(11, 13)
        Me.Label19.TabIndex = 40
        Me.Label19.Tag = "reqSign"
        Me.Label19.Text = "*"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(6, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Tag = "reqSign"
        Me.Label1.Text = "*"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(8, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Tag = "reqSign"
        Me.Label7.Text = "*"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(445, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Tag = "reqSign"
        Me.Label10.Text = "*"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'F_CaseFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 461)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAttach)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.datDocuments)
        Me.Controls.Add(Me.datPeopleInvolved)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCaseReport)
        Me.Controls.Add(Me.lblCaseReport)
        Me.Controls.Add(Me.dtpReportedDate)
        Me.Controls.Add(Me.dtpIncidentDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtReportedBy)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIncharge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblCaseCode)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_CaseFile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FILE CASE"
        CType(Me.datPeopleInvolved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCaseCode As System.Windows.Forms.Label
    Friend WithEvents txtIncharge As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReportedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpReportedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpIncidentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCaseReport As System.Windows.Forms.TextBox
    Friend WithEvents lblCaseReport As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents datPeopleInvolved As System.Windows.Forms.DataGridView
    Friend WithEvents datDocuments As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnAttach As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class