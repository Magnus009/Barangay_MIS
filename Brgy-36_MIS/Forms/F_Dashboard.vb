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
                Case 3
                    strChartArea = "Inventory"
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
                            .Points(0).Color = Color.OrangeRed
                            .Points(0).Color = Color.LightGreen
                            .Points(0).Color = Color.LightGoldenrodYellow
                            .Points(0).Color = Color.SeaGreen
                            .Points(0).Color = Color.Orange
                        Case 3
                            .Points(0).Color = Color.Blue
                            .Points(0).Color = Color.LimeGreen
                            .Points(0).Color = Color.LightYellow
                            .Points(0).Color = Color.ForestGreen
                            .Points(0).Color = Color.LightBlue
                            .Points(0).Color = Color.Red
                    End Select
                End With
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub tabGraph_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabGraph.SelectedIndexChanged
        loadChart(tabGraph.SelectedIndex + 1, chrtResident)
    End Sub
End Class