using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string str = txtNum.Text;
            string ans = "";
            int a = Int32.Parse(str);
            int i;
            int j = 0;
            //int k, temp;

            ans = "" + a + " = ";

            for(i = 2; i <= a; i++)
            {
                if (i == a)
                {
                    ans += "" + i;
                    continue;
                }

                if (a % i == 0)
                {
                    a = a / i;
                    ans += "" + i + " * ";
                    i = 1;
                    j++;
                    continue;
                }
            }

            listBox.Items.Clear();
            listBox.Items.Add(ans);
        }

        private int getAnswer(int a)
        {
            for(int i = 2; i < 2147483647; i++)
            {

            }
            return 0;
        }
    }
}
