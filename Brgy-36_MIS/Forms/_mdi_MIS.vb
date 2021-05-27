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

    Private Sub _mdi_MIS_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        F_Dashboard.Close()
        F_Login.Close()
    End Sub

    Private Sub AddResidentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddResidentToolStripMenuItem1.Click
        F_Resident.MdiParent = Me
        'F_Resident.intTaskMode = 1
        F_Resident.Show()
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        If MsgBox("Do you want to LOGOUT?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CLOSE") Then
            UserName = ""
            UserLevel = ""
            Me.Hide()
            F_Dashboard.Close()
            F_Login.Show()
        End If
    End Sub

    Private Sub ViewResidentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewResidentToolStripMenuItem.Click
        F_ResidentsRecord.MdiParent = Me
        F_ResidentsRecord.Show()
    End Sub

    Private Sub ViewOfficialsRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewOfficialsRecordsToolStripMenuItem.Click
        F_OfficialsRecord.MdiParent = Me
        F_OfficialsRecord.Show()
    End Sub

    Private Sub ViewComplaintsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewComplaintsToolStripMenuItem.Click
        Dim frmComplaintsRecord As New F_CasesRecords

        frmComplaintsRecord.MdiParent = Me
        frmComplaintsRecord.loadCaseRecords(0)
    End Sub

    Private Sub ViewIncidentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewIncidentsToolStripMenuItem.Click
        Dim frmIncidentsRecord As New F_CasesRecords

        frmIncidentsRecord.MdiParent = Me
        frmIncidentsRecord.loadCaseRecords(1)
    End Sub

    Private Sub ViewBlotterrsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBlotterrsToolStripMenuItem.Click
        Dim frmBlottersRecord As New F_CasesRecords

        frmBlottersRecord.MdiParent = Me
        frmBlottersRecord.loadCaseRecords(2)
    End Sub

    Private Sub FileComplaintsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileComplaintsToolStripMenuItem.Click
        Dim formComplaint As New F_CaseFile
        formComplaint.openCase(0)
    End Sub

    Private Sub ReportIncidentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportIncidentToolStripMenuItem.Click
        Dim formIncident As New F_CaseFile
        formIncident.openCase(1)
    End Sub

    Private Sub FileBlotterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileBlotterToolStripMenuItem.Click
        Dim formBlotter As New F_CaseFile
        formBlotter.openCase(2)
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        Dim formSamahan As New F_Samahan
        
        formSamahan.MdiParent = Me
        formSamahan.Show()
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        Dim formRegSamahan As New F_AddSamahan
        formRegSamahan.MdiParent = Me
        formRegSamahan.Show()
    End Sub

    Private Sub AddOfficialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddOfficialsToolStripMenuItem.Click
        F_Officials.MdiParent = Me
        F_Officials.Show()
    End Sub

    Private Sub BorrowHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim formBorrow As New F_Borrow
        formBorrow.MdiParent = Me
        formBorrow.Show()
    End Sub

    Private Sub FireIncidentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FireIncidentToolStripMenuItem.Click
        F_PrintFireReport.ShowDialog()
    End Sub

    Private Sub COVID19RelatedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COVID19RelatedToolStripMenuItem.Click
        F_PrintHealthCert.ShowDialog()
    End Sub

    Private Sub BarangayClearanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangayClearanceToolStripMenuItem.Click
        Dim frmPRintReport As New F_PrintIndigency
        frmPRintReport.intReportType = 2
        frmPRintReport.ShowDialog()
    End Sub

    Private Sub BarangayIndigencyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangayIndigencyToolStripMenuItem.Click

        Dim frmPRintReport As New F_PrintIndigency
        frmPRintReport.intReportType = 1
        frmPRintReport.ShowDialog()
    End Sub

    Private Sub RESIDENTSLISTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESIDENTSLISTToolStripMenuItem.Click
        Dim frmResidentsList As New F_PrintResidentsReport
        frmResidentsList.MdiParent = Me
        frmResidentsList.Show()
    End Sub

    Private Sub OfficersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OfficersToolStripMenuItem.Click
        Dim frmCommittee As New F_Committee
        frmCommittee.MdiParent = Me
        frmCommittee.Show()
    End Sub

    Private Sub OFFICIALSLISTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OFFICIALSLISTToolStripMenuItem.Click
        F_OfficialsListReport.Show()
    End Sub

    Private Sub CASESTATUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CASESTATUSToolStripMenuItem.Click
        F_CaseStatusReport.Show()
    End Sub

    Private Sub mnuMapping_Click(sender As Object, e As EventArgs) Handles mnuMapping.Click
        Dim frmMapping As New F_Mapping

        frmMapping.MdiParent = Me
        frmMapping.Show()
    End Sub

    Private Sub mnuInventories_Click(sender As Object, e As EventArgs) Handles mnuInventories.Click
        Dim frmItemInventory As New F_ItemInventory
        frmItemInventory.MdiParent = Me
        frmItemInventory.Show()
    End Sub

    Private Sub BorrowItemEquipmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowItemEquipmentToolStripMenuItem.Click
        Dim frmBorrow As New F_Borrow
        frmBorrow.MdiParent = Me
        frmBorrow.Show()
    End Sub

    Private Sub BorrowHistoryToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BorrowHistoryToolStripMenuItem.Click
        Dim frmBorrowHistory As New F_BorrowHistory
        frmBorrowHistory.MdiParent = Me
        frmBorrowHistory.Show()
    End Sub

    Private Sub ViewVAWCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewVAWCToolStripMenuItem.Click
        Dim frmVAWCRecord As New F_CasesRecords

        frmVAWCRecord.MdiParent = Me
        frmVAWCRecord.loadCaseRecords(3)
    End Sub

    Private Sub ReportVAWCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportVAWCToolStripMenuItem.Click
        Dim formVAWC As New F_CaseFile
        formVAWC.openCase(3)
    End Sub

    Private Sub AccountsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AccountsToolStripMenuItem1.Click
        Dim frmAccounts As New F_UserAccounts
        frmAccounts.MdiParent = Me
        frmAccounts.Show()
    End Sub

    Private Sub RegisterToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem3.Click
        Dim formRegistration As New F_UserRegistration
        formRegistration.MdiParent = Me
        formRegistration.Show()
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem1.Click
        Dim frmStreets As New F_Street
        frmStreets.MdiParent = Me
        frmStreets.Show()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim frmAddStreet As New F_AddStreet
        frmAddStreet.MdiParent = Me
        frmAddStreet.Show()
    End Sub

End Class
