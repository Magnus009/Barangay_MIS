<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_PrintKPForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_PrintKPForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txtRespondents = New System.Windows.Forms.TextBox()
        Me.lblRespondents = New System.Windows.Forms.Label()
        Me.txtComplainants = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFor = New System.Windows.Forms.TextBox()
        Me.lblFor = New System.Windows.Forms.Label()
        Me.txtCaseNo = New System.Windows.Forms.TextBox()
        Me.lblCaseNo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.txtRespondents)
        Me.Panel1.Controls.Add(Me.lblRespondents)
        Me.Panel1.Controls.Add(Me.txtComplainants)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtFor)
        Me.Panel1.Controls.Add(Me.lblFor)
        Me.Panel1.Controls.Add(Me.txtCaseNo)
        Me.Panel1.Controls.Add(Me.lblCaseNo)
        Me.Panel1.Location = New System.Drawing.Point(8, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(321, 240)
        Me.Panel1.TabIndex = 9
        Me.Panel1.Tag = "Secondary"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(215, 191)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(99, 34)
        Me.btnPrint.TabIndex = 17
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'txtRespondents
        '
        Me.txtRespondents.Location = New System.Drawing.Point(116, 162)
        Me.txtRespondents.Name = "txtRespondents"
        Me.txtRespondents.Size = New System.Drawing.Size(198, 22)
        Me.txtRespondents.TabIndex = 16
        '
        'lblRespondents
        '
        Me.lblRespondents.AutoSize = True
        Me.lblRespondents.Location = New System.Drawing.Point(18, 165)
        Me.lblRespondents.Name = "lblRespondents"
        Me.lblRespondents.Size = New System.Drawing.Size(96, 17)
        Me.lblRespondents.TabIndex = 15
        Me.lblRespondents.Text = "RESPONDENTS :"
        '
        'txtComplainants
        '
        Me.txtComplainants.Location = New System.Drawing.Point(116, 134)
        Me.txtComplainants.Name = "txtComplainants"
        Me.txtComplainants.Size = New System.Drawing.Size(198, 22)
        Me.txtComplainants.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "COMPLAINANTS :"
        '
        'txtFor
        '
        Me.txtFor.Location = New System.Drawing.Point(116, 49)
        Me.txtFor.Multiline = True
        Me.txtFor.Name = "txtFor"
        Me.txtFor.Size = New System.Drawing.Size(198, 76)
        Me.txtFor.TabIndex = 12
        '
        'lblFor
        '
        Me.lblFor.AutoSize = True
        Me.lblFor.Location = New System.Drawing.Point(77, 49)
        Me.lblFor.Name = "lblFor"
        Me.lblFor.Size = New System.Drawing.Size(37, 17)
        Me.lblFor.TabIndex = 11
        Me.lblFor.Text = "FOR :"
        '
        'txtCaseNo
        '
        Me.txtCaseNo.Location = New System.Drawing.Point(116, 16)
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Size = New System.Drawing.Size(100, 22)
        Me.txtCaseNo.TabIndex = 10
        '
        'lblCaseNo
        '
        Me.lblCaseNo.AutoSize = True
        Me.lblCaseNo.Location = New System.Drawing.Point(44, 19)
        Me.lblCaseNo.Name = "lblCaseNo"
        Me.lblCaseNo.Size = New System.Drawing.Size(70, 17)
        Me.lblCaseNo.TabIndex = 9
        Me.lblCaseNo.Text = "CASE NO. :"
        '
        'F_PrintKPForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 260)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_PrintKPForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Primary"
        Me.Text = "PRINT KP-FORM"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtRespondents As System.Windows.Forms.TextBox
    Friend WithEvents lblRespondents As System.Windows.Forms.Label
    Friend WithEvents txtComplainants As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFor As System.Windows.Forms.TextBox
    Friend WithEvents lblFor As System.Windows.Forms.Label
    Friend WithEvents txtCaseNo As System.Windows.Forms.TextBox
    Friend WithEvents lblCaseNo As System.Windows.Forms.Label
End Class
