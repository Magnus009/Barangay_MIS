Imports System.IO
Imports System.Diagnostics.Process

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
            .Filter = "All Files(*.jpeg, *.jpg, *.png)|*.*"

            If .ShowDialog = DialogResult.OK Then
                strFileName = .FileName
            End If
        End With
        Return strFileName
    End Function

    Public Function copyToTemp(strSourceFile As String) As String
        Dim strTempDocsFileName As String
        strTempDocsFileName = getTempDocsPath() + getFileName(strSourceFile)
        Try
            File.Copy(strSourceFile, strTempDocsFileName, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return strTempDocsFileName
    End Function

    Public Function copyToDocsDirectory(strSourceFile As String) As String
        Dim strDeskDocsFileName As String
        strDeskDocsFileName = getDesktopDocsPath() + getFileName(strSourceFile)
        Try
            File.Copy(strSourceFile, strDeskDocsFileName, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return strDeskDocsFileName
    End Function

    Public Sub openFile(strSourceFile)
        Try
            If File.Exists(strSourceFile) Then
                Start(strSourceFile)
            Else
                Throw New Exception("File does not exist!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function getFileName(strSourceFile As String) As String
        Dim strFile() As String

        strFile = strSourceFile.Split("\")
        Return strFile(strFile.Length - 1)
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

        strDesktopPath = My.Computer.FileSystem.SpecialDirectories.Desktop + "\SupportingDocuments\"

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
                    Case GetType(Panel)
                        panelControls(ctrl)
                    Case GetType(ComboBox)
                        Dim cbo As New ComboBox
                        cbo = ctrl
                        cbo.SelectedIndex = -1
                    Case GetType(CheckBox)
                        Dim chk As New CheckBox
                        chk = ctrl
                        chk.Checked = False
                    Case GetType(DataGridView)
                        Dim dgv As New DataGridView
                        dgv = ctrl
                        dgv.Rows.Clear()
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
                Case Else
                    'No Event
            End Select
        Next
    End Sub

    Private Sub panelControls(panel As Panel)
        For Each ctrl As Control In panel.Controls
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
                                txt.BackColor = IIf(blnWrite, My.Settings.Editable, Color.White)
                            ElseIf ctrl.GetType() = GetType(MaskedTextBox) Then
                                Dim mtxt As MaskedTextBox
                                mtxt = ctrl
                                mtxt.ReadOnly = Not blnWrite
                                mtxt.BackColor = IIf(blnWrite, My.Settings.Editable, Color.White)
                            Else
                                ctrl.Enabled = blnWrite
                                ctrl.BackColor = IIf(blnWrite, My.Settings.Editable, My.Settings.Secondary)
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
                Case GetType(ComboBox)
                    Dim cbo As New ComboBox
                    cbo = ctrl

                    If Right(cbo.Tag, 1) = "*" Then
                        If cbo.SelectedValue = -1 Or cbo.Text = "" Then
                            strRequire &= "- " & Mid(cbo.Tag, 4, Len(cbo.Tag) - 4) & vbCrLf
                        End If
                    End If
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

    Public Sub subCellFormat(ByVal sender As Object, e As DataGridViewCellFormattingEventArgs)
        Dim dvgObj As New DataGridView
        dvgObj = sender

        With dvgObj
            For i As Integer = 0 To .Rows.Count - 1
                Select Case .Rows(i).Cells("colStatus").Value.ToString
                    Case "deleted"
                        .Rows(i).DefaultCellStyle.BackColor = My.Settings.Deleted
                    Case "deactivated"
                        .Rows(i).DefaultCellStyle.BackColor = My.Settings.Deactivated
                End Select
            Next
        End With
    End Sub

    Public Function fn_Date(dateVal As Date) As String
        Dim strDate As String
        strDate = Format(dateVal, "yyyy/MM/dd")
        Return strDate
    End Function

    Public Sub formLoadSetup(container As Control)

        If container.Tag = "Primary" Then
            If container.GetType = GetType(Form) Then
                Dim frm As New Form
                frm = container

                frm.FormBorderStyle = FormBorderStyle.FixedSingle
                frm.MinimizeBox = False
                frm.MaximizeBox = False
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.BackColor = My.Settings.Primary
            Else
                container.BackColor = My.Settings.Primary
            End If
        End If

        For Each ctrl As Control In container.Controls
            Select Case ctrl.Tag
                Case "Header-1"
                    ctrl.Font = My.Settings.Header1
                Case "Header-2"
                    ctrl.Font = My.Settings.Header2
                Case "Header-3"
                    ctrl.Font = My.Settings.Header3
                Case "Header-4"
                    ctrl.Font = My.Settings.Header4
                Case "Header-5"
                    ctrl.Font = My.Settings.Header5
                Case "Substring"
                    ctrl.Font = My.Settings.Substring
                Case Else
                    ctrl.Font = My.Settings.Font
            End Select

            Select Case ctrl.GetType
                Case GetType(Panel)
                    If ctrl.Tag = "Secondary" Then
                        ctrl.BackColor = My.Settings.Secondary
                    End If
                    formLoadSetup(ctrl)
                Case GetType(Button)
                    Dim btn As New Button
                    btn = ctrl
                    btn.FlatStyle = FlatStyle.Flat
                    btn.ForeColor = Color.White
                    btn.Font = My.Settings.ButtonFont
                    If btn.Tag = "Close" Then
                        btn.BackColor = Color.Red
                    Else
                        btn.BackColor = My.Settings.Primary
                    End If
                Case GetType(TextBox)
                    ctrl.Font = My.Settings.Font
                    ctrl.BackColor = Color.White
                Case GetType(MaskedTextBox)
                    ctrl.Font = My.Settings.Font
                    ctrl.BackColor = Color.White
                Case GetType(ComboBox)
                    Dim cbo As New ComboBox
                    cbo = ctrl

                    cbo.FlatStyle = FlatStyle.System
                    cbo.DropDownStyle = ComboBoxStyle.DropDownList
                    cbo.Font = My.Settings.Font
                Case GetType(DateTimePicker)
                    Dim dtp As New DateTimePicker
                    dtp = ctrl

                    dtp.Font = My.Settings.Font
                    dtp.Format = DateTimePickerFormat.Custom
                    dtp.CustomFormat = "yyyy/MM/dd"
                Case GetType(CheckBox)
                    Dim chk As New CheckBox
                    chk = ctrl

                    chk.Appearance = Appearance.Normal
                    chk.CheckAlign = ContentAlignment.MiddleLeft
                    chk.FlatStyle = FlatStyle.Flat
                    chk.FlatAppearance.CheckedBackColor = Color.White
                    chk.TextAlign = ContentAlignment.MiddleLeft
                Case GetType(DataGridView)
                    Dim dgv As New DataGridView
                    dgv = ctrl

                    With dgv
                        .ReadOnly = True
                        .MultiSelect = False
                        .GridColor = Color.Black
                        .ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
                        .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
                        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                        .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
                        .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                        .ColumnHeadersHeight = 30
                        .RowHeadersVisible = False
                        .BorderStyle = BorderStyle.FixedSingle
                        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        .ScrollBars = ScrollBars.Vertical

                        With .ColumnHeadersDefaultCellStyle
                            .Alignment = DataGridViewContentAlignment.MiddleCenter
                            .BackColor = My.Settings.Primary
                            .ForeColor = Color.White
                            .Font = My.Settings.TableHeader
                        End With

                        With .DefaultCellStyle
                            .SelectionBackColor = My.Settings.Selected
                            .Alignment = DataGridViewContentAlignment.MiddleCenter
                        End With

                        With .RowTemplate
                            .Height = 40
                        End With
                    End With

                    For Each col As DataGridViewColumn In dgv.Columns
                        Select Case col.GetType
                            Case GetType(DataGridViewButtonColumn)
                                Dim colBtn As New DataGridViewButtonColumn
                                colBtn = col

                                colBtn.FlatStyle = FlatStyle.Flat
                                colBtn.DefaultCellStyle.BackColor = My.Settings.Primary
                                colBtn.DefaultCellStyle.ForeColor = Color.White
                                colBtn.DefaultCellStyle.SelectionBackColor = My.Settings.Primary
                        End Select
                    Next
            End Select
        Next
    End Sub

    Public Sub cboDataBinding(cbo As ComboBox, strSQL As String, Optional header As String = "--CHOOSE ITEM--")
        Try
            Dim dt As New DataTable
            Dim dr As DataRow

            dt = SQL_SELECT(strSQL).Tables(0)
            dt.Columns(0).ColumnName = "ID"
            dt.Columns(1).ColumnName = "NAME"
            dr = dt.NewRow

            cbo.Items.Clear()
            dr(0) = -1
            dr(1) = header
            dt.Rows.InsertAt(dr, 0)

            cbo.DataSource = dt
            cbo.DisplayMember = "NAME"
            cbo.ValueMember = "ID"
            cbo.SelectedValue = -1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function cboVal(cbo As ComboBox) As String
        Dim strVal As String = ""
        Try
            If cbo.SelectedValue = -1 Then
                strVal = "NULL"
            Else
                strVal = cbo.SelectedValue
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return strVal
    End Function

    Public Function chkVal(chk As CheckBox) As String
        Dim strVal As String = ""
        Try
            If chk.Checked Then
                strVal = "1"
            Else
                strVal = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return strVal
    End Function

End Module
