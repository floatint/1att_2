using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queue
{
    public partial class QueueForm : Form
    {
        public QueueForm()
        {
            InitializeComponent();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            int lftBound = 0;
            int rhtBound = 0;
            DataTypes.Queue<int> queue = new DataTypes.Queue<int>();
            //MyQueue<int> queue = new MyQueue<int>();
            try
            {
                lftBound = int.Parse(leftBound.Text);
                rhtBound = int.Parse(rightBound.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (lftBound > 0)
            {
                MessageBox.Show("Нижняя граница должна быть отрицательной.");
                return;
            }
            if (rhtBound <= 0)
            {
                MessageBox.Show("Верхняя граница должна быть положительной.");
                return;
            }
            srcArr.Clear();
            Random rnd = new Random();
            int tmp;
            for (int i = 1; i <= Math.Abs(lftBound); i++)
            {
                tmp = rnd.Next(lftBound, 0);
                queue.Add(tmp);
                srcArr.Text += tmp.ToString() + ' ';
            };
            queue.Add(0); //middle
            srcArr.Text += "0 ";
            for (int i = 1; i <= rhtBound; i++)
            {
                tmp = rnd.Next(1, rhtBound);
                queue.Add(tmp);
                srcArr.Text += tmp.ToString() + ' ';
            };


            //work
            //DataTypes.Queue<int> result = new DataTypes.Queue<int>();
            try
            {
                QueueLogic.DelAllNegative(queue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //fill resArr
            resArr.Clear();


            //result print
            while (queue.Size != 0)
            {
                resArr.Text += queue.Peek().ToString() + ' ';
            }
        }
    }
}
