using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortDemonstration
{
    public partial class SortDemonstration : Form
    {
        public SortDemonstration()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            double a = 0;
            if (acoeffTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите коэффицент.");
                return;
            }
            try
            {
                a = double.Parse(acoeffTextBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                if ((elemCountTextBox.Text.Length == 0) && (int.Parse(elemCountTextBox.Text) <= 0))
                {
                    MessageBox.Show("Неверное поле кол-ва элементов.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            int cnt = int.Parse(elemCountTextBox.Text);

            //datagrids set settings
            unsortedGrid.RowCount = cnt;
            unsortedGrid.ColumnCount = 2;
            unsortedGrid.Columns[0].HeaderText = "X";
            unsortedGrid.Columns[1].HeaderText = "Y";
            sortedGrid.RowCount = cnt;
            sortedGrid.ColumnCount = 2;
            sortedGrid.Columns[0].HeaderText = "X";
            sortedGrid.Columns[1].HeaderText = "Y";

            SortLib.MergeSort.DeviceData[] workArr = new SortLib.MergeSort.DeviceData[cnt];

            //fill data
            Random ran = new Random();
            for (int i = 0; i < cnt; i++)
            {
                //у = a sin(ax) cos2(x / a).
                int x = ran.Next(100);
                workArr[i].x = x;
                workArr[i].y = a * Math.Sin(a * x) * Math.Pow((x / a), 2);
            }
            //fill unsorted datagrid
            for (int i = 0; i < cnt; i++)
            {
                unsortedGrid[0, i].Value = workArr[i].x;
                unsortedGrid[1, i].Value = workArr[i].y;
            }
            //sort
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            SortLib.MergeSort.DeviceData[] sorted = SortLib.MergeSort.Sort(workArr);
            sw.Stop();
            timeLabel.Text = "Время сортировки : " + (sw.ElapsedMilliseconds / 100f).ToString() + " c";
            //fill sorted datagrid
            for (int i = 0; i < cnt; i++)
            {
                sortedGrid[0, i].Value = sorted[i].x;
                sortedGrid[1, i].Value = sorted[i].y;
            }
        }
    }
}
