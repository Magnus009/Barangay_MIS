Public Class F_Committee
    Dim dtResidentInfo As New DataTable
    Dim strResidentCode As String
    Dim isUpdate As Boolean = False
    Dim intSeq As Integer

    Private Sub F_Committee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)
        getCommittees()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim blnResult As Boolean

            If txtDescription.Text = "" Then
                MsgBox("Please complete the details!")
            Else
               
                If MsgBox("Are you sure you want to save?", vbYesNo + vbQuestion) = vbYes Then
                    If isUpdate = False Then
                        strQuery = ""
                        strQuery += "INSERT INTO dbo.M_Committee (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)" & vbCrLf
                        strQuery += "VALUES (" & vbCrLf
                        strQuery += "'" + txtDescription.Text + "'," & vbCrLf
                        strQuery += "getdate(), null,getdate(),null)" & vbCrLf
                        blnResult = SQL_EXECUTE(strQuery)
                    Else
                        strQuery = "" & vbCrLf
                        strQuery += "UPDATE dbo.M_Committee" & vbCrLf
                        strQuery += "SET Description = '" + txtDescription.Text + "'" & vbCrLf
                        strQuery += "WHERE ID =" + intSeq.ToString & vbCrLf
                        blnResult = SQL_EXECUTE(strQuery)
                    End If
                    

                    If blnResult = True Then
                        MsgBox("Saved Successfully!", vbOKOnly + vbInformation)
                        getCommittees()
                        isUpdate = False
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub getCommittees()
        Try
            Dim dsCommittees As New DataSet

            strQuery = ""
            strQuery += "SELECT id, description FROM M_Committee WHERE DeletedDate IS null" & vbCrLf
            If txtSearch.Text <> "" Then
                strQuery += "AND (Description LIKE '%" + txtSearch.Text + "%')" & vbCrLf
            End If

            dsCommittees = SQL_SELECT(strQuery)

            With datOfficials
                .Columns.Clear()
                .DataSource = dsCommittees.Tables(0)
                .Columns(0).Width = .Width * 0.3
                .Columns(1).Width = .Width * 0.5


                Dim btnEdit As New DataGridViewButtonColumn
                btnEdit.Width = .Width * 0.09
                btnEdit.Resizable = DataGridViewTriState.False
                btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                btnEdit.Text = "EDIT"
                btnEdit.DefaultCellStyle.BackColor = Color.Green
                btnEdit.DefaultCellStyle.ForeColor = Color.White
                btnEdit.UseColumnTextForButtonValue = True
                .Columns.Add(btnEdit)

                Dim btnDelete As New DataGridViewButtonColumn
                btnDelete.Width = .Width * 0.09
                btnDelete.Resizable = DataGridViewTriState.False
                btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                btnDelete.Text = "X"
                btnDelete.DefaultCellStyle.BackColor = Color.Red
                btnDelete.DefaultCellStyle.ForeColor = Color.White
                btnDelete.UseColumnTextForButtonValue = True
                .Columns.Add(btnDelete)
            End With


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub datOfficials_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datOfficials.CellContentClick
        Dim blnResult As Boolean

        If e.ColumnIndex = 2 Then
            isUpdate = True
            intSeq = datOfficials.Rows(e.RowIndex).Cells(0).Value
            txtDescription.Text = datOfficials.Rows(e.RowIndex).Cells(1).Value
        ElseIf e.ColumnIndex = 3 Then
            Try
                If MsgBox("Are you sure want to delete?", vbYesNo + vbQuestion) = vbYes Then
                    strQuery = ""
                    strQuery += "UPDATE dbo.M_Committee" & vbCrLf
                    strQuery += "SET DeletedDate = getdate()" & vbCrLf
                    strQuery += "WHERE Seq =" + Convert.ToInt32(datOfficials.Rows(e.RowIndex).Cells(0).Value).ToString & vbCrLf
                    blnResult = SQL_EXECUTE(strQuery)

                    If blnResult = True Then
                        MsgBox("Deleted Successfully!", vbOKOnly + vbInformation)
                        getCommittees()
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtDescription.Text = ""
        isUpdate = False
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        getCommittees()
    End Sub
End Class