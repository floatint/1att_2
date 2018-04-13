using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VisualOfSort
{
    public partial class ChartView : Form
    {
        public ChartView(DataPoint[] sort1, DataPoint[] sort2)
        {
            InitializeComponent();
            sortChart.Series.Add(new Series());
            sortChart.Series.Add(new Series());
            sortChart.Series[0].ChartType = SeriesChartType.Line;
            sortChart.Series[1].ChartType = SeriesChartType.Line;
            sortChart.Series[0].Color = Color.Blue;
            sortChart.Series[1].Color = Color.Red;
            sortChart.Series[0].Name = "QuickSort";
            sortChart.Series[1].Name = "BubbleSort";
            sortChart.ChartAreas[0].AxisX.Title = "Array size";
            sortChart.ChartAreas[0].AxisY.Title = "Exchanges count";
            for (int i = 0; i < sort1.Length; i++)
            {
                sortChart.Series[0].Points.Add(sort1[i]);
                sortChart.Series[1].Points.Add(sort2[i]);
            }
        }
    }
}
