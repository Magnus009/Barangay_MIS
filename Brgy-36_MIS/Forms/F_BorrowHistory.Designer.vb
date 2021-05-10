<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_BorrowHistory
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
        Me.pnlInventory = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dtpReturned = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpBorrowed = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datItems = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkResident = New System.Windows.Forms.CheckBox()
        Me.datBorrowItems = New System.Windows.Forms.DataGridView()
        Me.dtpReturn = New System.Windows.Forms.DateTimePicker()
        Me.dtpBorrowDate = New System.Windows.Forms.DateTimePicker()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBorrowDate = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtIncharge = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBorrower = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBorrowCode = New System.Windows.Forms.TextBox()
        Me.pnlInventory.SuspendLayout()
        CType(Me.datItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datBorrowItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlInventory
        '
        Me.pnlInventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlInventory.Controls.Add(Me.txtBorrowCode)
        Me.pnlInventory.Controls.Add(Me.txtSearch)
        Me.pnlInventory.Controls.Add(Me.dtpReturned)
        Me.pnlInventory.Controls.Add(Me.Label7)
        Me.pnlInventory.Controls.Add(Me.dtpBorrowed)
        Me.pnlInventory.Controls.Add(Me.Label6)
        Me.pnlInventory.Controls.Add(Me.btnReturn)
        Me.pnlInventory.Controls.Add(Me.btnSearch)
        Me.pnlInventory.Controls.Add(Me.Label1)
        Me.pnlInventory.Controls.Add(Me.datItems)
        Me.pnlInventory.Controls.Add(Me.Label5)
        Me.pnlInventory.Controls.Add(Me.chkResident)
        Me.pnlInventory.Controls.Add(Me.datBorrowItems)
        Me.pnlInventory.Controls.Add(Me.dtpReturn)
        Me.pnlInventory.Controls.Add(Me.dtpBorrowDate)
        Me.pnlInventory.Controls.Add(Me.cboStatus)
        Me.pnlInventory.Controls.Add(Me.Label4)
        Me.pnlInventory.Controls.Add(Me.lblBorrowDate)
        Me.pnlInventory.Controls.Add(Me.Label14)
        Me.pnlInventory.Controls.Add(Me.txtContactNo)
        Me.pnlInventory.Controls.Add(Me.Label15)
        Me.pnlInventory.Controls.Add(Me.txtIncharge)
        Me.pnlInventory.Controls.Add(Me.Label3)
        Me.pnlInventory.Controls.Add(Me.txtBorrower)
        Me.pnlInventory.Controls.Add(Me.Label2)
        Me.pnlInventory.Controls.Add(Me.lblItems)
        Me.pnlInventory.Controls.Add(Me.Label10)
        Me.pnlInventory.Location = New System.Drawing.Point(6, 5)
        Me.pnlInventory.Name = "pnlInventory"
        Me.pnlInventory.Size = New System.Drawing.Size(883, 435)
        Me.pnlInventory.TabIndex = 0
        Me.pnlInventory.Tag = "Secondary"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(92, 41)
        Me.txtSearch.MaxLength = 50
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(277, 21)
        Me.txtSearch.TabIndex = 4
        '
        'dtpReturned
        '
        Me.dtpReturned.Checked = False
        Me.dtpReturned.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpReturned.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReturned.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReturned.Location = New System.Drawing.Point(274, 16)
        Me.dtpReturned.Name = "dtpReturned"
        Me.dtpReturned.ShowCheckBox = True
        Me.dtpReturned.Size = New System.Drawing.Size(95, 21)
        Me.dtpReturned.TabIndex = 3
        Me.dtpReturned.Tag = "IN:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(208, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "RETURNED :"
        '
        'dtpBorrowed
        '
        Me.dtpBorrowed.Checked = False
        Me.dtpBorrowed.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpBorrowed.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBorrowed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBorrowed.Location = New System.Drawing.Point(92, 16)
        Me.dtpBorrowed.Name = "dtpBorrowed"
        Me.dtpBorrowed.ShowCheckBox = True
        Me.dtpBorrowed.Size = New System.Drawing.Size(95, 21)
        Me.dtpBorrowed.TabIndex = 2
        Me.dtpBorrowed.Tag = "IN:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "BORROWED :"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(759, 370)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(109, 52)
        Me.btnReturn.TabIndex = 15
        Me.btnReturn.Text = "RETURN"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(382, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(109, 52)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SEARCH :"
        '
        'datItems
        '
        Me.datItems.AllowUserToAddRows = False
        Me.datItems.AllowUserToDeleteRows = False
        Me.datItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datItems.Location = New System.Drawing.Point(6, 70)
        Me.datItems.Name = "datItems"
        Me.datItems.ReadOnly = True
        Me.datItems.Size = New System.Drawing.Size(490, 359)
        Me.datItems.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(490, 61)
        Me.Label5.TabIndex = 87
        '
        'chkResident
        '
        Me.chkResident.AutoSize = True
        Me.chkResident.Enabled = False
        Me.chkResident.Location = New System.Drawing.Point(771, 62)
        Me.chkResident.Name = "chkResident"
        Me.chkResident.Size = New System.Drawing.Size(76, 20)
        Me.chkResident.TabIndex = 9
        Me.chkResident.Text = "RESIDENT"
        Me.chkResident.UseVisualStyleBackColor = True
        '
        'datBorrowItems
        '
        Me.datBorrowItems.AllowUserToAddRows = False
        Me.datBorrowItems.AllowUserToDeleteRows = False
        Me.datBorrowItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datBorrowItems.Location = New System.Drawing.Point(510, 117)
        Me.datBorrowItems.Name = "datBorrowItems"
        Me.datBorrowItems.ReadOnly = True
        Me.datBorrowItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datBorrowItems.Size = New System.Drawing.Size(358, 223)
        Me.datBorrowItems.TabIndex = 11
        '
        'dtpReturn
        '
        Me.dtpReturn.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpReturn.Enabled = False
        Me.dtpReturn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReturn.Location = New System.Drawing.Point(618, 401)
        Me.dtpReturn.Name = "dtpReturn"
        Me.dtpReturn.Size = New System.Drawing.Size(127, 21)
        Me.dtpReturn.TabIndex = 14
        Me.dtpReturn.Tag = "IN:"
        '
        'dtpBorrowDate
        '
        Me.dtpBorrowDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpBorrowDate.Enabled = False
        Me.dtpBorrowDate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBorrowDate.Location = New System.Drawing.Point(618, 374)
        Me.dtpBorrowDate.Name = "dtpBorrowDate"
        Me.dtpBorrowDate.Size = New System.Drawing.Size(127, 21)
        Me.dtpBorrowDate.TabIndex = 13
        Me.dtpBorrowDate.Tag = "IN:"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Enabled = False
        Me.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboStatus.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Single", "Married", "Separated", "Widowed"})
        Me.cboStatus.Location = New System.Drawing.Point(618, 345)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(127, 24)
        Me.cboStatus.TabIndex = 12
        Me.cboStatus.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(525, 403)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "RETURN DATE :"
        '
        'lblBorrowDate
        '
        Me.lblBorrowDate.AutoSize = True
        Me.lblBorrowDate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowDate.Location = New System.Drawing.Point(515, 376)
        Me.lblBorrowDate.Name = "lblBorrowDate"
        Me.lblBorrowDate.Size = New System.Drawing.Size(94, 16)
        Me.lblBorrowDate.TabIndex = 81
        Me.lblBorrowDate.Text = "BORROW DATE :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(558, 349)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 16)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "STATUS :"
        '
        'txtContactNo
        '
        Me.txtContactNo.BackColor = System.Drawing.Color.White
        Me.txtContactNo.BeepOnError = True
        Me.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactNo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(618, 62)
        Me.txtContactNo.Mask = "(+63)000-000-0000"
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.ReadOnly = True
        Me.txtContactNo.Size = New System.Drawing.Size(139, 21)
        Me.txtContactNo.TabIndex = 8
        Me.txtContactNo.Tag = "IN:ContactNo *"
        Me.txtContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(521, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 16)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "CONTACT No. :"
        '
        'txtIncharge
        '
        Me.txtIncharge.BackColor = System.Drawing.Color.White
        Me.txtIncharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIncharge.Location = New System.Drawing.Point(618, 89)
        Me.txtIncharge.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIncharge.MaxLength = 200
        Me.txtIncharge.Name = "txtIncharge"
        Me.txtIncharge.ReadOnly = True
        Me.txtIncharge.Size = New System.Drawing.Size(221, 21)
        Me.txtIncharge.TabIndex = 10
        Me.txtIncharge.Tag = "IN:Officer Incharge*"
        Me.txtIncharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(533, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "IN-CHARGE :"
        '
        'txtBorrower
        '
        Me.txtBorrower.BackColor = System.Drawing.Color.White
        Me.txtBorrower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBorrower.Location = New System.Drawing.Point(618, 35)
        Me.txtBorrower.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBorrower.MaxLength = 200
        Me.txtBorrower.Name = "txtBorrower"
        Me.txtBorrower.ReadOnly = True
        Me.txtBorrower.Size = New System.Drawing.Size(221, 21)
        Me.txtBorrower.TabIndex = 7
        Me.txtBorrower.Tag = "IN:Borrower Name*"
        Me.txtBorrower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(563, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "NAME :"
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(515, 11)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(116, 16)
        Me.lblItems.TabIndex = 70
        Me.lblItems.Tag = "Header-6"
        Me.lblItems.Text = "BORROWED DETAILS"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(502, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(375, 411)
        Me.Label10.TabIndex = 71
        '
        'txtBorrowCode
        '
        Me.txtBorrowCode.Location = New System.Drawing.Point(759, 344)
        Me.txtBorrowCode.Name = "txtBorrowCode"
        Me.txtBorrowCode.Size = New System.Drawing.Size(100, 21)
        Me.txtBorrowCode.TabIndex = 88
        Me.txtBorrowCode.Visible = False
        '
        'F_BorrowHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 446)
        Me.Controls.Add(Me.pnlInventory)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_BorrowHistory"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Primary"
        Me.Text = "BORROW HISTORY"
        Me.pnlInventory.ResumeLayout(False)
        Me.pnlInventory.PerformLayout()
        CType(Me.datItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datBorrowItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlInventory As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents datItems As System.Windows.Forms.DataGridView
    Friend WithEvents lblItems As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtContactNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtIncharge As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBorrower As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpReturn As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpBorrowDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblBorrowDate As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents datBorrowItems As System.Windows.Forms.DataGridView
    Friend WithEvents chkResident As System.Windows.Forms.CheckBox
    Friend WithEvents dtpReturned As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpBorrowed As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents txtBorrowCode As System.Windows.Forms.TextBox
End Class
