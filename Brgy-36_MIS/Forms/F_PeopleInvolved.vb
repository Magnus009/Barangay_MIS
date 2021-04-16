Public Class F_PeopleInvolved
    Public strInvolveID As String

    Dim intFormMode As Integer

    Private Sub btnAttach_Click(sender As Object, e As EventArgs) Handles btnAttach.Click
        Try
            Dim strSourceFile, strFileName, strTempFile As String
            strSourceFile = openFileDialog()

            If strSourceFile <> "" Then
                strFileName = getFileName(strSourceFile)
                strTempFile = ""

                With datDocuments
                    Dim blnExist As Boolean = False
                    If .Rows.Count = 0 Then strTempFile = copyToTemp(strSourceFile)

                    For Each dr As DataGridViewRow In .Rows
                        If UCase(dr.Cells(1).Value) = UCase(strFileName) Then
                            blnExist = True
                        Else
                            strTempFile = copyToTemp(strSourceFile)
                        End If
                    Next

                    If blnExist Then
                        Throw New Exception("File already exist!")
                    Else
                        Dim row As String()
                        row = New String() {strInvolveID, strFileName, Today, strTempFile, "•••", "X"}
                        .Rows.Add(row)
                    End If
                End With
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub datDocuments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datDocuments.CellContentClick
        If e.ColumnIndex = 4 Then
            Dim strFile As String
            strFile = datDocuments.Rows(e.RowIndex).Cells(3).Value
            openFile(strFile)
        ElseIf e.ColumnIndex = 5 Then
            MsgBox("Do you want to remove this file?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "REMOVE FILE")
            If vbYes Then
                datDocuments.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If fn_CheckRequire(Me) Then
                MsgBox("Please complete the required fields(*):" & vbCrLf & strRequire, MsgBoxStyle.Exclamation, "Required Items")
                strRequire = "" : blnRequired = False
            Else
                If btnSave.Text = "&UPDATE" Then
                    'Reload Documents-----------------------------------
                    With F_CaseFile.datDocuments
                        Dim strRows As String = ""
                        For Each dr As DataGridViewRow In .Rows
                            If dr.Cells(0).Value = strInvolveID Then
                                strRows += dr.Index.ToString + ","
                            End If
                        Next
                        strRows = Strings.Left(strRows, Len(strRows) - 1)
                        For Each row As String In strRows.Split(",").Reverse
                            Dim intRow As Integer
                            intRow = Convert.ToInt32(row)
                            .Rows.RemoveAt(intRow)
                        Next

                        For Each dgr As DataGridViewRow In datDocuments.Rows
                            Dim row As String()
                            row = New String() {dgr.Cells(0).Value, _
                                                dgr.Cells(1).Value, _
                                                dgr.Cells(2).Value, _
                                                dgr.Cells(3).Value, _
                                                "•••", _
                                                "X"}
                            .Rows.Add(row)
                        Next
                    End With
                    '---------------------------------------------------
                    'UpdatePeople Involved Detals-----------------------
                    With F_CaseFile.datPeopleInvolved
                        For Each dr As DataGridViewRow In .Rows
                            If dr.Cells(0).Value = strInvolveID Then
                                dr.Cells(2).Value = txtInvolvement.Text
                                dr.Cells(3).Value = chkResident.Checked
                                dr.Cells(4).Value = txtContactNo.Text
                                dr.Cells(6).Value = txtStatement.Text
                            End If
                        Next
                    End With
                    '---------------------------------------------------
                Else
                    With F_CaseFile.datPeopleInvolved
                        Dim strPeopleID As String
                        strPeopleID = .Rows.Count

                        Dim row As String()
                        row = New String() {strPeopleID, _
                                            txtName.Text, _
                                            txtInvolvement.Text, _
                                            chkResident.Checked, _
                                            txtContactNo.Text, _
                                            "•••", _
                                            txtStatement.Text}
                        .Rows.Add(row)
                    End With

                    With F_CaseFile.datDocuments
                        For Each dgr As DataGridViewRow In datDocuments.Rows
                            Dim row As String()
                            row = New String() {dgr.Cells(0).Value, _
                                                dgr.Cells(1).Value, _
                                                dgr.Cells(2).Value, _
                                                dgr.Cells(3).Value, _
                                                "•••", _
                                                "X"}
                            .Rows.Add(row)
                        Next
                    End With
                End If

                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub loadDetails(intTaskMode As Integer)
        'formMode(intTaskMode, Me)
        'intFormMode = intTaskMode

        'If intTaskMode = 0 Then
        '    btnAttach.Visible = False
        '    btnSave.Visible = False
        '    Me.Height = Me.Height - (btnAttach.Height + btnSave.Height)
        '    datDocuments.Columns("colDelete").Visible = False
        'ElseIf intTaskMode = 1 Then
        '    fn_ClearField(Me)
        '    btnSave.Text = "&SAVE"
        'Else
        '    btnSave.Text = "&UPDATE"
        'End If

        Me.ShowDialog()
    End Sub

    Private Sub F_PeopleInvolved_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)
    End Sub
End Class