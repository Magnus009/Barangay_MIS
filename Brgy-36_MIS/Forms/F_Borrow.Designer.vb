<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Borrow
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
        Me.pnlBorrow = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQTY = New System.Windows.Forms.TextBox()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.datItems = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.datBorrowItems = New System.Windows.Forms.DataGridView()
        Me.lblBorrow = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpReturn = New System.Windows.Forms.DateTimePicker()
        Me.lblBorrowDate = New System.Windows.Forms.Label()
        Me.dtpBorrowDate = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.txtContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtIncharge = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkResident = New System.Windows.Forms.CheckBox()
        Me.txtBorrower = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnResidentList = New System.Windows.Forms.Button()
        Me.txtBorrowerID = New System.Windows.Forms.TextBox()
        Me.btnIncharge = New System.Windows.Forms.Button()
        Me.txtInchargeID = New System.Windows.Forms.TextBox()
        Me.pnlBorrow.SuspendLayout()
        CType(Me.datItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datBorrowItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBorrow
        '
        Me.pnlBorrow.Controls.Add(Me.txtInchargeID)
        Me.pnlBorrow.Controls.Add(Me.btnIncharge)
        Me.pnlBorrow.Controls.Add(Me.txtBorrowerID)
        Me.pnlBorrow.Controls.Add(Me.btnResidentList)
        Me.pnlBorrow.Controls.Add(Me.Label7)
        Me.pnlBorrow.Controls.Add(Me.Label19)
        Me.pnlBorrow.Controls.Add(Me.Label5)
        Me.pnlBorrow.Controls.Add(Me.txtQTY)
        Me.pnlBorrow.Controls.Add(Me.btnBorrow)
        Me.pnlBorrow.Controls.Add(Me.btnCancel)
        Me.pnlBorrow.Controls.Add(Me.txtSearch)
        Me.pnlBorrow.Controls.Add(Me.datItems)
        Me.pnlBorrow.Controls.Add(Me.Label4)
        Me.pnlBorrow.Controls.Add(Me.datBorrowItems)
        Me.pnlBorrow.Controls.Add(Me.lblBorrow)
        Me.pnlBorrow.Controls.Add(Me.btnSave)
        Me.pnlBorrow.Controls.Add(Me.Label2)
        Me.pnlBorrow.Controls.Add(Me.dtpReturn)
        Me.pnlBorrow.Controls.Add(Me.lblBorrowDate)
        Me.pnlBorrow.Controls.Add(Me.dtpBorrowDate)
        Me.pnlBorrow.Controls.Add(Me.Label14)
        Me.pnlBorrow.Controls.Add(Me.cboStatus)
        Me.pnlBorrow.Controls.Add(Me.txtContactNo)
        Me.pnlBorrow.Controls.Add(Me.Label15)
        Me.pnlBorrow.Controls.Add(Me.txtIncharge)
        Me.pnlBorrow.Controls.Add(Me.Label3)
        Me.pnlBorrow.Controls.Add(Me.chkResident)
        Me.pnlBorrow.Controls.Add(Me.txtBorrower)
        Me.pnlBorrow.Controls.Add(Me.Label1)
        Me.pnlBorrow.Location = New System.Drawing.Point(7, 6)
        Me.pnlBorrow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlBorrow.Name = "pnlBorrow"
        Me.pnlBorrow.Size = New System.Drawing.Size(738, 389)
        Me.pnlBorrow.TabIndex = 0
        Me.pnlBorrow.Tag = "Secondary"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(5, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 16)
        Me.Label7.TabIndex = 42
        Me.Label7.Tag = "reqSign"
        Me.Label7.Text = "*"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(15, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 16)
        Me.Label19.TabIndex = 40
        Me.Label19.Tag = "reqSign"
        Me.Label19.Text = "*"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(352, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Tag = "Header-6"
        Me.Label5.Text = "QTY"
        '
        'txtQTY
        '
        Me.txtQTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQTY.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQTY.Location = New System.Drawing.Point(335, 172)
        Me.txtQTY.MaxLength = 3
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(67, 23)
        Me.txtQTY.TabIndex = 15
        Me.txtQTY.Text = "1"
        Me.txtQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(335, 200)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(67, 32)
        Me.btnBorrow.TabIndex = 16
        Me.btnBorrow.Text = "►"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(335, 236)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(67, 32)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "◄"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(69, 100)
        Me.txtSearch.MaxLength = 50
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(260, 21)
        Me.txtSearch.TabIndex = 21
        '
        'datItems
        '
        Me.datItems.AllowUserToAddRows = False
        Me.datItems.AllowUserToDeleteRows = False
        Me.datItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datItems.Location = New System.Drawing.Point(10, 123)
        Me.datItems.Name = "datItems"
        Me.datItems.ReadOnly = True
        Me.datItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datItems.Size = New System.Drawing.Size(319, 223)
        Me.datItems.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Tag = "Header-6"
        Me.Label4.Text = "SEARCH :"
        '
        'datBorrowItems
        '
        Me.datBorrowItems.AllowUserToAddRows = False
        Me.datBorrowItems.AllowUserToDeleteRows = False
        Me.datBorrowItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datBorrowItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datBorrowItems.Location = New System.Drawing.Point(408, 123)
        Me.datBorrowItems.Name = "datBorrowItems"
        Me.datBorrowItems.ReadOnly = True
        Me.datBorrowItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datBorrowItems.Size = New System.Drawing.Size(319, 223)
        Me.datBorrowItems.TabIndex = 19
        '
        'lblBorrow
        '
        Me.lblBorrow.AutoSize = True
        Me.lblBorrow.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrow.Location = New System.Drawing.Point(408, 102)
        Me.lblBorrow.Name = "lblBorrow"
        Me.lblBorrow.Size = New System.Drawing.Size(112, 16)
        Me.lblBorrow.TabIndex = 22
        Me.lblBorrow.Tag = "Header-6"
        Me.lblBorrow.Text = "TO BE BORROWED :"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(632, 348)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 36)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(523, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "RETURN DATE :"
        '
        'dtpReturn
        '
        Me.dtpReturn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpReturn.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpReturn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReturn.Location = New System.Drawing.Point(610, 65)
        Me.dtpReturn.Name = "dtpReturn"
        Me.dtpReturn.Size = New System.Drawing.Size(117, 21)
        Me.dtpReturn.TabIndex = 13
        Me.dtpReturn.Tag = "IN:"
        '
        'lblBorrowDate
        '
        Me.lblBorrowDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBorrowDate.AutoSize = True
        Me.lblBorrowDate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowDate.Location = New System.Drawing.Point(513, 40)
        Me.lblBorrowDate.Name = "lblBorrowDate"
        Me.lblBorrowDate.Size = New System.Drawing.Size(94, 16)
        Me.lblBorrowDate.TabIndex = 10
        Me.lblBorrowDate.Text = "BORROW DATE :"
        '
        'dtpBorrowDate
        '
        Me.dtpBorrowDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpBorrowDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpBorrowDate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBorrowDate.Location = New System.Drawing.Point(610, 38)
        Me.dtpBorrowDate.Name = "dtpBorrowDate"
        Me.dtpBorrowDate.Size = New System.Drawing.Size(117, 21)
        Me.dtpBorrowDate.TabIndex = 11
        Me.dtpBorrowDate.Tag = "IN:"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(556, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 16)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "STATUS :"
        '
        'cboStatus
        '
        Me.cboStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboStatus.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Single", "Married", "Separated", "Widowed"})
        Me.cboStatus.Location = New System.Drawing.Point(610, 9)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(117, 24)
        Me.cboStatus.TabIndex = 9
        Me.cboStatus.Tag = ""
        '
        'txtContactNo
        '
        Me.txtContactNo.BeepOnError = True
        Me.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactNo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(137, 38)
        Me.txtContactNo.Mask = "(+63)000-000-0000"
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(127, 21)
        Me.txtContactNo.TabIndex = 4
        Me.txtContactNo.Tag = "IN:ContactNo *"
        Me.txtContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(51, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 16)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "CONTACT No. :"
        '
        'txtIncharge
        '
        Me.txtIncharge.BackColor = System.Drawing.Color.White
        Me.txtIncharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIncharge.Location = New System.Drawing.Point(137, 65)
        Me.txtIncharge.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIncharge.MaxLength = 200
        Me.txtIncharge.Name = "txtIncharge"
        Me.txtIncharge.ReadOnly = True
        Me.txtIncharge.Size = New System.Drawing.Size(212, 21)
        Me.txtIncharge.TabIndex = 7
        Me.txtIncharge.Tag = "IN:Officer Incharge*"
        Me.txtIncharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "OFFICER IN-CHARGE :"
        '
        'chkResident
        '
        Me.chkResident.AutoSize = True
        Me.chkResident.Location = New System.Drawing.Point(273, 38)
        Me.chkResident.Name = "chkResident"
        Me.chkResident.Size = New System.Drawing.Size(76, 20)
        Me.chkResident.TabIndex = 5
        Me.chkResident.Text = "RESIDENT"
        Me.chkResident.UseVisualStyleBackColor = True
        '
        'txtBorrower
        '
        Me.txtBorrower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBorrower.Location = New System.Drawing.Point(137, 11)
        Me.txtBorrower.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBorrower.MaxLength = 200
        Me.txtBorrower.Name = "txtBorrower"
        Me.txtBorrower.Size = New System.Drawing.Size(212, 21)
        Me.txtBorrower.TabIndex = 2
        Me.txtBorrower.Tag = "IN:Borrower Name*"
        Me.txtBorrower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BORROWER NAME :"
        '
        'btnResidentList
        '
        Me.btnResidentList.BackColor = System.Drawing.Color.White
        Me.btnResidentList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnResidentList.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResidentList.Location = New System.Drawing.Point(349, 10)
        Me.btnResidentList.Name = "btnResidentList"
        Me.btnResidentList.Size = New System.Drawing.Size(30, 23)
        Me.btnResidentList.TabIndex = 43
        Me.btnResidentList.Text = "..."
        Me.btnResidentList.UseVisualStyleBackColor = False
        Me.btnResidentList.Visible = False
        '
        'txtBorrowerID
        '
        Me.txtBorrowerID.Location = New System.Drawing.Point(379, 11)
        Me.txtBorrowerID.Name = "txtBorrowerID"
        Me.txtBorrowerID.Size = New System.Drawing.Size(100, 21)
        Me.txtBorrowerID.TabIndex = 44
        Me.txtBorrowerID.Visible = False
        '
        'btnIncharge
        '
        Me.btnIncharge.BackColor = System.Drawing.Color.White
        Me.btnIncharge.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnIncharge.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncharge.Location = New System.Drawing.Point(349, 64)
        Me.btnIncharge.Name = "btnIncharge"
        Me.btnIncharge.Size = New System.Drawing.Size(30, 23)
        Me.btnIncharge.TabIndex = 43
        Me.btnIncharge.Text = "..."
        Me.btnIncharge.UseVisualStyleBackColor = False
        '
        'txtInchargeID
        '
        Me.txtInchargeID.Location = New System.Drawing.Point(379, 65)
        Me.txtInchargeID.Name = "txtInchargeID"
        Me.txtInchargeID.Size = New System.Drawing.Size(100, 21)
        Me.txtInchargeID.TabIndex = 44
        Me.txtInchargeID.Visible = False
        '
        'F_Borrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 401)
        Me.Controls.Add(Me.pnlBorrow)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Borrow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Primary"
        Me.Text = "BORROW EQUIPMENT/PROPERTY"
        Me.pnlBorrow.ResumeLayout(False)
        Me.pnlBorrow.PerformLayout()
        CType(Me.datItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datBorrowItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtBorrower As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIncharge As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkResident As System.Windows.Forms.CheckBox
    Friend WithEvents txtContactNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpReturn As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBorrowDate As System.Windows.Forms.Label
    Friend WithEvents dtpBorrowDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlBorrow As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents datBorrowItems As System.Windows.Forms.DataGridView
    Friend WithEvents lblBorrow As System.Windows.Forms.Label
    Friend WithEvents datItems As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBorrow As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnResidentList As System.Windows.Forms.Button
    Friend WithEvents txtBorrowerID As System.Windows.Forms.TextBox
    Friend WithEvents txtInchargeID As System.Windows.Forms.TextBox
    Friend WithEvents btnIncharge As System.Windows.Forms.Button
End Class
