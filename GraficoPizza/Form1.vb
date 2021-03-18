Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Private Sub btn_gerar_Click(sender As Object, e As EventArgs) Handles btn_gerar.Click
        gerarGraficoPizza()
    End Sub

    Private Sub gerarGraficoPizza()
        Dim produtos() As String = {"arroz", "feijão", "óleo", "Açúcar", "Sal", "Outros"}
        Dim valores() As Double = {34923, 20900, 16300, 9100, 26800, 5400}

        chart_pizza.Series.Add("vendas")

        With chart_pizza
            .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie

            .ChartAreas(0).Area3DStyle.Enable3D = True
            .ChartAreas(0).Area3DStyle.Inclination = 60
            .ChartAreas(0).Area3DStyle.Rotation = 60

            .Palette = ChartColorPalette.EarthTones

            .Series(0).IsValueShownAsLabel = True
            .Series(0).Points.DataBindXY(produtos, valores)

        End With

    End Sub
End Class
