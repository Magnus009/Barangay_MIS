Public Class F_BlotterComplaint

    Friend Event complaintBlottered(blnSaved As Boolean)

    Private Sub F_BlotterComplaint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            formLoadSetup(Me)
            lblTitle.Font = New Font("Century Gothic", 12, FontStyle.Bold)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If dtpScheduleDate.Value <= Now Then
                Throw New Exception("Invalid Schedule Date")
            Else
                Dim strSeq As String
                strQuery = "SELECT coalesce(max(Seq), 0) + 1 FROM BlotterDetails WHERE CaseCode = '" + txtCode.Text + "'"
                strSeq = SQL_SELECT(strQuery).Tables(0).Rows(0)(0)

                strQuery = "INSERT INTO BlotterDetails (" + vbCrLf
                strQuery += "CaseCode, " + vbCrLf
                strQuery += "Seq, " + vbCrLf
                strQuery += "StatusID, " + vbCrLf
                strQuery += "ScheduleDate, " + vbCrLf
                strQuery += "CreatedDate, " + vbCrLf
                strQuery += "UpdatedDate, " + vbCrLf
                strQuery += "UpdatedBy)"
                strQuery += "VALUES (" + vbCrLf
                strQuery += "'" + txtCode.Text + "', " + vbCrLf
                strQuery += strSeq + ", " + vbCrLf
                strQuery += "1, " + vbCrLf
                strQuery += "'" + fn_Date(dtpScheduleDate.Value) + "', " + vbCrLf
                strQuery += "getdate(), " + vbCrLf
                strQuery += "getdate(), " + vbCrLf
                strQuery += "'" + UserName + "')"
                If SQL_EXECUTE(strQuery) Then
                    RaiseEvent complaintBlottered(True)
                    MsgBox("Blotter saved!", MsgBoxStyle.Information, "BLOTTER CASE")
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class