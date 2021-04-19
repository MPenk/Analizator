using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace Analizator
{
    class SpecialChart
    {

        Chart chart;
        Data data;

        public SpecialChart(Chart chart, Data data, bool create = false) {

            this.chart = chart;
            this.data = data;

            if (create == true) {
                CreateChart();
            }

        }
        public Chart GetChart() {
            return this.chart;
        }
        /// <summary>
        /// Clear chart
        /// </summary>
        private void ClearChart()
        {
            //Czyszczenie poprzedniego wykresu
            this.chart.ChartAreas.Clear();
            this.chart.Series.Clear();
            this.chart.Series.Clear();
            this.chart.Legends.Clear();

        }

        /// <summary>
        /// Create new chart
        /// </summary>
        private void CreateChart()
        {
            this.chart.ChartAreas.Add("area");
            this.chart.Series.Add("data");
            this.chart.Series.Add("dataPoint");
            this.chart.Series.Add("average");
            this.chart.Legends.Add("legend");
            this.chart.Legends["legend"].BorderDashStyle = ChartDashStyle.Dash;
            this.chart.Legends["legend"].BackColor = Color.Transparent;

            FillChartWithNewData(this.data, this.chart.ChartAreas["area"], this.chart.Series["data"], this.chart.Series["average"], this.chart.Series["dataPoint"]);
        }


        /// <summary>
        /// Reset data in chart, and create a new ones.
        /// </summary>
        public void SetNewDataToChart(Data data)
        {
            this.data = data;
            ClearChart();
            CreateChart();
        }

        private void FillChartWithNewData(Data data, ChartArea areaMain, Series seriesData, Series seriesAverage, Series seriesDataPoint)
        {
            //Ustawianie obszaru wykresu
            areaMain.AxisX.Minimum = 0;
            areaMain.AxisX.Maximum = data.GetDataLenght() - 1;
            areaMain.AxisX.Interval = 1;
            areaMain.AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;

            //Wyliczanie i ustawienie Y minimum
            areaMain.AxisY.Minimum = Math.Round(data.Min() - (data.Average() - data.Min()), 1);
            

            //Ustawienie typu i koloru wykresów
            //Dla danych
            seriesDataPoint.ChartType = SeriesChartType.Point;
            seriesDataPoint.Color = Color.Red;
            seriesDataPoint.MarkerSize = 7;


            seriesData.ChartType = SeriesChartType.Spline;
            seriesData.BorderWidth = 2;
            seriesData.Color = Color.Red;
            //Dla średniej
            seriesAverage.ChartType = SeriesChartType.Line;
            seriesAverage.Color = Color.Green;

            //Ustaawienie legendy
            seriesData.LegendText = "Wyniki";
            seriesAverage.LegendText = "Średnia";
            seriesDataPoint.IsVisibleInLegend = false;


            //Wypełnianie wykresu
            int point = 0;
            foreach (var item in data.GetFileContent())
            {
                seriesData.Points.AddXY(point, item);
                seriesDataPoint.Points.AddXY(point, item);
                seriesAverage.Points.AddXY(point, data.Average());

                point++;
            }

        }

        public double GetYInterval() {
            return this.chart.ChartAreas["area"].AxisY.Interval;
        }
        public double GetYMax()
        {
            return this.data.Max();
        }
        public double GetYMin() {
            return this.chart.ChartAreas["area"].AxisY.Minimum;
        }

        public void SetYInterval(double y)
        {
            this.chart.ChartAreas["area"].AxisY.Interval = y;
        }
        public void SetYMin(bool auto, double y)
        {
            this.chart.ChartAreas["area"].AxisY.Minimum = y;
        }

        public void SetYMin(double y) {

            this.chart.ChartAreas["area"].AxisY.Minimum = y;

        }
        public HitTestResult[] GetHitTest(int x, int y) 
        {  
            return this.chart.HitTest(x, y, false, ChartElementType.DataPoint);
        }
        /// <summary>
        /// Change color series
        /// </summary>
        public void ChangeColor(string what, Color color) {

           this.chart.Series[what].Color = color;

        }

        /// <summary>
        /// Change visible serie 
        /// </summary>
        public void Visible(string what, bool visible) {
            if (visible) 
                this.chart.Series[what].Enabled = true;
            else
                this.chart.Series[what].Enabled = false;
        }

    }
}
