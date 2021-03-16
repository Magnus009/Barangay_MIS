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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAttach = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.datDocuments = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkResident = New System.Windows.Forms.CheckBox()
        Me.colFileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateSubmitted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colTempFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.datDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(106, 12)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(189, 21)
        Me.txtName.TabIndex = 1
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(54, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "NAME :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt
        '
        Me.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt.Location = New System.Drawing.Point(106, 39)
        Me.txt.MaxLength = 50
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(189, 21)
        Me.txt.TabIndex = 3
        Me.txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(10, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "INVOLVEMENT :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(106, 66)
        Me.TextBox2.MaxLength = 20
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(118, 21)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(15, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "CONTACT No :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(12, 121)
        Me.TextBox3.MaxLength = 1000
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(360, 107)
        Me.TextBox3.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(12, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "STATEMENT :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAttach
        '
        Me.btnAttach.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttach.Location = New System.Drawing.Point(12, 367)
        Me.btnAttach.Name = "btnAttach"
        Me.btnAttach.Size = New System.Drawing.Size(114, 27)
        Me.btnAttach.TabIndex = 6
        Me.btnAttach.Text = "A&TTACH FILE"
        Me.btnAttach.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Location = New System.Drawing.Point(12, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 16)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "EVIDENCE PRESENTED :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'datDocuments
        '
        Me.datDocuments.AllowUserToDeleteRows = False
        Me.datDocuments.AllowUserToResizeColumns = False
        Me.datDocuments.AllowUserToResizeRows = False
        Me.datDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
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
        Me.datDocuments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFileName, Me.colDateSubmitted, Me.colView, Me.colTempFile})
        Me.datDocuments.Location = New System.Drawing.Point(12, 259)
        Me.datDocuments.MultiSelect = False
        Me.datDocuments.Name = "datDocuments"
        Me.datDocuments.ReadOnly = True
        Me.datDocuments.RowHeadersVisible = False
        Me.datDocuments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datDocuments.Size = New System.Drawing.Size(360, 107)
        Me.datDocuments.TabIndex = 27
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(258, 400)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 35)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'chkResident
        '
        Me.chkResident.AutoSize = True
        Me.chkResident.Location = New System.Drawing.Point(301, 12)
        Me.chkResident.Name = "chkResident"
        Me.chkResident.Size = New System.Drawing.Size(76, 20)
        Me.chkResident.TabIndex = 2
        Me.chkResident.Text = "RESIDENT"
        Me.chkResident.UseVisualStyleBackColor = True
        '
        'colFileName
        '
        Me.colFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFileName.HeaderText = "FILE NAME"
        Me.colFileName.Name = "colFileName"
        Me.colFileName.ReadOnly = True
        '
        'colDateSubmitted
        '
        Me.colDateSubmitted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDateSubmitted.HeaderText = "DATE SUBMITTED"
        Me.colDateSubmitted.Name = "colDateSubmitted"
        Me.colDateSubmitted.ReadOnly = True
        '
        'colView
        '
        Me.colView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colView.HeaderText = ""
        Me.colView.Name = "colView"
        Me.colView.ReadOnly = True
        Me.colView.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colView.Text = "•••"
        Me.colView.Width = 50
        '
        'colTempFile
        '
        Me.colTempFile.HeaderText = "tempLocation"
        Me.colTempFile.Name = "colTempFile"
        Me.colTempFile.ReadOnly = True
        Me.colTempFile.Visible = False
        '
        'F_PeopleInvolved
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 439)
        Me.Controls.Add(Me.chkResident)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAttach)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.datDocuments)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_PeopleInvolved"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PEOPLE INVOLVED"
        CType(Me.datDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAttach As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents datDocuments As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents chkResident As System.Windows.Forms.CheckBox
    Friend WithEvents colFileName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateSubmitted As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colView As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colTempFile As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
