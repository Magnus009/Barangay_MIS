Public Class F_Dashboard
    '►◄

    Private Sub F_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Left = 0
            Top = Screen.PrimaryScreen.Bounds.Height / 12
            btnShowHide.Text = "◄"
            loadChart(1, chrtResident)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnShowHide_Click(sender As Object, e As EventArgs) Handles btnShowHide.Click
        If btnShowHide.Text = "◄" Then
            Left -= pnlDashBoard.Width
            btnShowHide.Text = "►"
        Else
            Left += pnlDashBoard.Width
            btnShowHide.Text = "◄"
        End If
    End Sub

    Private Sub loadChart(intChart As Integer, chrt As DataVisualization.Charting.Chart)
        Try
            Dim strChartArea As String = ""
            Dim dtChart As New DataTable

            Select Case intChart
                Case 1
                    strChartArea = "Residents"

                    strQuery = "SELECT 'TOTAL' AS NAME, count(*) AS COUNT FROM Residents" + vbCrLf
                    strQuery += "UNION ALL" + vbCrLf
                    strQuery += "SELECT 'VOTERS' AS NAME, count(*) AS COUNT FROM Residents WHERE isVoter = 1"
                    strQuery += "UNION ALL" + vbCrLf
                    strQuery += "SELECT 'MALE' AS NAME, count(*) AS COUNT FROM Residents WHERE Gender = 'M'"
                    strQuery += "UNION ALL" + vbCrLf
                    strQuery += "SELECT 'FEMALE' AS NAME, count(*) AS COUNT FROM Residents WHERE Gender = 'F'"
                    dtChart = SQL_SELECT(strQuery).Tables(0)
                Case 2
                    strChartArea = "Blotters"

                    strQuery = "SELECT 'SETTLED' AS NAME, count(*) AS COUNT FROM BlotterDetails" + vbCrLf
                    strQuery += "WHERE StatusID = 0" + vbCrLf
                    strQuery += "UNION ALL" + vbCrLf
                    strQuery += "SELECT 'UNSETTLED' AS NAME, count(*) AS COUNT FROM BlotterDetails" + vbCrLf
                    strQuery += "WHERE StatusID = 1" + vbCrLf
                    strQuery += "UNION ALL" + vbCrLf
                    strQuery += "SELECT 'SCHEDULED' AS NAME, count(*) AS COUNT FROM BlotterDetails" + vbCrLf
                    strQuery += "WHERE ScheduleDate Is Not NULL" + vbCrLf
                    strQuery += "UNION ALL" + vbCrLf
                    strQuery += "SELECT 'DUE DATE' AS NAME, count(*) AS COUNT FROM BlotterDetails" + vbCrLf
                    strQuery += "WHERE Convert(VARCHAR(10), ScheduleDate, 112) = Convert(VARCHAR(10), getdate(), 112)" + vbCrLf
                    strQuery += "AND MeetingDate IS NULL" + vbCrLf
                    strQuery += "UNION ALL" + vbCrLf
                    strQuery += "SELECT 'OVERDUE' AS NAME, count(*) AS COUNT FROM BlotterDetails" + vbCrLf
                    strQuery += "WHERE DateDiff(Day, ScheduleDate, getdate()) > 0" + vbCrLf
                    strQuery += "AND MeetingDate IS NULL"
                    dtChart = SQL_SELECT(strQuery).Tables(0)
                Case 3
                    strChartArea = "Inventory"

                    strQuery = "SELECT 'BORROW' AS NAME, count(*) AS COUNT FROM T_BorrowHeader WHERE StatusID = 1" + vbCrLf
                    strQuery += "UNION ALL" + vbCrLf
                    strQuery += "SELECT 'RETURNED' AS NAME, count(*) AS COUNT FROM T_BorrowHeader WHERE StatusID = 4" + vbCrLf
                    strQuery += "UNION ALL" + vbCrLf
                    strQuery += "SELECT 'CANCELLED' AS NAME, count(*) AS COUNT FROM T_BorrowHeader WHERE StatusID = 3" + vbCrLf
                    strQuery += "UNION ALL" + vbCrLf
                    strQuery += "SELECT 'OVERDUE' AS NAME, count(*) AS COUNT FROM T_BorrowHeader WHERE StatusID = 2"
                    dtChart = SQL_SELECT(strQuery).Tables(0)
            End Select


            With chrt
                .Legends.Clear()

                With .ChartAreas
                    .Clear()
                    .Add(strChartArea)

                    With .Item(0)
                        .AxisX.MajorGrid.Enabled = False
                        .AxisY.MajorGrid.Enabled = True
                        .AxisX.LabelAutoFitStyle = DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont
                        .AxisY.LabelAutoFitStyle = DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont
                        .AxisY.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.Dot
                    End With
                End With

                With .Series
                    .Clear()
                    .Add("srsCount")
                    For Each row As DataRow In dtChart.Rows
                        .Item(0).Points.AddXY(row(0), row(1))
                    Next
                    .Item(0).IsValueShownAsLabel = True
                    .Item(0).BorderColor = Color.Black
                End With


                With .Series(0)
                    Select Case intChart
                        Case 1
                            .Points(0).Color = Color.LightSeaGreen
                            .Points(1).Color = Color.Tan
                            .Points(2).Color = Color.LightSkyBlue
                            .Points(3).Color = Color.Pink
                        Case 2
                            .Points(0).Color = Color.Green
                            .Points(1).Color = Color.Gray
                            .Points(2).Color = Color.LightGoldenrodYellow
                            .Points(3).Color = Color.Blue
                            .Points(4).Color = Color.Red
                        Case 3
                            .Points(0).Color = Color.Blue
                            .Points(0).Color = Color.LimeGreen
                            .Points(0).Color = Color.Orange
                            .Points(0).Color = Color.Maroon
                    End Select
                End With
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub tabGraph_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabGraph.SelectedIndexChanged
        loadChart(tabGraph.SelectedIndex + 1, Choose(tabGraph.SelectedIndex + 1, chrtResident, chrtBlotters, chrtInventory))
    End Sub
End Class