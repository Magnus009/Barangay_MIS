<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_PeopleInvolved
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInvolvement = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStatement = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAttach = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.datDocuments = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateSubmitted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTempFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkResident = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.datDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(108, 11)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(189, 21)
        Me.txtName.TabIndex = 1
        Me.txtName.Tag = "IN;Name*"
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(56, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "NAME :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInvolvement
        '
        Me.txtInvolvement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvolvement.Location = New System.Drawing.Point(108, 38)
        Me.txtInvolvement.MaxLength = 50
        Me.txtInvolvement.Name = "txtInvolvement"
        Me.txtInvolvement.Size = New System.Drawing.Size(189, 21)
        Me.txtInvolvement.TabIndex = 3
        Me.txtInvolvement.Tag = "IN:Involvement*"
        Me.txtInvolvement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "INVOLVEMENT :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContactNo
        '
        Me.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactNo.Location = New System.Drawing.Point(108, 65)
        Me.txtContactNo.MaxLength = 20
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(118, 21)
        Me.txtContactNo.TabIndex = 4
        Me.txtContactNo.Tag = "IN:Contact No"
        Me.txtContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(17, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "CONTACT No :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStatement
        '
        Me.txtStatement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStatement.Location = New System.Drawing.Point(14, 120)
        Me.txtStatement.MaxLength = 1000
        Me.txtStatement.Multiline = True
        Me.txtStatement.Name = "txtStatement"
        Me.txtStatement.Size = New System.Drawing.Size(360, 107)
        Me.txtStatement.TabIndex = 5
        Me.txtStatement.Tag = "IN:Statement*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(14, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "STATEMENT :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAttach
        '
        Me.btnAttach.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttach.Location = New System.Drawing.Point(14, 366)
        Me.btnAttach.Name = "btnAttach"
        Me.btnAttach.Size = New System.Drawing.Size(114, 27)
        Me.btnAttach.TabIndex = 6
        Me.btnAttach.Tag = "Header-6"
        Me.btnAttach.Text = "A&TTACH FILE"
        Me.btnAttach.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Location = New System.Drawing.Point(14, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 16)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "EVIDENCE PRESENTED :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'datDocuments
        '
        Me.datDocuments.AllowUserToAddRows = False
        Me.datDocuments.AllowUserToDeleteRows = False
        Me.datDocuments.AllowUserToResizeColumns = False
        Me.datDocuments.AllowUserToResizeRows = False
        Me.datDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datDocuments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datDocuments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datDocuments.ColumnHeadersHeight = 30
        Me.datDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datDocuments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colFileName, Me.colDateSubmitted, Me.colTempFile, Me.colView, Me.colDelete})
        Me.datDocuments.Location = New System.Drawing.Point(14, 258)
        Me.datDocuments.MultiSelect = False
        Me.datDocuments.Name = "datDocuments"
        Me.datDocuments.ReadOnly = True
        Me.datDocuments.RowHeadersVisible = False
        Me.datDocuments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datDocuments.Size = New System.Drawing.Size(360, 107)
        Me.datDocuments.TabIndex = 27
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        '
        'colFileName
        '
        Me.colFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colFileName.FillWeight = 193.1973!
        Me.colFileName.HeaderText = "FILE NAME"
        Me.colFileName.Name = "colFileName"
        Me.colFileName.ReadOnly = True
        Me.colFileName.Width = 180
        '
        'colDateSubmitted
        '
        Me.colDateSubmitted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDateSubmitted.FillWeight = 6.802719!
        Me.colDateSubmitted.HeaderText = "DATE SUBMITTED"
        Me.colDateSubmitted.Name = "colDateSubmitted"
        Me.colDateSubmitted.ReadOnly = True
        '
        'colTempFile
        '
        Me.colTempFile.HeaderText = "tempLocation"
        Me.colTempFile.Name = "colTempFile"
        Me.colTempFile.ReadOnly = True
        Me.colTempFile.Visible = False
        '
        'colView
        '
        Me.colView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colView.HeaderText = ""
        Me.colView.Name = "colView"
        Me.colView.ReadOnly = True
        Me.colView.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colView.Text = "•••"
        Me.colView.Width = 30
        '
        'colDelete
        '
        Me.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.colDelete.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colDelete.HeaderText = ""
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Text = "X"
        Me.colDelete.Width = 30
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(260, 371)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 35)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'chkResident
        '
        Me.chkResident.AutoSize = True
        Me.chkResident.Location = New System.Drawing.Point(303, 11)
        Me.chkResident.Name = "chkResident"
        Me.chkResident.Size = New System.Drawing.Size(76, 20)
        Me.chkResident.TabIndex = 2
        Me.chkResident.Text = "RESIDENT"
        Me.chkResident.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(49, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(11, 13)
        Me.Label19.TabIndex = 41
        Me.Label19.Tag = "reqSign"
        Me.Label19.Text = "*"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(2, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Tag = "reqSign"
        Me.Label5.Text = "*"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(5, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Tag = "reqSign"
        Me.Label6.Text = "*"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.chkResident)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.btnAttach)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.datDocuments)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtStatement)
        Me.Panel1.Controls.Add(Me.txtInvolvement)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtContactNo)
        Me.Panel1.Location = New System.Drawing.Point(5, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 410)
        Me.Panel1.TabIndex = 44
        Me.Panel1.Tag = "Secondary"
        '
        'F_PeopleInvolved
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 422)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_PeopleInvolved"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Primary"
        Me.Text = "PEOPLE INVOLVED"
        CType(Me.datDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInvolvement As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtStatement As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAttach As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents datDocuments As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents chkResident As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFileName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateSubmitted As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTempFile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colView As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
