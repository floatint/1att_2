using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualOfSort
{
    public partial class VisualOfSort : Form
    {
        Bitmap[] current = new Bitmap[0];
        Bitmap[] story = new Bitmap[0];
        Bitmap clear = null;

        int prevStateIndex = -1;
        int currStateIndex = 0;
        int nextStateIndex = 1;

        
        //Отрисовка шагов
        private void Paint()
        {
            Graphics fg = this.CreateGraphics();
            int OffsetX = prevStepLabel.Left + prevStepLabel.Width + 5;

            //Затрем старые отрисовки
            fg.DrawImage(clear, OffsetX, prevStepLabel.Top - 5);
            fg.DrawImage(clear, OffsetX, curStepLabal.Top - 5);
            fg.DrawImage(clear, OffsetX, nextStepLabel.Top - 5);
            if (prevStateIndex >= 0)
                fg.DrawImage(story[prevStateIndex], OffsetX, prevStepLabel.Top - 5);
            if (nextStateIndex < story.Length)
                fg.DrawImage(story[nextStateIndex], OffsetX, nextStepLabel.Top - 5);
            fg.DrawImage(current[currStateIndex], OffsetX, curStepLabal.Top - 5);
        }

        public VisualOfSort()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] arr = new int[1000];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(100000);
            }
            ChartView cv = new ChartView(SortLib.QuickSort.SortSeries(), SortLib.BubbleSort.SortSeries());
            cv.Show();
        }

        private void runVisualButton_Click(object sender, EventArgs e)
        {
            if ((current != null) && (story != null))
            {
                Array.Resize<Bitmap>(ref current, 0);
                Array.Resize<Bitmap>(ref story, 0);
            }
            SortLib.QuickSort.Visual(null, 0, 0, ref current, ref story);
            if (clear == null)
            {
                clear = new Bitmap(current[0].Width, current[0].Height);
                Graphics.FromImage(clear).FillRectangle(new SolidBrush(this.BackColor), 0, 0, clear.Width, clear.Height);
            }
            //start values
            prevStepButton.Enabled = false;
            nextStepButton.Enabled = true;
            prevStateIndex = -1;
            currStateIndex = 0;
            nextStateIndex = 1;
            Paint();
            return;
        }

        private void prevStepButton_Click(object sender, EventArgs e)
        {
            prevStateIndex--;
            currStateIndex--;
            nextStateIndex--;
            if (prevStateIndex < 0)
                prevStepButton.Enabled = false;
            else
                prevStepButton.Enabled = true;
            nextStepButton.Enabled = true;
            Paint();
        }

        private void nextStepButton_Click(object sender, EventArgs e)
        {
            prevStateIndex++;
            currStateIndex++;
            nextStateIndex++;
            if (nextStateIndex >= story.Length)
                nextStepButton.Enabled = false;
            else
                nextStepButton.Enabled = true;
            prevStepButton.Enabled = true;
            Paint();
        }
    }
}
