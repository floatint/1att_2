using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._1._6
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            //get data
            double[] arr = { };
            try
            {
                arr = Converter.StrToArray<double>(listBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    MessageBox.Show(arr[i].ToString());
            //}

            //work
            DataTypes.SortType result = 0;
            //fill list
            DataTypes.List<double> list = new DataTypes.List<double>();
            list.AddToTail(arr);

            try
            {
                result = DataTypes.List<double>.IsSort(list);//ListLogic.IsSort(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //return result

            if (result == DataTypes.SortType.BY_DEC)
                MessageBox.Show("Упорядочен по убыванию");
            if (result == DataTypes.SortType.BY_INC)
                MessageBox.Show("Упорядочен по возрастанию");
            if (result == DataTypes.SortType.NOT_SORT)
                MessageBox.Show("Не упорядочен");



        }
    }
}
