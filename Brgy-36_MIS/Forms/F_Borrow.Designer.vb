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
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
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
        Me.tctIncharge = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkResident = New System.Windows.Forms.CheckBox()
        Me.txtBorrower = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlBorrow.SuspendLayout()
        CType(Me.datItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datBorrowItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBorrow
        '
        Me.pnlBorrow.Controls.Add(Me.btnBorrow)
        Me.pnlBorrow.Controls.Add(Me.btnCancel)
        Me.pnlBorrow.Controls.Add(Me.TextBox1)
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
        Me.pnlBorrow.Controls.Add(Me.tctIncharge)
        Me.pnlBorrow.Controls.Add(Me.Label3)
        Me.pnlBorrow.Controls.Add(Me.chkResident)
        Me.pnlBorrow.Controls.Add(Me.txtBorrower)
        Me.pnlBorrow.Controls.Add(Me.Label1)
        Me.pnlBorrow.Location = New System.Drawing.Point(7, 6)
        Me.pnlBorrow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlBorrow.Name = "pnlBorrow"
        Me.pnlBorrow.Size = New System.Drawing.Size(738, 419)
        Me.pnlBorrow.TabIndex = 0
        Me.pnlBorrow.Tag = "Secondary"
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(335, 200)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(67, 32)
        Me.btnBorrow.TabIndex = 71
        Me.btnBorrow.Text = "►"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(335, 236)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(67, 32)
        Me.btnCancel.TabIndex = 70
        Me.btnCancel.Text = "◄"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(69, 100)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 21)
        Me.TextBox1.TabIndex = 69
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
        Me.datItems.TabIndex = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 67
        Me.Label4.Tag = "Header-6"
        Me.Label4.Text = "SEARCH :"
        '
        'datBorrowItems
        '
        Me.datBorrowItems.AllowUserToAddRows = False
        Me.datBorrowItems.AllowUserToDeleteRows = False
        Me.datBorrowItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datBorrowItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datBorrowItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datBorrowItems.Location = New System.Drawing.Point(408, 123)
        Me.datBorrowItems.Name = "datBorrowItems"
        Me.datBorrowItems.ReadOnly = True
        Me.datBorrowItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datBorrowItems.Size = New System.Drawing.Size(319, 223)
        Me.datBorrowItems.TabIndex = 14
        '
        'lblBorrow
        '
        Me.lblBorrow.AutoSize = True
        Me.lblBorrow.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrow.Location = New System.Drawing.Point(408, 102)
        Me.lblBorrow.Name = "lblBorrow"
        Me.lblBorrow.Size = New System.Drawing.Size(112, 16)
        Me.lblBorrow.TabIndex = 66
        Me.lblBorrow.Tag = "Header-6"
        Me.lblBorrow.Text = "TO BE BORROWED :"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(632, 352)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 47)
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
        Me.txtContactNo.Size = New System.Drawing.Size(121, 21)
        Me.txtContactNo.TabIndex = 5
        Me.txtContactNo.Tag = "IN:"
        Me.txtContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(46, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 16)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "CONTACT No. :"
        '
        'tctIncharge
        '
        Me.tctIncharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tctIncharge.Location = New System.Drawing.Point(137, 65)
        Me.tctIncharge.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tctIncharge.MaxLength = 200
        Me.tctIncharge.Name = "tctIncharge"
        Me.tctIncharge.Size = New System.Drawing.Size(212, 21)
        Me.tctIncharge.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 67)
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
        Me.chkResident.TabIndex = 3
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
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BORROWER NAME :"
        '
        'F_Borrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 430)
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
    Friend WithEvents tctIncharge As System.Windows.Forms.TextBox
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
