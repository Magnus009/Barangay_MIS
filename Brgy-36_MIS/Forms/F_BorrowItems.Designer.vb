<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_BorrowItems
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
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtBorrower = New System.Windows.Forms.TextBox()
        Me.lblBorrower = New System.Windows.Forms.Label()
        Me.lblIncharge = New System.Windows.Forms.Label()
        Me.txtIncharge = New System.Windows.Forms.TextBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.cboItems = New System.Windows.Forms.ComboBox()
        Me.lblQTY = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtQTY = New System.Windows.Forms.TextBox()
        Me.lblBorrowDate = New System.Windows.Forms.Label()
        Me.dtpBorrowedDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.lblReturnDate = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.chkisResident = New System.Windows.Forms.CheckBox()
        Me.pnlBorrow = New System.Windows.Forms.Panel()
        Me.pnlBorrow.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(75, 24)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(48, 17)
        Me.lblCode.TabIndex = 1
        Me.lblCode.Text = "CODE :"
        '
        'txtBorrower
        '
        Me.txtBorrower.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrower.Location = New System.Drawing.Point(126, 50)
        Me.txtBorrower.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBorrower.Name = "txtBorrower"
        Me.txtBorrower.Size = New System.Drawing.Size(380, 22)
        Me.txtBorrower.TabIndex = 4
        '
        'lblBorrower
        '
        Me.lblBorrower.AutoSize = True
        Me.lblBorrower.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrower.Location = New System.Drawing.Point(39, 53)
        Me.lblBorrower.Name = "lblBorrower"
        Me.lblBorrower.Size = New System.Drawing.Size(84, 17)
        Me.lblBorrower.TabIndex = 3
        Me.lblBorrower.Text = "BORROWER  :"
        '
        'lblIncharge
        '
        Me.lblIncharge.AutoSize = True
        Me.lblIncharge.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncharge.Location = New System.Drawing.Point(41, 88)
        Me.lblIncharge.Name = "lblIncharge"
        Me.lblIncharge.Size = New System.Drawing.Size(82, 17)
        Me.lblIncharge.TabIndex = 9
        Me.lblIncharge.Text = "IN-CHARGE  :"
        '
        'txtIncharge
        '
        Me.txtIncharge.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncharge.Location = New System.Drawing.Point(126, 82)
        Me.txtIncharge.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIncharge.Name = "txtIncharge"
        Me.txtIncharge.Size = New System.Drawing.Size(380, 22)
        Me.txtIncharge.TabIndex = 8
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.Location = New System.Drawing.Point(81, 117)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(42, 17)
        Me.lblItem.TabIndex = 10
        Me.lblItem.Text = "ITEM  :"
        '
        'cboItems
        '
        Me.cboItems.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItems.FormattingEnabled = True
        Me.cboItems.Location = New System.Drawing.Point(126, 114)
        Me.cboItems.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboItems.Name = "cboItems"
        Me.cboItems.Size = New System.Drawing.Size(228, 24)
        Me.cboItems.TabIndex = 11
        '
        'lblQTY
        '
        Me.lblQTY.AutoSize = True
        Me.lblQTY.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQTY.Location = New System.Drawing.Point(358, 117)
        Me.lblQTY.Name = "lblQTY"
        Me.lblQTY.Size = New System.Drawing.Size(39, 17)
        Me.lblQTY.TabIndex = 12
        Me.lblQTY.Text = "QTY  :"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(126, 21)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(166, 22)
        Me.txtCode.TabIndex = 2
        Me.txtCode.Text = "- - -"
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtQTY
        '
        Me.txtQTY.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQTY.Location = New System.Drawing.Point(399, 116)
        Me.txtQTY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(107, 22)
        Me.txtQTY.TabIndex = 13
        '
        'lblBorrowDate
        '
        Me.lblBorrowDate.AutoSize = True
        Me.lblBorrowDate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowDate.Location = New System.Drawing.Point(8, 150)
        Me.lblBorrowDate.Name = "lblBorrowDate"
        Me.lblBorrowDate.Size = New System.Drawing.Size(118, 17)
        Me.lblBorrowDate.TabIndex = 14
        Me.lblBorrowDate.Text = "BORROWED DATE  :"
        '
        'dtpBorrowedDate
        '
        Me.dtpBorrowedDate.CustomFormat = "yyyy/MM/dd"
        Me.dtpBorrowedDate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBorrowedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBorrowedDate.Location = New System.Drawing.Point(126, 146)
        Me.dtpBorrowedDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpBorrowedDate.Name = "dtpBorrowedDate"
        Me.dtpBorrowedDate.Size = New System.Drawing.Size(137, 22)
        Me.dtpBorrowedDate.TabIndex = 15
        '
        'dtpReturnDate
        '
        Me.dtpReturnDate.CustomFormat = "yyyy/MM/dd"
        Me.dtpReturnDate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReturnDate.Location = New System.Drawing.Point(369, 146)
        Me.dtpReturnDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpReturnDate.Name = "dtpReturnDate"
        Me.dtpReturnDate.Size = New System.Drawing.Size(137, 22)
        Me.dtpReturnDate.TabIndex = 17
        '
        'lblReturnDate
        '
        Me.lblReturnDate.AutoSize = True
        Me.lblReturnDate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnDate.Location = New System.Drawing.Point(277, 149)
        Me.lblReturnDate.Name = "lblReturnDate"
        Me.lblReturnDate.Size = New System.Drawing.Size(91, 17)
        Me.lblReturnDate.TabIndex = 16
        Me.lblReturnDate.Text = "RETURN DATE  :"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(298, 208)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(101, 50)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(405, 208)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 50)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'cboStatus
        '
        Me.cboStatus.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(126, 176)
        Me.cboStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(119, 24)
        Me.cboStatus.TabIndex = 21
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(68, 176)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(58, 17)
        Me.lblStatus.TabIndex = 20
        Me.lblStatus.Text = "STATUS  :"
        '
        'chkisResident
        '
        Me.chkisResident.AutoSize = True
        Me.chkisResident.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkisResident.Location = New System.Drawing.Point(306, 21)
        Me.chkisResident.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkisResident.Name = "chkisResident"
        Me.chkisResident.Size = New System.Drawing.Size(76, 20)
        Me.chkisResident.TabIndex = 22
        Me.chkisResident.Text = "RESIDENT"
        Me.chkisResident.UseVisualStyleBackColor = True
        '
        'pnlBorrow
        '
        Me.pnlBorrow.Controls.Add(Me.txtCode)
        Me.pnlBorrow.Controls.Add(Me.chkisResident)
        Me.pnlBorrow.Controls.Add(Me.lblCode)
        Me.pnlBorrow.Controls.Add(Me.cboStatus)
        Me.pnlBorrow.Controls.Add(Me.lblBorrower)
        Me.pnlBorrow.Controls.Add(Me.lblStatus)
        Me.pnlBorrow.Controls.Add(Me.txtBorrower)
        Me.pnlBorrow.Controls.Add(Me.btnCancel)
        Me.pnlBorrow.Controls.Add(Me.txtIncharge)
        Me.pnlBorrow.Controls.Add(Me.btnSave)
        Me.pnlBorrow.Controls.Add(Me.lblIncharge)
        Me.pnlBorrow.Controls.Add(Me.dtpReturnDate)
        Me.pnlBorrow.Controls.Add(Me.lblItem)
        Me.pnlBorrow.Controls.Add(Me.lblReturnDate)
        Me.pnlBorrow.Controls.Add(Me.cboItems)
        Me.pnlBorrow.Controls.Add(Me.dtpBorrowedDate)
        Me.pnlBorrow.Controls.Add(Me.lblQTY)
        Me.pnlBorrow.Controls.Add(Me.lblBorrowDate)
        Me.pnlBorrow.Controls.Add(Me.txtQTY)
        Me.pnlBorrow.Location = New System.Drawing.Point(4, 5)
        Me.pnlBorrow.Name = "pnlBorrow"
        Me.pnlBorrow.Size = New System.Drawing.Size(515, 265)
        Me.pnlBorrow.TabIndex = 1
        Me.pnlBorrow.Tag = "Secondary"
        '
        'F_BorrowItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 276)
        Me.Controls.Add(Me.pnlBorrow)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_BorrowItems"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Primary"
        Me.Text = "BORROW ITEMS"
        Me.pnlBorrow.ResumeLayout(False)
        Me.pnlBorrow.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtBorrower As System.Windows.Forms.TextBox
    Friend WithEvents lblBorrower As System.Windows.Forms.Label
    Friend WithEvents lblIncharge As System.Windows.Forms.Label
    Friend WithEvents txtIncharge As System.Windows.Forms.TextBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents cboItems As System.Windows.Forms.ComboBox
    Friend WithEvents lblQTY As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtQTY As System.Windows.Forms.TextBox
    Friend WithEvents lblBorrowDate As System.Windows.Forms.Label
    Friend WithEvents dtpBorrowedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpReturnDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblReturnDate As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents chkisResident As System.Windows.Forms.CheckBox
    Friend WithEvents pnlBorrow As System.Windows.Forms.Panel
End Class
