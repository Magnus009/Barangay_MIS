Public Class F_PeopleInvolved
    Public strInvolveID As String

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
            strFile = datDocuments.Rows(e.RowIndex).Cells(2).Value
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
                strRequire = ""
            Else
                With F_CaseFile.datPeopleInvolved
                    Dim strPeopleID As String

                    strPeopleID = .Rows.Count


                    For Each dgPeople As DataGridViewRow In .Rows '2021/03/17
                        If strInvolveID = dgPeople.Cells(0).Value Then

                        End If
                    Next

                    Dim row As String()
                    row = New String() {strPeopleID, txtName.Text, txtInvolvement.Text, chkResident.Checked, txtContactNo.Text, "•••", txtStatement.Text}
                    .Rows.Add(row)
                End With

                With F_CaseFile.datDocuments
                    For Each dr As DataGridViewRow In .Rows
                        If dr.Cells(0).Value = strInvolveID Then
                            .Rows.Remove(dr)
                        End If
                    Next

                    For Each dgr As DataGridViewRow In datDocuments.Rows
                        Dim row As String()
                        row = New String() {dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value, "•••"}
                        .Rows.Add(row)
                    Next
                End With

                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class