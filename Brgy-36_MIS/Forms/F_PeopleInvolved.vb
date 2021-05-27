Public Class F_PeopleInvolved
    Public strInvolveID As String

    Dim intFormMode As Integer
    Dim caseForm As New Form

    Friend Event involvementDetails(ByVal strPeopleInvolved As String(), ByVal dtDocuments As DataTable)

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
            Dim msgDialog As DialogResult
            msgDialog = MsgBox("Do you want to remove this file?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "REMOVE FILE")

            If msgDialog = Windows.Forms.DialogResult.Yes Then
                datDocuments.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If fn_CheckRequire(Me) Then
                strRequire = "" : blnRequired = False
                MsgBox("Please complete the required fields(*):" & vbCrLf & strRequire, MsgBoxStyle.Exclamation, "Required Items")
            Else
                Dim strPeople As String()
                Dim dt As New DataTable

                strPeople = peopleDetails(strInvolveID)
                dt = supportingDocuments()
                RaiseEvent involvementDetails(strPeople, dt)

                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub loadDetails(intTaskMode As Integer, frmCase As Form)
        formMode(intTaskMode, Me)
        btnAttach.Font = My.Settings.Substring
        intFormMode = intTaskMode

        If intTaskMode = 0 Then
            btnAttach.Visible = False
            btnSave.Visible = False
            Me.Height = Me.Height - (btnAttach.Height + btnSave.Height)
            datDocuments.Columns("colDelete").Visible = False
        ElseIf intTaskMode = 1 Then
            fn_ClearField(Me)
            btnSave.Text = "&SAVE"
        Else
            btnSave.Text = "&UPDATE"
            caseForm = frmCase
        End If

        Me.ShowDialog()
    End Sub

    Private Sub F_PeopleInvolved_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.Primary
        pnlDetails.BackColor = My.Settings.Secondary
    End Sub

    Private Function peopleDetails(ByVal strPeopleID As String) As String()
        Dim peopleInvolved As String()
        Try
            peopleInvolved = New String() {strPeopleID, _
                                           txtName.Text, _
                                           txtInvolvement.Text, _
                                           chkResident.Checked, _
                                           txtContactNo.Text, _
                                            "•••", _
                                           txtStatement.Text, _
                                           txtResidentID.Text}
            Return peopleInvolved
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function
    Private Function supportingDocuments() As DataTable
        Dim supportingDocs As New DataTable
        Try
            With supportingDocs
                .Columns.Add("colPresenterID")
                .Columns.Add("colFileName")
                .Columns.Add("colDateSubmitted")
                .Columns.Add("colSourceFile")
                .Columns.Add("colOpen")
                .Columns.Add("colDelete")

                For Each dgRow As DataGridViewRow In datDocuments.Rows
                    Dim rowVal As String()
                    rowVal = New String() {dgRow.Cells(0).Value, _
                                           dgRow.Cells(1).Value, _
                                           dgRow.Cells(2).Value, _
                                           dgRow.Cells(3).Value, _
                                           "OPEN", _
                                           "X"}
                    .Rows.Add(rowVal)
                Next
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return supportingDocs
    End Function
    Public Sub loadInvolvedDetails(ByVal strPeopleDetails As String(), ByVal supportingDocs As DataTable)
        Try
            'Person Involved Details
            strInvolveID = strPeopleDetails(0)
            chkResident.Checked = strPeopleDetails(2)
            txtName.Text = strPeopleDetails(1)
            txtInvolvement.Text = strPeopleDetails(3)
            txtContactNo.Text = strPeopleDetails(4)
            txtStatement.Text = strPeopleDetails(5)
           
            'Supporting Docs
            For Each dr As DataRow In supportingDocs.Rows
                Dim row As String()
                row = New String() {dr(0), dr(1), dr(2), dr(3), dr(4), dr(5)}
                datDocuments.Rows.Add(row)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnResidentList_Click(sender As Object, e As EventArgs) Handles btnResidentList.Click
        Dim frmResidentsList As New F_SelectionList

        AddHandler frmResidentsList.selectedResident, AddressOf loadReportedBy
        frmResidentsList.loadSelection(1)
    End Sub

    Private Sub loadReportedBy(ByVal strResidentID As String)
        txtResidentID.Text = strResidentID
        strQuery = "SELECT FamilyName + ', ' + GivenName + ' ' + MiddleName + ' ' + ExtensionName  FROM Residents WHERE Code = '" + strResidentID + "'"
        txtName.Text = SQL_SELECT(strQuery).Tables(0).Rows(0)(0)
    End Sub

    Private Sub chkResident_CheckedChanged(sender As Object, e As EventArgs) Handles chkResident.CheckedChanged
        btnResidentList.Visible = chkResident.Checked
        If chkResident.Checked Then
            txtName.Text = ""
            txtName.ReadOnly = True
        Else
            txtName.ReadOnly = False
        End If
    End Sub
End Class