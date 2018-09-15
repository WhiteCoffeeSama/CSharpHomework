using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] array = { { 35, 84, 3 }, { 66, 54, 97 }, { 87, 65, 98 } };
        string title = "数组:";
        string line = "";
        int max, min, sum;
        double ava;

        private void Form1_Load(object sender, EventArgs e)
        {
            lstBox.Items.Add(title);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    line += array[i, j] + "\t";
                    if (j == 2)
                    {
                        lstBox.Items.Add(line);
                        line = "";
                    }
                }

            max = array[0, 0];
            min = array[0, 0];
            sum = 0;
            ava = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (array[i, j] > max) max = array[i, j];
                    if (array[i, j] < min) min = array[i, j];
                    sum += array[i, j];
                }
            }
            ava = sum / 9.0;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            string str = "最大值: " + max;
            lstBox.Items.Add(str) ;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            string str = "最小值: " + min;
            lstBox.Items.Add(str);
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAva_Click(object sender, EventArgs e)
        {
            string str = "平均值: " + ava;
            lstBox.Items.Add(str);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            string str = "  和  : " + sum;
            lstBox.Items.Add(str);
        }
    }
}
