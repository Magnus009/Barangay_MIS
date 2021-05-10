<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvolvement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colResident = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colContactNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colStatement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colResidentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datDocuments = New System.Windows.Forms.DataGridView()
        Me.colPresenterID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateSubmitted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSourceFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOpen = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAttach = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOfficialsList = New System.Windows.Forms.Button()
        Me.btnResidentList = New System.Windows.Forms.Button()
        Me.chkResident = New System.Windows.Forms.CheckBox()
        Me.txtReportedByID = New System.Windows.Forms.TextBox()
        Me.txtInchargeID = New System.Windows.Forms.TextBox()
        CType(Me.datPeopleInvolved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCode
        '
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Location = New System.Drawing.Point(161, 14)
        Me.txtCode.MaxLength = 10
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(118, 21)
        Me.txtCode.TabIndex = 1
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCaseCode
        '
        Me.lblCaseCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCaseCode.Location = New System.Drawing.Point(33, 16)
        Me.lblCaseCode.Name = "lblCaseCode"
        Me.lblCaseCode.Size = New System.Drawing.Size(126, 16)
        Me.lblCaseCode.TabIndex = 0
        Me.lblCaseCode.Text = "CASE CODE :"
        Me.lblCaseCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIncharge
        '
        Me.txtIncharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIncharge.Location = New System.Drawing.Point(161, 68)
        Me.txtIncharge.MaxLength = 20
        Me.txtIncharge.Name = "txtIncharge"
        Me.txtIncharge.ReadOnly = True
        Me.txtIncharge.Size = New System.Drawing.Size(213, 21)
        Me.txtIncharge.TabIndex = 10
        Me.txtIncharge.Tag = "IN;Officer In-charge*"
        Me.txtIncharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(33, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "OFFICIAL IN-CHARGE :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReportedBy
        '
        Me.txtReportedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReportedBy.Location = New System.Drawing.Point(161, 41)
        Me.txtReportedBy.MaxLength = 20
        Me.txtReportedBy.Name = "txtReportedBy"
        Me.txtReportedBy.Size = New System.Drawing.Size(213, 21)
        Me.txtReportedBy.TabIndex = 5
        Me.txtReportedBy.Tag = "IN;Reported By*"
        Me.txtReportedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(73, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "REPORTED BY :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(615, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "STATUS :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpReportedDate
        '
        Me.dtpReportedDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpReportedDate.CustomFormat = "yyyy/MM/dd"
        Me.dtpReportedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReportedDate.Location = New System.Drawing.Point(669, 41)
        Me.dtpReportedDate.Name = "dtpReportedDate"
        Me.dtpReportedDate.Size = New System.Drawing.Size(118, 21)
        Me.dtpReportedDate.TabIndex = 16
        Me.dtpReportedDate.Tag = "IN;"
        '
        'dtpIncidentDate
        '
        Me.dtpIncidentDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpIncidentDate.CustomFormat = "yyyy/MM/dd"
        Me.dtpIncidentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIncidentDate.Location = New System.Drawing.Point(669, 68)
        Me.dtpIncidentDate.Name = "dtpIncidentDate"
        Me.dtpIncidentDate.Size = New System.Drawing.Size(118, 21)
        Me.dtpIncidentDate.TabIndex = 18
        Me.dtpIncidentDate.Tag = "IN;"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Location = New System.Drawing.Point(567, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "DATE REPORTED :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Location = New System.Drawing.Point(555, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "DATE OF INCIDENT :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCaseReport
        '
        Me.txtCaseReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCaseReport.Location = New System.Drawing.Point(28, 123)
        Me.txtCaseReport.MaxLength = 1000
        Me.txtCaseReport.Multiline = True
        Me.txtCaseReport.Name = "txtCaseReport"
        Me.txtCaseReport.Size = New System.Drawing.Size(450, 98)
        Me.txtCaseReport.TabIndex = 21
        Me.txtCaseReport.Tag = "IN:Case Report*"
        '
        'lblCaseReport
        '
        Me.lblCaseReport.AutoSize = True
        Me.lblCaseReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCaseReport.Location = New System.Drawing.Point(25, 104)
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
        Me.Label8.Location = New System.Drawing.Point(28, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "PEOPLE INVOLVED :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'datPeopleInvolved
        '
        Me.datPeopleInvolved.AllowUserToAddRows = False
        Me.datPeopleInvolved.AllowUserToDeleteRows = False
        Me.datPeopleInvolved.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datPeopleInvolved.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datPeopleInvolved.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.datPeopleInvolved.ColumnHeadersHeight = 30
        Me.datPeopleInvolved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datPeopleInvolved.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colName, Me.colInvolvement, Me.colResident, Me.colContactNo, Me.colView, Me.colStatement, Me.colResidentID})
        Me.datPeopleInvolved.Location = New System.Drawing.Point(28, 251)
        Me.datPeopleInvolved.Name = "datPeopleInvolved"
        Me.datPeopleInvolved.ReadOnly = True
        Me.datPeopleInvolved.RowHeadersVisible = False
        Me.datPeopleInvolved.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datPeopleInvolved.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datPeopleInvolved.Size = New System.Drawing.Size(450, 107)
        Me.datPeopleInvolved.TabIndex = 23
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colName.FillWeight = 57.53476!
        Me.colName.HeaderText = "NAME"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        '
        'colInvolvement
        '
        Me.colInvolvement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colInvolvement.FillWeight = 60.35944!
        Me.colInvolvement.HeaderText = "INVOLVEMENT"
        Me.colInvolvement.Name = "colInvolvement"
        Me.colInvolvement.ReadOnly = True
        '
        'colResident
        '
        Me.colResident.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colResident.FillWeight = 49.64708!
        Me.colResident.HeaderText = "RESIDENT"
        Me.colResident.Name = "colResident"
        Me.colResident.ReadOnly = True
        Me.colResident.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colContactNo
        '
        Me.colContactNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colContactNo.FillWeight = 39.18!
        Me.colContactNo.HeaderText = "CONTACT No"
        Me.colContactNo.Name = "colContactNo"
        Me.colContactNo.ReadOnly = True
        '
        'colView
        '
        Me.colView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colView.FillWeight = 31.09488!
        Me.colView.HeaderText = "VIEW"
        Me.colView.Name = "colView"
        Me.colView.ReadOnly = True
        Me.colView.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colView.Text = "•••"
        '
        'colStatement
        '
        Me.colStatement.HeaderText = "Statement"
        Me.colStatement.Name = "colStatement"
        Me.colStatement.ReadOnly = True
        Me.colStatement.Visible = False
        '
        'colResidentID
        '
        Me.colResidentID.HeaderText = "ResidentID"
        Me.colResidentID.Name = "colResidentID"
        Me.colResidentID.ReadOnly = True
        Me.colResidentID.Visible = False
        '
        'datDocuments
        '
        Me.datDocuments.AllowUserToAddRows = False
        Me.datDocuments.AllowUserToDeleteRows = False
        Me.datDocuments.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datDocuments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datDocuments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.datDocuments.ColumnHeadersHeight = 30
        Me.datDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datDocuments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPresenterID, Me.colFileName, Me.colDateSubmitted, Me.colSourceFile, Me.colOpen, Me.colDelete})
        Me.datDocuments.Location = New System.Drawing.Point(484, 123)
        Me.datDocuments.Name = "datDocuments"
        Me.datDocuments.ReadOnly = True
        Me.datDocuments.RowHeadersVisible = False
        Me.datDocuments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datDocuments.Size = New System.Drawing.Size(303, 235)
        Me.datDocuments.TabIndex = 26
        '
        'colPresenterID
        '
        Me.colPresenterID.HeaderText = "PresenterID"
        Me.colPresenterID.Name = "colPresenterID"
        Me.colPresenterID.ReadOnly = True
        Me.colPresenterID.Visible = False
        '
        'colFileName
        '
        Me.colFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFileName.FillWeight = 201.6989!
        Me.colFileName.HeaderText = "FILE NAME"
        Me.colFileName.Name = "colFileName"
        Me.colFileName.ReadOnly = True
        Me.colFileName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colDateSubmitted
        '
        Me.colDateSubmitted.HeaderText = "Date Submited"
        Me.colDateSubmitted.Name = "colDateSubmitted"
        Me.colDateSubmitted.ReadOnly = True
        Me.colDateSubmitted.Visible = False
        '
        'colSourceFile
        '
        Me.colSourceFile.HeaderText = "Source File"
        Me.colSourceFile.Name = "colSourceFile"
        Me.colSourceFile.ReadOnly = True
        Me.colSourceFile.Visible = False
        '
        'colOpen
        '
        Me.colOpen.FillWeight = 64.54688!
        Me.colOpen.HeaderText = ""
        Me.colOpen.Name = "colOpen"
        Me.colOpen.ReadOnly = True
        Me.colOpen.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colOpen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colDelete
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.colDelete.DefaultCellStyle = DataGridViewCellStyle12
        Me.colDelete.FillWeight = 68.60507!
        Me.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colDelete.HeaderText = ""
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Location = New System.Drawing.Point(484, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "SUPPORTING DOCUMENTS :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(416, 359)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(62, 27)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "&ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnAttach
        '
        Me.btnAttach.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAttach.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttach.Location = New System.Drawing.Point(484, 359)
        Me.btnAttach.Name = "btnAttach"
        Me.btnAttach.Size = New System.Drawing.Size(114, 27)
        Me.btnAttach.TabIndex = 27
        Me.btnAttach.Text = "A&TTACH FILE"
        Me.btnAttach.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(673, 359)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 52)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "&SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cboStatus
        '
        Me.cboStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(669, 12)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(118, 24)
        Me.cboStatus.TabIndex = 14
        Me.cboStatus.Tag = "IN:Status"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(63, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(11, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Tag = "reqSign"
        Me.Label19.Text = "*"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(20, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Tag = "reqSign"
        Me.Label1.Text = "*"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(8, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Tag = "reqSign"
        Me.Label7.Text = "*"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.btnOfficialsList)
        Me.Panel1.Controls.Add(Me.btnResidentList)
        Me.Panel1.Controls.Add(Me.chkResident)
        Me.Panel1.Controls.Add(Me.txtReportedBy)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnAttach)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblCaseCode)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.datPeopleInvolved)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtCode)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.datDocuments)
        Me.Panel1.Controls.Add(Me.cboStatus)
        Me.Panel1.Controls.Add(Me.txtReportedByID)
        Me.Panel1.Controls.Add(Me.txtInchargeID)
        Me.Panel1.Controls.Add(Me.txtIncharge)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtCaseReport)
        Me.Panel1.Controls.Add(Me.lblCaseReport)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dtpIncidentDate)
        Me.Panel1.Controls.Add(Me.dtpReportedDate)
        Me.Panel1.Location = New System.Drawing.Point(5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 416)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Tag = "Secondary"
        '
        'btnOfficialsList
        '
        Me.btnOfficialsList.BackColor = System.Drawing.Color.White
        Me.btnOfficialsList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOfficialsList.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOfficialsList.Location = New System.Drawing.Point(374, 66)
        Me.btnOfficialsList.Name = "btnOfficialsList"
        Me.btnOfficialsList.Size = New System.Drawing.Size(30, 24)
        Me.btnOfficialsList.TabIndex = 11
        Me.btnOfficialsList.Text = "..."
        Me.btnOfficialsList.UseVisualStyleBackColor = False
        '
        'btnResidentList
        '
        Me.btnResidentList.BackColor = System.Drawing.Color.White
        Me.btnResidentList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnResidentList.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResidentList.Location = New System.Drawing.Point(374, 40)
        Me.btnResidentList.Name = "btnResidentList"
        Me.btnResidentList.Size = New System.Drawing.Size(30, 24)
        Me.btnResidentList.TabIndex = 6
        Me.btnResidentList.Text = "..."
        Me.btnResidentList.UseVisualStyleBackColor = False
        Me.btnResidentList.Visible = False
        '
        'chkResident
        '
        Me.chkResident.AutoSize = True
        Me.chkResident.Location = New System.Drawing.Point(298, 14)
        Me.chkResident.Name = "chkResident"
        Me.chkResident.Size = New System.Drawing.Size(76, 20)
        Me.chkResident.TabIndex = 2
        Me.chkResident.Text = "RESIDENT"
        Me.chkResident.UseVisualStyleBackColor = True
        '
        'txtReportedByID
        '
        Me.txtReportedByID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReportedByID.Location = New System.Drawing.Point(410, 41)
        Me.txtReportedByID.MaxLength = 20
        Me.txtReportedByID.Name = "txtReportedByID"
        Me.txtReportedByID.Size = New System.Drawing.Size(102, 21)
        Me.txtReportedByID.TabIndex = 7
        Me.txtReportedByID.Tag = ""
        Me.txtReportedByID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtReportedByID.Visible = False
        '
        'txtInchargeID
        '
        Me.txtInchargeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInchargeID.Location = New System.Drawing.Point(410, 68)
        Me.txtInchargeID.MaxLength = 20
        Me.txtInchargeID.Name = "txtInchargeID"
        Me.txtInchargeID.Size = New System.Drawing.Size(102, 21)
        Me.txtInchargeID.TabIndex = 12
        Me.txtInchargeID.Tag = ""
        Me.txtInchargeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtInchargeID.Visible = False
        '
        'F_CaseFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 425)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_CaseFile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Primary"
        Me.Text = "FILE CASE"
        CType(Me.datPeopleInvolved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents colPresenterID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFileName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateSubmitted As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSourceFile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOpen As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkResident As System.Windows.Forms.CheckBox
    Friend WithEvents btnOfficialsList As System.Windows.Forms.Button
    Friend WithEvents btnResidentList As System.Windows.Forms.Button
    Friend WithEvents txtInchargeID As System.Windows.Forms.TextBox
    Friend WithEvents txtReportedByID As System.Windows.Forms.TextBox
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvolvement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colResident As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colContactNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colView As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colStatement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colResidentID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
