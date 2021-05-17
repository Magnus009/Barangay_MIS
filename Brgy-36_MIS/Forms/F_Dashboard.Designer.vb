<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Dashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.pnlDashBoard = New System.Windows.Forms.Panel()
        Me.tabGraph = New System.Windows.Forms.TabControl()
        Me.tabResidents = New System.Windows.Forms.TabPage()
        Me.chrtResident = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tabBlotters = New System.Windows.Forms.TabPage()
        Me.chrtBlotters = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tabInventory = New System.Windows.Forms.TabPage()
        Me.chrtInventory = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.datOfficials = New System.Windows.Forms.DataGridView()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShowHide = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.pnlDashBoard.SuspendLayout()
        Me.tabGraph.SuspendLayout()
        Me.tabResidents.SuspendLayout()
        CType(Me.chrtResident, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBlotters.SuspendLayout()
        CType(Me.chrtBlotters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabInventory.SuspendLayout()
        CType(Me.chrtInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datOfficials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDashBoard
        '
        Me.pnlDashBoard.BackColor = System.Drawing.Color.White
        Me.pnlDashBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDashBoard.Controls.Add(Me.tabGraph)
        Me.pnlDashBoard.Controls.Add(Me.datOfficials)
        Me.pnlDashBoard.Controls.Add(Me.pnlHeader)
        Me.pnlDashBoard.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlDashBoard.Location = New System.Drawing.Point(0, 0)
        Me.pnlDashBoard.Name = "pnlDashBoard"
        Me.pnlDashBoard.Size = New System.Drawing.Size(327, 700)
        Me.pnlDashBoard.TabIndex = 0
        '
        'tabGraph
        '
        Me.tabGraph.Controls.Add(Me.tabResidents)
        Me.tabGraph.Controls.Add(Me.tabBlotters)
        Me.tabGraph.Controls.Add(Me.tabInventory)
        Me.tabGraph.HotTrack = True
        Me.tabGraph.Location = New System.Drawing.Point(6, 371)
        Me.tabGraph.Name = "tabGraph"
        Me.tabGraph.SelectedIndex = 0
        Me.tabGraph.Size = New System.Drawing.Size(313, 305)
        Me.tabGraph.TabIndex = 2
        '
        'tabResidents
        '
        Me.tabResidents.Controls.Add(Me.chrtResident)
        Me.tabResidents.Location = New System.Drawing.Point(4, 25)
        Me.tabResidents.Name = "tabResidents"
        Me.tabResidents.Padding = New System.Windows.Forms.Padding(3)
        Me.tabResidents.Size = New System.Drawing.Size(305, 276)
        Me.tabResidents.TabIndex = 0
        Me.tabResidents.Text = "RESIDENTS"
        Me.tabResidents.UseVisualStyleBackColor = True
        '
        'chrtResident
        '
        ChartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal
        ChartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.Name = "ChartArea1"
        Me.chrtResident.ChartAreas.Add(ChartArea1)
        Me.chrtResident.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.chrtResident.Legends.Add(Legend1)
        Me.chrtResident.Location = New System.Drawing.Point(3, 3)
        Me.chrtResident.Name = "chrtResident"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chrtResident.Series.Add(Series1)
        Me.chrtResident.Size = New System.Drawing.Size(299, 270)
        Me.chrtResident.TabIndex = 0
        '
        'tabBlotters
        '
        Me.tabBlotters.Controls.Add(Me.chrtBlotters)
        Me.tabBlotters.Location = New System.Drawing.Point(4, 25)
        Me.tabBlotters.Name = "tabBlotters"
        Me.tabBlotters.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBlotters.Size = New System.Drawing.Size(305, 276)
        Me.tabBlotters.TabIndex = 1
        Me.tabBlotters.Text = "BLOTTERS"
        Me.tabBlotters.UseVisualStyleBackColor = True
        '
        'chrtBlotters
        '
        ChartArea2.Name = "ChartArea1"
        Me.chrtBlotters.ChartAreas.Add(ChartArea2)
        Me.chrtBlotters.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.chrtBlotters.Legends.Add(Legend2)
        Me.chrtBlotters.Location = New System.Drawing.Point(3, 3)
        Me.chrtBlotters.Name = "chrtBlotters"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chrtBlotters.Series.Add(Series2)
        Me.chrtBlotters.Size = New System.Drawing.Size(299, 270)
        Me.chrtBlotters.TabIndex = 1
        '
        'tabInventory
        '
        Me.tabInventory.Controls.Add(Me.chrtInventory)
        Me.tabInventory.Location = New System.Drawing.Point(4, 25)
        Me.tabInventory.Name = "tabInventory"
        Me.tabInventory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInventory.Size = New System.Drawing.Size(305, 276)
        Me.tabInventory.TabIndex = 2
        Me.tabInventory.Text = "INVENTORY"
        Me.tabInventory.UseVisualStyleBackColor = True
        '
        'chrtInventory
        '
        ChartArea3.Name = "ChartArea1"
        Me.chrtInventory.ChartAreas.Add(ChartArea3)
        Me.chrtInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.Name = "Legend1"
        Me.chrtInventory.Legends.Add(Legend3)
        Me.chrtInventory.Location = New System.Drawing.Point(3, 3)
        Me.chrtInventory.Name = "chrtInventory"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.chrtInventory.Series.Add(Series3)
        Me.chrtInventory.Size = New System.Drawing.Size(299, 270)
        Me.chrtInventory.TabIndex = 1
        '
        'datOfficials
        '
        Me.datOfficials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datOfficials.Location = New System.Drawing.Point(6, 92)
        Me.datOfficials.Name = "datOfficials"
        Me.datOfficials.Size = New System.Drawing.Size(313, 254)
        Me.datOfficials.TabIndex = 1
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(325, 43)
        Me.pnlHeader.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(72, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DASHBOARD"
        '
        'btnShowHide
        '
        Me.btnShowHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowHide.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowHide.ForeColor = System.Drawing.Color.White
        Me.btnShowHide.Location = New System.Drawing.Point(325, 7)
        Me.btnShowHide.Name = "btnShowHide"
        Me.btnShowHide.Size = New System.Drawing.Size(25, 50)
        Me.btnShowHide.TabIndex = 0
        Me.btnShowHide.Text = "►"
        Me.btnShowHide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowHide.UseVisualStyleBackColor = False
        '
        'F_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(350, 700)
        Me.Controls.Add(Me.pnlDashBoard)
        Me.Controls.Add(Me.btnShowHide)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Dashboard"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "F_Dashboard"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.LimeGreen
        Me.pnlDashBoard.ResumeLayout(False)
        Me.tabGraph.ResumeLayout(False)
        Me.tabResidents.ResumeLayout(False)
        CType(Me.chrtResident, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBlotters.ResumeLayout(False)
        CType(Me.chrtBlotters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabInventory.ResumeLayout(False)
        CType(Me.chrtInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datOfficials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlDashBoard As System.Windows.Forms.Panel
    Friend WithEvents btnShowHide As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabGraph As System.Windows.Forms.TabControl
    Friend WithEvents tabResidents As System.Windows.Forms.TabPage
    Friend WithEvents chrtResident As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents tabBlotters As System.Windows.Forms.TabPage
    Friend WithEvents chrtBlotters As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents tabInventory As System.Windows.Forms.TabPage
    Friend WithEvents chrtInventory As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents datOfficials As System.Windows.Forms.DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
