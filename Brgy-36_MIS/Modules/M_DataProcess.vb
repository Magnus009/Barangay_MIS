Module M_DataProcess
    'User's Information
    Public UserName As String
    Public UserLevel As String

    Public strQuery As String

    ''' <summary>
    ''' Returns DataSet
    ''' </summary>
    ''' <param name="strQuery"><i>string</i> SQL SELECT Statement</param>
    Public Function SQL_SELECT(strQuery As String) As DataSet
        Dim dsData As New DataSet
        Try
            Dim sqlConn As New SqlClient.SqlConnection(My.Resources.ConnectionString)
            Dim sqlAdapter As New SqlClient.SqlDataAdapter(strQuery, sqlConn)

            sqlConn.Open()
            sqlAdapter.Fill(dsData)
            sqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dsData
    End Function

    Public Function SQL_EXECUTE(strQuery As String) As Boolean
        Dim blnExecuted As New Boolean

        Try
            Dim sqlConn As New SqlClient.SqlConnection(My.Resources.ConnectionString)
            Dim sqlCmd As New SqlClient.SqlCommand(strQuery, sqlConn)

            sqlCmd.CommandType = CommandType.Text
            sqlConn.Open()
            blnExecuted = Not sqlCmd.ExecuteNonQuery.Equals(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return blnExecuted
    End Function
End Module
