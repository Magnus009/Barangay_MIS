Imports System.Windows.Forms

Public Class _mdi_MIS

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub _mdi_MIS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(Application.StartupPath())
    End Sub

    Private Sub AddResidentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddResidentToolStripMenuItem1.Click
        F_Resident.MdiParent = Me
        F_Resident.intTaskMode = 1
        F_Resident.Show()
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        UserName = ""
        UserLevel = ""
        Me.Hide()
        F_Login.Show()
    End Sub

    Private Sub ViewResidentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewResidentToolStripMenuItem.Click
        F_ResidentsRecord.MdiParent = Me
        F_ResidentsRecord.Show()
    End Sub

    Private Sub ViewOfficialsRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewOfficialsRecordsToolStripMenuItem.Click
        F_Officials.MdiParent = Me
        F_Officials.Show()
    End Sub

    Private Sub UpdateOfficialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateOfficialsToolStripMenuItem.Click
    End Sub

    Private Sub ViewComplaintsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewComplaintsToolStripMenuItem.Click
        F_CasesRecords.MdiParent = Me
        F_CasesRecords.loadCaseRecords(0)
    End Sub

    Private Sub ViewIncidentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewIncidentsToolStripMenuItem.Click
        F_CasesRecords.MdiParent = Me
        F_CasesRecords.loadCaseRecords(1)
    End Sub

    Private Sub ViewBlotterrsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBlotterrsToolStripMenuItem.Click
        F_CasesRecords.MdiParent = Me
        F_CasesRecords.loadCaseRecords(2)
    End Sub

    Private Sub FileComplaintsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileComplaintsToolStripMenuItem.Click
        F_CaseFile.openCase(0, 1)
    End Sub

    Private Sub ReportIncidentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportIncidentToolStripMenuItem.Click
        F_CaseFile.openCase(1, 1)
    End Sub

    Private Sub FileBlotterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileBlotterToolStripMenuItem.Click
        F_CaseFile.openCase(2, 1)
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        F_Samahan.MdiParent = Me
        F_Samahan.Show()
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        Dim formRegSamahan As New F_AddSamahan
        formRegSamahan.MdiParent = Me
        formRegSamahan.Show()
    End Sub

    Private Sub RegisterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem1.Click
        Dim formRegistration As New F_UserRegistration
        formRegistration.MdiParent = Me
        formRegistration.Show()
    End Sub

    Private Sub EquipmentsPropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquipmentsPropertiesToolStripMenuItem.Click
        F_Inventory.MdiParent = Me
        F_Inventory.Show()
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem1.Click
        F_UserAccounts.MdiParent = Me
        F_UserAccounts.Show()
    End Sub
End Class
