using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace stack
{
    public partial class StackForm : Form
    {
        public StackForm()
        {
            
            InitializeComponent();
        }

        private void run_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileIn = new OpenFileDialog();
            SaveFileDialog fileOut = new SaveFileDialog();

            if ((fileIn.ShowDialog() != DialogResult.OK) || (fileOut.ShowDialog() != DialogResult.OK))
            {
                MessageBox.Show("Не выбран входной или выходной файл.");
                return;
            }

            //read input file
            string buffer = "";
            try
            {
                buffer = File.ReadAllText(fileIn.FileName);
                if (buffer.Length == 0)
                    throw new Exception("File is empty.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //create stack
            //MyStack<char> stack = new MyStack<char>();
            DataTypes.Stack<char> stack = new DataTypes.Stack<char>();
            for (int i = 0; i < buffer.Length; i++)
            {
                stack.Push(buffer[i]);
            }
            //get number
            try
            {
                buffer = StackLogic.GetNumber(stack);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            //write result
            try
            {
                File.WriteAllText(fileOut.FileName, buffer);
                MessageBox.Show(String.Format("Результат {0} в : {1}", buffer, fileOut.FileName));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
