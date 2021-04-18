Public Class F_Committee
    Dim dtResidentInfo As New DataTable
    Dim strResidentCode As String
    Dim isUpdate As Boolean = False
    Dim intSeq As Integer
    Private Sub btnResidents_Click(sender As Object, e As EventArgs) Handles btnResidents.Click
        Dim frmResidentList As New F_SelectionList

        AddHandler frmResidentList.selectedResident, AddressOf loadResidentsInfo
        frmResidentList.loadSelection(1)
    End Sub

    Private Sub loadResidentsInfo(ByVal strResidentID As String)
        Try
            strQuery = ""
            strQuery += "SELECT distinct Code, FamilyName + ', ' + GivenName + ' ' + MiddleName + ' ' + ExtensionName AS 'ResName'," & vbCrLf
            strQuery += "floor(datediff(day, BirthDate, getdate())/365.25) AS 'Age', BirthDate, CS.Description AS 'CivilStatus'," & vbCrLf
            strQuery += "HH.HouseNo + ' ' + HH.Street + ', ' + HH.Municipality + ', ' + HH.Province AS 'Address'" & vbCrLf
            strQuery += "FROM Residents R" & vbCrLf
            strQuery += "INNER JOIN M_CivilStatus CS ON R.CivilStatus = CS.ID " & vbCrLf
            strQuery += "INNER JOIN HouseholdMember HM ON R.Code = HM.ResidentCode" & vbCrLf
            strQuery += "INNER JOIN Household HH ON HM.HouseNo = HH.HouseNo" & vbCrLf
            strQuery += "AND HM.HouseholdNo = HH.HouseholdNo" & vbCrLf
            strQuery += "WHERE R.Code = '" + strResidentID + "'"
            dtResidentInfo = SQL_SELECT(strQuery).Tables(0)

            strResidentCode = strResidentID
            txtResident.Text = dtResidentInfo.Rows(0)("ResName")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getCommitteeList()
        Try
            strQuery = ""
            strQuery += "SELECT ID, Description FROM M_Committee " & vbCrLf

            cboDataBinding(cboCommittee, strQuery, "SELECT COMMITTEE TITLE")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub F_Committee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getCommitteeList()
        getCommittees()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim blnResult As Boolean
            Dim intExist As Integer

            If txtResident.Text = "" Or cboCommittee.SelectedValue = -1 Then
                MsgBox("Please complete the details!")
            Else
                If MsgBox("Are you sure you want to save?", vbYesNo + vbQuestion) = vbYes Then
                    If isUpdate = False Then

                        strQuery = ""
                        strQuery += "SELECT count(*) FROM CommitteeOfficers" & vbCrLf
                        strQuery += "WHERE ID =" + cboCommittee.SelectedValue.ToString + "AND deleteddate IS NULL"
                        intExist = SQL_SELECT(strQuery).Tables(0).Rows(0)(0)

                        If intExist <> 0 Then
                            MsgBox("Already assigned!", vbOKOnly + vbExclamation)
                        Else
                            strQuery = ""
                            strQuery += "INSERT INTO dbo.CommitteeOfficers (ID, ResidentCode, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)" & vbCrLf
                            strQuery += "VALUES (" & vbCrLf
                            strQuery += cboCommittee.SelectedValue.ToString + "," & vbCrLf
                            strQuery += "'" + strResidentCode + "'," & vbCrLf
                            strQuery += "getdate()," & vbCrLf
                            strQuery += "Null," & vbCrLf
                            strQuery += "getdate()," & vbCrLf
                            strQuery += "'master')" & vbCrLf
                            blnResult = SQL_EXECUTE(strQuery)
                        End If
                    Else
                        strQuery = ""
                        strQuery += "UPDATE dbo.CommitteeOfficers" & vbCrLf
                        strQuery += "SET ResidentCode = '" + strResidentCode + "'"
                        strQuery += "WHERE Seq =" + intSeq.ToString
                        blnResult = SQL_EXECUTE(strQuery)
                    End If
                    

                    If blnResult = True Then
                        MsgBox("Saved Successfully!", vbOKOnly + vbInformation)
                        getCommittees()
                        isUpdate = False
                        cboCommittee.Enabled = True
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
            strQuery += "SELECT CO.Seq, CO.ID, CO.ResidentCode, C.Description, R.FamilyName +', '+ R.GivenName +' '+ R.MiddleName AS 'Name' FROM CommitteeOfficers CO" & vbCrLf
            strQuery += "INNER JOIN M_Committee C ON CO.ID = C.ID" & vbCrLf
            strQuery += "INNER JOIN Residents R ON CO.ResidentCode = R.Code" & vbCrLf
            strQuery += "WHERE CO.DeletedDate is null" & vbCrLf
            If txtSearch.Text <> "" Then
                strQuery += "AND (C.Description LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                strQuery += "OR R.FamilyName LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                strQuery += "OR R.GivenName LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                strQuery += "OR R.MiddleName LIKE '%" + txtSearch.Text + "%')" & vbCrLf
            End If
            
            dsCommittees = SQL_SELECT(strQuery)

            With datOfficials
                .Columns.Clear()
                .DataSource = dsCommittees.Tables(0)
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).Visible = False

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

        If e.ColumnIndex = 5 Then
            isUpdate = True
            intSeq = datOfficials.Rows(e.RowIndex).Cells(0).Value
            strResidentCode = datOfficials.Rows(e.RowIndex).Cells(2).Value
            txtResident.Text = datOfficials.Rows(e.RowIndex).Cells(4).Value
            cboCommittee.SelectedValue = datOfficials.Rows(e.RowIndex).Cells(1).Value
            cboCommittee.Enabled = False
        ElseIf e.ColumnIndex = 6 Then
            Try
                If MsgBox("Are you sure want to delete?", vbYesNo + vbQuestion) = vbYes Then
                    strQuery = ""
                    strQuery += "UPDATE dbo.CommitteeOfficers" & vbCrLf
                    strQuery += "SET DeletedDate = getdate()" & vbCrLf
                    strQuery += "WHERE Seq =" + Convert.ToInt32(datOfficials.Rows(e.RowIndex).Cells(0).Value).ToString & vbCrLf
                    strQuery += "AND ID =" + Convert.ToInt32(datOfficials.Rows(e.RowIndex).Cells(1).Value).ToString & vbCrLf
                    strQuery += "AND ResidentCode ='" + datOfficials.Rows(e.RowIndex).Cells(2).Value + "'"
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
        txtResident.Text = ""
        cboCommittee.SelectedValue = -1
        isUpdate = False
        cboCommittee.Enabled = True
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        getCommittees()
    End Sub
End Class