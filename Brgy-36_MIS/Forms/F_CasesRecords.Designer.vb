<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_CasesRecords
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpReported = New System.Windows.Forms.DateTimePicker()
        Me.dtpIncident = New System.Windows.Forms.DateTimePicker()
        Me.datCases = New System.Windows.Forms.DataGridView()
        Me.pnlCase = New System.Windows.Forms.Panel()
        Me.lblOverDue = New System.Windows.Forms.Label()
        Me.lblOverDueCLR = New System.Windows.Forms.Label()
        Me.lblDueTom = New System.Windows.Forms.Label()
        Me.lblDueTomCLR = New System.Windows.Forms.Label()
        Me.pnlCaseDetails = New System.Windows.Forms.Panel()
        Me.btnOfficialsList = New System.Windows.Forms.Button()
        Me.btnResidentList = New System.Windows.Forms.Button()
        Me.btnAttach = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBlotter = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.datDocuments = New System.Windows.Forms.DataGridView()
        Me.colPresenterID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateSubmitted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSourceFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOpen = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.datPeopleInvolved = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvolvement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colResident = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colContactNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colStatement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colResidentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCaseReport = New System.Windows.Forms.TextBox()
        Me.lblCaseReport = New System.Windows.Forms.Label()
        Me.txtReportedByID = New System.Windows.Forms.TextBox()
        Me.txtReportedBy = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtInchargeID = New System.Windows.Forms.TextBox()
        Me.txtIncharge = New System.Windows.Forms.TextBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.dtpIncidentDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpReportedDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCaseCode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.datCases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCase.SuspendLayout()
        Me.pnlCaseDetails.SuspendLayout()
        CType(Me.datDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datPeopleInvolved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(362, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(91, 52)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "&SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(71, 40)
        Me.txtSearch.MaxLength = 20
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(285, 21)
        Me.txtSearch.TabIndex = 5
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(14, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "SEARCH :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(190, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "REPORTED :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(7, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "INCIDENT :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpReported
        '
        Me.dtpReported.Checked = False
        Me.dtpReported.CustomFormat = "yyyy/MM/dd"
        Me.dtpReported.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReported.Location = New System.Drawing.Point(259, 10)
        Me.dtpReported.Name = "dtpReported"
        Me.dtpReported.ShowCheckBox = True
        Me.dtpReported.Size = New System.Drawing.Size(97, 21)
        Me.dtpReported.TabIndex = 3
        '
        'dtpIncident
        '
        Me.dtpIncident.Checked = False
        Me.dtpIncident.CustomFormat = "yyyy/MM/dd"
        Me.dtpIncident.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIncident.Location = New System.Drawing.Point(71, 10)
        Me.dtpIncident.Name = "dtpIncident"
        Me.dtpIncident.ShowCheckBox = True
        Me.dtpIncident.Size = New System.Drawing.Size(104, 21)
        Me.dtpIncident.TabIndex = 1
        '
        'datCases
        '
        Me.datCases.AllowUserToAddRows = False
        Me.datCases.AllowUserToDeleteRows = False
        Me.datCases.AllowUserToResizeColumns = False
        Me.datCases.AllowUserToResizeRows = False
        Me.datCases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datCases.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datCases.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datCases.ColumnHeadersHeight = 30
        Me.datCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datCases.Location = New System.Drawing.Point(8, 65)
        Me.datCases.MultiSelect = False
        Me.datCases.Name = "datCases"
        Me.datCases.ReadOnly = True
        Me.datCases.RowHeadersVisible = False
        Me.datCases.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datCases.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datCases.Size = New System.Drawing.Size(445, 413)
        Me.datCases.TabIndex = 7
        '
        'pnlCase
        '
        Me.pnlCase.Controls.Add(Me.lblOverDue)
        Me.pnlCase.Controls.Add(Me.lblOverDueCLR)
        Me.pnlCase.Controls.Add(Me.lblDueTom)
        Me.pnlCase.Controls.Add(Me.lblDueTomCLR)
        Me.pnlCase.Controls.Add(Me.datCases)
        Me.pnlCase.Controls.Add(Me.txtSearch)
        Me.pnlCase.Controls.Add(Me.dtpIncident)
        Me.pnlCase.Controls.Add(Me.dtpReported)
        Me.pnlCase.Controls.Add(Me.Label3)
        Me.pnlCase.Controls.Add(Me.btnSearch)
        Me.pnlCase.Controls.Add(Me.Label4)
        Me.pnlCase.Controls.Add(Me.Label2)
        Me.pnlCase.Location = New System.Drawing.Point(5, 5)
        Me.pnlCase.Name = "pnlCase"
        Me.pnlCase.Size = New System.Drawing.Size(461, 514)
        Me.pnlCase.TabIndex = 1
        Me.pnlCase.Tag = "Secondary"
        '
        'lblOverDue
        '
        Me.lblOverDue.AutoSize = True
        Me.lblOverDue.Location = New System.Drawing.Point(237, 487)
        Me.lblOverDue.Name = "lblOverDue"
        Me.lblOverDue.Size = New System.Drawing.Size(60, 16)
        Me.lblOverDue.TabIndex = 8
        Me.lblOverDue.Text = "OVERDUE"
        '
        'lblOverDueCLR
        '
        Me.lblOverDueCLR.BackColor = System.Drawing.Color.Red
        Me.lblOverDueCLR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOverDueCLR.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblOverDueCLR.Location = New System.Drawing.Point(208, 484)
        Me.lblOverDueCLR.Name = "lblOverDueCLR"
        Me.lblOverDueCLR.Size = New System.Drawing.Size(23, 22)
        Me.lblOverDueCLR.TabIndex = 8
        '
        'lblDueTom
        '
        Me.lblDueTom.AutoSize = True
        Me.lblDueTom.Location = New System.Drawing.Point(43, 487)
        Me.lblDueTom.Name = "lblDueTom"
        Me.lblDueTom.Size = New System.Drawing.Size(146, 16)
        Me.lblDueTom.TabIndex = 8
        Me.lblDueTom.Text = "DUE TODAY/TOMORROW"
        '
        'lblDueTomCLR
        '
        Me.lblDueTomCLR.BackColor = System.Drawing.Color.LightBlue
        Me.lblDueTomCLR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDueTomCLR.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblDueTomCLR.Location = New System.Drawing.Point(14, 484)
        Me.lblDueTomCLR.Name = "lblDueTomCLR"
        Me.lblDueTomCLR.Size = New System.Drawing.Size(23, 22)
        Me.lblDueTomCLR.TabIndex = 8
        '
        'pnlCaseDetails
        '
        Me.pnlCaseDetails.Controls.Add(Me.btnOfficialsList)
        Me.pnlCaseDetails.Controls.Add(Me.btnResidentList)
        Me.pnlCaseDetails.Controls.Add(Me.btnAttach)
        Me.pnlCaseDetails.Controls.Add(Me.btnAdd)
        Me.pnlCaseDetails.Controls.Add(Me.btnBlotter)
        Me.pnlCaseDetails.Controls.Add(Me.btnUpdate)
        Me.pnlCaseDetails.Controls.Add(Me.Label10)
        Me.pnlCaseDetails.Controls.Add(Me.datDocuments)
        Me.pnlCaseDetails.Controls.Add(Me.datPeopleInvolved)
        Me.pnlCaseDetails.Controls.Add(Me.Label9)
        Me.pnlCaseDetails.Controls.Add(Me.txtCaseReport)
        Me.pnlCaseDetails.Controls.Add(Me.lblCaseReport)
        Me.pnlCaseDetails.Controls.Add(Me.txtReportedByID)
        Me.pnlCaseDetails.Controls.Add(Me.txtReportedBy)
        Me.pnlCaseDetails.Controls.Add(Me.txtCode)
        Me.pnlCaseDetails.Controls.Add(Me.txtInchargeID)
        Me.pnlCaseDetails.Controls.Add(Me.txtIncharge)
        Me.pnlCaseDetails.Controls.Add(Me.cboStatus)
        Me.pnlCaseDetails.Controls.Add(Me.dtpIncidentDate)
        Me.pnlCaseDetails.Controls.Add(Me.dtpReportedDate)
        Me.pnlCaseDetails.Controls.Add(Me.Label6)
        Me.pnlCaseDetails.Controls.Add(Me.Label7)
        Me.pnlCaseDetails.Controls.Add(Me.Label8)
        Me.pnlCaseDetails.Controls.Add(Me.lblCaseCode)
        Me.pnlCaseDetails.Controls.Add(Me.Label1)
        Me.pnlCaseDetails.Controls.Add(Me.Label5)
        Me.pnlCaseDetails.Location = New System.Drawing.Point(472, 5)
        Me.pnlCaseDetails.Name = "pnlCaseDetails"
        Me.pnlCaseDetails.Size = New System.Drawing.Size(505, 514)
        Me.pnlCaseDetails.TabIndex = 2
        Me.pnlCaseDetails.Tag = "Secondary"
        '
        'btnOfficialsList
        '
        Me.btnOfficialsList.BackColor = System.Drawing.Color.White
        Me.btnOfficialsList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOfficialsList.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOfficialsList.Location = New System.Drawing.Point(240, 62)
        Me.btnOfficialsList.Name = "btnOfficialsList"
        Me.btnOfficialsList.Size = New System.Drawing.Size(30, 24)
        Me.btnOfficialsList.TabIndex = 22
        Me.btnOfficialsList.Text = "..."
        Me.btnOfficialsList.UseVisualStyleBackColor = False
        Me.btnOfficialsList.Visible = False
        '
        'btnResidentList
        '
        Me.btnResidentList.BackColor = System.Drawing.Color.White
        Me.btnResidentList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnResidentList.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResidentList.Location = New System.Drawing.Point(240, 35)
        Me.btnResidentList.Name = "btnResidentList"
        Me.btnResidentList.Size = New System.Drawing.Size(30, 24)
        Me.btnResidentList.TabIndex = 21
        Me.btnResidentList.Text = "..."
        Me.btnResidentList.UseVisualStyleBackColor = False
        Me.btnResidentList.Visible = False
        '
        'btnAttach
        '
        Me.btnAttach.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttach.Location = New System.Drawing.Point(18, 479)
        Me.btnAttach.Name = "btnAttach"
        Me.btnAttach.Size = New System.Drawing.Size(114, 27)
        Me.btnAttach.TabIndex = 16
        Me.btnAttach.Text = "A&TTACH FILE"
        Me.btnAttach.UseVisualStyleBackColor = True
        Me.btnAttach.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(437, 328)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(62, 27)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "&ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        Me.btnAdd.Visible = False
        '
        'btnBlotter
        '
        Me.btnBlotter.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlotter.Location = New System.Drawing.Point(353, 396)
        Me.btnBlotter.Name = "btnBlotter"
        Me.btnBlotter.Size = New System.Drawing.Size(146, 52)
        Me.btnBlotter.TabIndex = 20
        Me.btnBlotter.Text = "BLOTTER COMPLAINT"
        Me.btnBlotter.UseVisualStyleBackColor = True
        Me.btnBlotter.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(353, 454)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(146, 52)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "&UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Location = New System.Drawing.Point(18, 335)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "SUPPORTING DOCUMENTS :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'datDocuments
        '
        Me.datDocuments.AllowUserToAddRows = False
        Me.datDocuments.AllowUserToDeleteRows = False
        Me.datDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datDocuments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datDocuments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datDocuments.ColumnHeadersHeight = 30
        Me.datDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datDocuments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPresenterID, Me.colFileName, Me.colDateSubmitted, Me.colSourceFile, Me.colOpen, Me.colDelete})
        Me.datDocuments.Location = New System.Drawing.Point(18, 354)
        Me.datDocuments.Name = "datDocuments"
        Me.datDocuments.ReadOnly = True
        Me.datDocuments.RowHeadersVisible = False
        Me.datDocuments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datDocuments.Size = New System.Drawing.Size(325, 124)
        Me.datDocuments.TabIndex = 18
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.colDelete.DefaultCellStyle = DataGridViewCellStyle3
        Me.colDelete.FillWeight = 68.60507!
        Me.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colDelete.HeaderText = ""
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Visible = False
        '
        'datPeopleInvolved
        '
        Me.datPeopleInvolved.AllowUserToAddRows = False
        Me.datPeopleInvolved.AllowUserToDeleteRows = False
        Me.datPeopleInvolved.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datPeopleInvolved.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datPeopleInvolved.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datPeopleInvolved.ColumnHeadersHeight = 30
        Me.datPeopleInvolved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datPeopleInvolved.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colName, Me.colInvolvement, Me.colResident, Me.colContactNo, Me.colView, Me.colStatement, Me.colResidentID})
        Me.datPeopleInvolved.Location = New System.Drawing.Point(18, 222)
        Me.datPeopleInvolved.Name = "datPeopleInvolved"
        Me.datPeopleInvolved.ReadOnly = True
        Me.datPeopleInvolved.RowHeadersVisible = False
        Me.datPeopleInvolved.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datPeopleInvolved.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datPeopleInvolved.Size = New System.Drawing.Size(481, 104)
        Me.datPeopleInvolved.TabIndex = 15
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
        Me.colContactNo.HeaderText = "CONTACT #"
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
        Me.colView.Visible = False
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
        Me.colResidentID.HeaderText = "RESIDENTID"
        Me.colResidentID.Name = "colResidentID"
        Me.colResidentID.ReadOnly = True
        Me.colResidentID.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Location = New System.Drawing.Point(18, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "PEOPLE INVOLVED :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCaseReport
        '
        Me.txtCaseReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCaseReport.Location = New System.Drawing.Point(18, 117)
        Me.txtCaseReport.MaxLength = 1000
        Me.txtCaseReport.Multiline = True
        Me.txtCaseReport.Name = "txtCaseReport"
        Me.txtCaseReport.ReadOnly = True
        Me.txtCaseReport.Size = New System.Drawing.Size(481, 79)
        Me.txtCaseReport.TabIndex = 13
        Me.txtCaseReport.Tag = "IN:Case Report"
        '
        'lblCaseReport
        '
        Me.lblCaseReport.AutoSize = True
        Me.lblCaseReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCaseReport.Location = New System.Drawing.Point(15, 98)
        Me.lblCaseReport.Name = "lblCaseReport"
        Me.lblCaseReport.Size = New System.Drawing.Size(87, 16)
        Me.lblCaseReport.TabIndex = 12
        Me.lblCaseReport.Text = "CASE REPORT :"
        Me.lblCaseReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReportedByID
        '
        Me.txtReportedByID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReportedByID.Location = New System.Drawing.Point(255, 37)
        Me.txtReportedByID.MaxLength = 20
        Me.txtReportedByID.Name = "txtReportedByID"
        Me.txtReportedByID.ReadOnly = True
        Me.txtReportedByID.Size = New System.Drawing.Size(14, 21)
        Me.txtReportedByID.TabIndex = 5
        Me.txtReportedByID.Tag = ""
        Me.txtReportedByID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtReportedByID.Visible = False
        '
        'txtReportedBy
        '
        Me.txtReportedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReportedBy.Location = New System.Drawing.Point(90, 37)
        Me.txtReportedBy.MaxLength = 20
        Me.txtReportedBy.Name = "txtReportedBy"
        Me.txtReportedBy.ReadOnly = True
        Me.txtReportedBy.Size = New System.Drawing.Size(150, 21)
        Me.txtReportedBy.TabIndex = 5
        Me.txtReportedBy.Tag = "IN:Reported By*"
        Me.txtReportedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCode
        '
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Location = New System.Drawing.Point(90, 10)
        Me.txtCode.MaxLength = 10
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(118, 21)
        Me.txtCode.TabIndex = 1
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInchargeID
        '
        Me.txtInchargeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInchargeID.Location = New System.Drawing.Point(255, 64)
        Me.txtInchargeID.MaxLength = 20
        Me.txtInchargeID.Name = "txtInchargeID"
        Me.txtInchargeID.ReadOnly = True
        Me.txtInchargeID.Size = New System.Drawing.Size(14, 21)
        Me.txtInchargeID.TabIndex = 9
        Me.txtInchargeID.Tag = ""
        Me.txtInchargeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtInchargeID.Visible = False
        '
        'txtIncharge
        '
        Me.txtIncharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIncharge.Location = New System.Drawing.Point(90, 64)
        Me.txtIncharge.MaxLength = 20
        Me.txtIncharge.Name = "txtIncharge"
        Me.txtIncharge.ReadOnly = True
        Me.txtIncharge.Size = New System.Drawing.Size(150, 21)
        Me.txtIncharge.TabIndex = 9
        Me.txtIncharge.Tag = "IN:Officer In-charge*"
        Me.txtIncharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Enabled = False
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(381, 10)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(118, 24)
        Me.cboStatus.TabIndex = 3
        Me.cboStatus.Tag = "IN:Status"
        '
        'dtpIncidentDate
        '
        Me.dtpIncidentDate.CustomFormat = "yyyy/MM/dd"
        Me.dtpIncidentDate.Enabled = False
        Me.dtpIncidentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIncidentDate.Location = New System.Drawing.Point(381, 66)
        Me.dtpIncidentDate.Name = "dtpIncidentDate"
        Me.dtpIncidentDate.Size = New System.Drawing.Size(118, 21)
        Me.dtpIncidentDate.TabIndex = 11
        Me.dtpIncidentDate.Tag = "IN:"
        '
        'dtpReportedDate
        '
        Me.dtpReportedDate.CustomFormat = "yyyy/MM/dd"
        Me.dtpReportedDate.Enabled = False
        Me.dtpReportedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReportedDate.Location = New System.Drawing.Point(381, 39)
        Me.dtpReportedDate.Name = "dtpReportedDate"
        Me.dtpReportedDate.Size = New System.Drawing.Size(118, 21)
        Me.dtpReportedDate.TabIndex = 7
        Me.dtpReportedDate.Tag = "IN:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Location = New System.Drawing.Point(332, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "STATUS :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Location = New System.Drawing.Point(272, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "DATE OF INCIDENT :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Location = New System.Drawing.Point(284, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "DATE REPORTED :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCaseCode
        '
        Me.lblCaseCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCaseCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCaseCode.Location = New System.Drawing.Point(8, 12)
        Me.lblCaseCode.Name = "lblCaseCode"
        Me.lblCaseCode.Size = New System.Drawing.Size(83, 15)
        Me.lblCaseCode.TabIndex = 0
        Me.lblCaseCode.Text = "CASE CODE :"
        Me.lblCaseCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(15, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "IN-CHARGE :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Location = New System.Drawing.Point(5, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "REPORTED BY :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'F_CasesRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 524)
        Me.Controls.Add(Me.pnlCaseDetails)
        Me.Controls.Add(Me.pnlCase)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_CasesRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Primary"
        Me.Text = "CASE"
        CType(Me.datCases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCase.ResumeLayout(False)
        Me.pnlCase.PerformLayout()
        Me.pnlCaseDetails.ResumeLayout(False)
        Me.pnlCaseDetails.PerformLayout()
        CType(Me.datDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datPeopleInvolved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpReported As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpIncident As System.Windows.Forms.DateTimePicker
    Friend WithEvents datCases As System.Windows.Forms.DataGridView
    Friend WithEvents pnlCase As System.Windows.Forms.Panel
    Friend WithEvents pnlCaseDetails As System.Windows.Forms.Panel
    Friend WithEvents txtReportedBy As System.Windows.Forms.TextBox
    Friend WithEvents lblCaseCode As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIncharge As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents dtpIncidentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpReportedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCaseReport As System.Windows.Forms.TextBox
    Friend WithEvents lblCaseReport As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnAttach As System.Windows.Forms.Button
    Friend WithEvents colPresenterID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFileName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateSubmitted As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSourceFile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOpen As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Public WithEvents datPeopleInvolved As System.Windows.Forms.DataGridView
    Public WithEvents datDocuments As System.Windows.Forms.DataGridView
    Friend WithEvents txtReportedByID As System.Windows.Forms.TextBox
    Friend WithEvents txtInchargeID As System.Windows.Forms.TextBox
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvolvement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colResident As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colContactNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colView As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colStatement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colResidentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnOfficialsList As System.Windows.Forms.Button
    Friend WithEvents btnResidentList As System.Windows.Forms.Button
    Friend WithEvents btnBlotter As System.Windows.Forms.Button
    Friend WithEvents lblOverDue As System.Windows.Forms.Label
    Friend WithEvents lblOverDueCLR As System.Windows.Forms.Label
    Friend WithEvents lblDueTom As System.Windows.Forms.Label
    Friend WithEvents lblDueTomCLR As System.Windows.Forms.Label
End Class
