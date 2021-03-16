Imports System.IO

Module M_Functions
    Public strRequire As String
    Public blnRequired As Boolean

    Public clrDeactivated = Color.FromArgb(255, 188, 54)
    Public clrDeleted = Color.FromArgb(255, 84, 84)

    Public Function openFileDialog() As String
        Dim fileDialog As New OpenFileDialog
        Dim strFileName As String = ""

        With fileDialog
            .Title = "Select Supporting Documents"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            .Filter = "All Files(*.*)|*.*"

            If .ShowDialog = DialogResult.OK Then
                strFileName = .FileName
            End If
        End With
        Return strFileName
    End Function

    Public Function copyToTemp(strSourceFile As String) As String
        Dim strTempDocsFileName As String
        Dim strFileName() As String

        strFileName = strSourceFile.Split("\")
        strTempDocsFileName = getTempDocsPath() + strFileName(strFileName.Length - 1)
        Try
            File.Copy(strSourceFile, strTempDocsFileName, True)
        Catch ex As Exception

        End Try
        Return strTempDocsFileName
    End Function

    Public Function getTempDocsPath() As String
        Dim strTempPath As String

        strTempPath = Path.GetTempPath + "SupportingDocuments\"

        If Not Directory.Exists(strTempPath) Then
            Directory.CreateDirectory(strTempPath)
        End If

            Return strTempPath
    End Function

    Public Function getDesktopDocsPath() As String
        Dim strDesktopPath As String

        strDesktopPath = My.Computer.FileSystem.SpecialDirectories.Desktop + "SupportingDocuments\"

        If Not Directory.Exists(strDesktopPath) Then
            Directory.CreateDirectory(strDesktopPath)
        End If

        Return strDesktopPath
    End Function

    Public Sub fn_ClearField(container As Form)
        Try
            For Each ctrl As Control In container.Controls
                Select Case ctrl.GetType()
                    Case GetType(TextBox)
                        ctrl.Text = ""
                    Case GetType(GroupBox)
                        groupControls(ctrl)
                    Case GetType(Label)
                        'No Event
                    Case GetType(ComboBox)
                        Dim cbo As New ComboBox
                        cbo = ctrl
                        cbo.SelectedIndex = -1
                    Case Else
                        'No Event
                End Select
            Next
        Catch ex As Exception
            MsgBox(Err.Number & "-->" & Err.Description, MsgBoxStyle.Critical, "Invalid Action")
        End Try
    End Sub

    Private Sub groupControls(group As GroupBox)
        For Each ctrl As Control In group.Controls
            Select Case ctrl.GetType()
                Case GetType(Label)
                    'No Event
                Case GetType(TextBox)
                    ctrl.Text = ""
                Case GetType(MaskedTextBox)
                    ctrl.ResetText()
                Case GetType(ComboBox)
                    Dim cbo As New ComboBox
                    cbo = ctrl
                    cbo.SelectedIndex = -1
                Case GetType(GroupBox)
                    groupControls(ctrl)
                Case Else
                    'No Event
            End Select
        Next
    End Sub

    Public Sub subRowColor(datTable As DataGridView)
        Try
            For Each row As DataGridViewRow In datTable.Rows
                Select Case row.Cells("status").Value
                    Case 0 'Deleted
                        row.DefaultCellStyle.BackColor = clrDeleted
                    Case 1 'Deactivated
                        row.DefaultCellStyle.BackColor = clrDeactivated
                End Select
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function fn_checkNull(var As Object) As String
        Dim strReturn As String = ""

        Select Case var.GetType()
            Case GetType(String)
                If IsDBNull(var) Then
                    strReturn = ""
                Else
                    strReturn = var
                End If
            Case GetType(Integer)
                If IsDBNull(var) Then
                    strReturn = "0"
                Else
                    strReturn = var
                End If
        End Select
        Return strReturn
    End Function

    Public Sub formMode(intMode As Integer, container As Control)
        Dim blnWrite As New Boolean
        Dim blnShow As New Boolean

        Select Case intMode
            Case 0 'Read Only
                blnWrite = False
                blnShow = False
            Case 1 'Create
                blnWrite = True
                blnShow = True
            Case 2 'Modify
                blnWrite = True
                blnShow = False
        End Select

        Try
            For Each ctrl As Control In container.Controls
                Select Case ctrl.GetType()
                    Case GetType(GroupBox)
                        formMode(intMode, ctrl)
                    Case Else
                        If InStr(ctrl.Tag, "IN:") Then
                            If ctrl.GetType() = GetType(TextBox) Then
                                Dim txt As TextBox
                                txt = ctrl
                                txt.ReadOnly = Not blnWrite
                                txt.BackColor = Color.White
                            ElseIf ctrl.GetType() = GetType(MaskedTextBox) Then
                                Dim mtxt As MaskedTextBox
                                mtxt = ctrl
                                mtxt.ReadOnly = Not blnWrite
                                mtxt.BackColor = Color.White
                            Else
                                ctrl.Enabled = blnWrite
                            End If
                        ElseIf InStr(ctrl.Tag, "IN;") And intMode <> 1 Then
                            If ctrl.GetType() = GetType(TextBox) Then
                                Dim txt As TextBox
                                txt = ctrl
                                txt.ReadOnly = True
                                txt.BackColor = Color.White
                            ElseIf ctrl.GetType() = GetType(MaskedTextBox) Then
                                Dim mtxt As MaskedTextBox
                                mtxt = ctrl
                                mtxt.ReadOnly = True
                                mtxt.BackColor = Color.White
                            Else
                                ctrl.Enabled = False
                            End If
                        End If

                        If ctrl.Tag = "reqSign" Then
                            ctrl.Visible = blnShow
                        End If
                End Select
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function fn_CheckRequire(container As Control) As Boolean
        For Each ctrl As Control In container.Controls
            Select Case ctrl.GetType()
                Case GetType(GroupBox)
                    fn_CheckRequire(ctrl)
                Case GetType(Panel)
                    fn_CheckRequire(ctrl)
                Case Else
                    If Right(ctrl.Tag, 1) = "*" Then
                        If ctrl.Text = "" Then
                            strRequire &= "- " & Mid(ctrl.Tag, 4, Len(ctrl.Tag) - 4) & vbCrLf
                        End If
                    End If
            End Select
        Next
        If strRequire <> "" Then
            blnRequired = True
        End If

        Return blnRequired
    End Function

End Module
