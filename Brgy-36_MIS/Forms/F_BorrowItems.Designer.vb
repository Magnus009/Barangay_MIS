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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
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
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 59)
        Me.Panel1.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(12, 18)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(137, 23)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "BORROW ITEM"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(78, 79)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(48, 17)
        Me.lblCode.TabIndex = 1
        Me.lblCode.Text = "CODE :"
        '
        'txtBorrower
        '
        Me.txtBorrower.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrower.Location = New System.Drawing.Point(129, 105)
        Me.txtBorrower.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBorrower.Name = "txtBorrower"
        Me.txtBorrower.Size = New System.Drawing.Size(380, 22)
        Me.txtBorrower.TabIndex = 4
        '
        'lblBorrower
        '
        Me.lblBorrower.AutoSize = True
        Me.lblBorrower.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrower.Location = New System.Drawing.Point(42, 108)
        Me.lblBorrower.Name = "lblBorrower"
        Me.lblBorrower.Size = New System.Drawing.Size(84, 17)
        Me.lblBorrower.TabIndex = 3
        Me.lblBorrower.Text = "BORROWER  :"
        '
        'lblIncharge
        '
        Me.lblIncharge.AutoSize = True
        Me.lblIncharge.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncharge.Location = New System.Drawing.Point(44, 143)
        Me.lblIncharge.Name = "lblIncharge"
        Me.lblIncharge.Size = New System.Drawing.Size(82, 17)
        Me.lblIncharge.TabIndex = 9
        Me.lblIncharge.Text = "IN-CHARGE  :"
        '
        'txtIncharge
        '
        Me.txtIncharge.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncharge.Location = New System.Drawing.Point(129, 137)
        Me.txtIncharge.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIncharge.Name = "txtIncharge"
        Me.txtIncharge.Size = New System.Drawing.Size(380, 22)
        Me.txtIncharge.TabIndex = 8
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.Location = New System.Drawing.Point(84, 172)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(42, 17)
        Me.lblItem.TabIndex = 10
        Me.lblItem.Text = "ITEM  :"
        '
        'cboItems
        '
        Me.cboItems.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItems.FormattingEnabled = True
        Me.cboItems.Location = New System.Drawing.Point(129, 169)
        Me.cboItems.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboItems.Name = "cboItems"
        Me.cboItems.Size = New System.Drawing.Size(228, 24)
        Me.cboItems.TabIndex = 11
        '
        'lblQTY
        '
        Me.lblQTY.AutoSize = True
        Me.lblQTY.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQTY.Location = New System.Drawing.Point(361, 172)
        Me.lblQTY.Name = "lblQTY"
        Me.lblQTY.Size = New System.Drawing.Size(39, 17)
        Me.lblQTY.TabIndex = 12
        Me.lblQTY.Text = "QTY  :"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(129, 76)
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
        Me.txtQTY.Location = New System.Drawing.Point(402, 171)
        Me.txtQTY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(107, 22)
        Me.txtQTY.TabIndex = 13
        '
        'lblBorrowDate
        '
        Me.lblBorrowDate.AutoSize = True
        Me.lblBorrowDate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowDate.Location = New System.Drawing.Point(11, 205)
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
        Me.dtpBorrowedDate.Location = New System.Drawing.Point(129, 201)
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
        Me.dtpReturnDate.Location = New System.Drawing.Point(372, 201)
        Me.dtpReturnDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpReturnDate.Name = "dtpReturnDate"
        Me.dtpReturnDate.Size = New System.Drawing.Size(137, 22)
        Me.dtpReturnDate.TabIndex = 17
        '
        'lblReturnDate
        '
        Me.lblReturnDate.AutoSize = True
        Me.lblReturnDate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnDate.Location = New System.Drawing.Point(280, 204)
        Me.lblReturnDate.Name = "lblReturnDate"
        Me.lblReturnDate.Size = New System.Drawing.Size(91, 17)
        Me.lblReturnDate.TabIndex = 16
        Me.lblReturnDate.Text = "RETURN DATE  :"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Teal
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(301, 252)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(101, 50)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(408, 252)
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
        Me.cboStatus.Location = New System.Drawing.Point(129, 231)
        Me.cboStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(119, 24)
        Me.cboStatus.TabIndex = 21
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(71, 231)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(58, 17)
        Me.lblStatus.TabIndex = 20
        Me.lblStatus.Text = "STATUS  :"
        '
        'chkisResident
        '
        Me.chkisResident.AutoSize = True
        Me.chkisResident.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkisResident.Location = New System.Drawing.Point(309, 76)
        Me.chkisResident.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkisResident.Name = "chkisResident"
        Me.chkisResident.Size = New System.Drawing.Size(76, 20)
        Me.chkisResident.TabIndex = 22
        Me.chkisResident.Text = "RESIDENT"
        Me.chkisResident.UseVisualStyleBackColor = True
        '
        'F_BorrowItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(525, 314)
        Me.Controls.Add(Me.chkisResident)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpReturnDate)
        Me.Controls.Add(Me.lblReturnDate)
        Me.Controls.Add(Me.dtpBorrowedDate)
        Me.Controls.Add(Me.lblBorrowDate)
        Me.Controls.Add(Me.txtQTY)
        Me.Controls.Add(Me.lblQTY)
        Me.Controls.Add(Me.cboItems)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.lblIncharge)
        Me.Controls.Add(Me.txtIncharge)
        Me.Controls.Add(Me.txtBorrower)
        Me.Controls.Add(Me.lblBorrower)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_BorrowItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_BorrowItems"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblHeader As System.Windows.Forms.Label
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
End Class
