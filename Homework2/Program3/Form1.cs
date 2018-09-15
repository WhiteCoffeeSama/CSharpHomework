using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Program3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i, j;
        ArrayList list = new ArrayList();

        int counts = 0;//复杂度

        private void Form1_Load(object sender, EventArgs e)
        {
            int maxOfArray = 100;

            for (i = 2; i <= maxOfArray; i++)
            {
                //counts++;
                list.Add(i);
            }
                //list.Add(i);

            int count = list.Count;

            for(i = 0; i < count; i++)
            {
                //i > √n, break
                if ((int)list[i] * (int)list[i] > maxOfArray)
                    break;

                for(j = i + 1; j < list.Count; j++)
                {
                    //counts++;
                    if((int)list[j] % (int)list[i] == 0)
                    {
                        //counts++;
                        list.RemoveAt(j);
                    }
                }
            }

            listBox.Items.Add(counts);

            for (i = 0; i < list.Count; i++)
            {
                listBox.Items.Add(list[i]);
            }

            //int[] array = new int[99];

            //for (i = 2; i <= 100; i++)
            //    array[i - 2] = i;

            //for (i = 0; i < 99; i++)
            //{
            //    temp = array[i];
            //    for (j = 2; j <= temp; j++)
            //    {
            //        if (temp % j == 0)
            //        {
            //            if (j == temp)
            //                list.Add(array[i]);
            //            else
            //                break;
            //        }
            //    }
            //}

            //for (i = 0; i < list.Count; i++)
            //{
            //    listBox.Items.Add(list[i]);
            //}
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
