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
        private Graphics graphics;

        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;

        //label中角度的数值
        int thL = 20;
        int thR = 30;

        //树枝的角度
        double Th1
        {
            set
            {
                th1 = value * Math.PI / 180;
            }
            get
            {
                return th1;
            }
        }
        double Th2
        {
            set
            {
                th2 = value * Math.PI / 180;
            }
            get
            {
                return th2;
            }
        }

        //树枝的长度
        double Per1
        {
            set
            {
                per1 = value;
            }
            get
            {
                return per1;
            }
        }
        double Per2
        {
            set
            {
                per2 = value;
            }
            get
            {
                return per2;
            }
        }

        //第二棵子树的位置系数，k
        double k = 1;

        //Pen
        Pen pen;
        float wid = 1.0f;
        int r;
        int g;
        int b;

        public Form1()
        {
            InitializeComponent();
        }

        private void DoIt()
        {
            if (graphics != null)
                Refresh();
            else
                graphics = this.CreateGraphics();

            //角度
            label2.Text = thL.ToString() + "°";
            label3.Text = thR.ToString() + "°";
            trackBarL.Value = thL;
            trackBarR.Value = thR;

            //长度
            lengthL.Text = per2.ToString();
            lengthR.Text = per1.ToString();
            trackBarLen.Value = (int)(per2 * 10);
            trackBarLenR.Value = (int)(per1 * 10);

            //书中要求，左边子树的位置系数，k
            trackBar1.Value = (int)(k * 10);
            labelOfK.Text = k.ToString();

            //pen的属性
            pen = new Pen(Color.Blue, 1.0f);
            if (checkBoxRnd.Checked)
            {
                var seed1 = Guid.NewGuid().GetHashCode();
                var seed2 = Guid.NewGuid().GetHashCode();
                var seed3 = Guid.NewGuid().GetHashCode();
                Random rnd1 = new Random(seed1);
                Random rnd2 = new Random(seed2);
                Random rnd3 = new Random(seed3);
                r = (int)rnd1.Next(0, 255);
                g = (int)rnd2.Next(0, 255);
                b = (int)rnd3.Next(0, 255);
            }
            setPen(r, g, b, wid);
            rgbR.Text = r.ToString();
            rgbG.Text = g.ToString();
            rgbB.Text = b.ToString();
            width.Text = wid.ToString();
            trackBarRGBR.Value = r;
            trackBarRGBG.Value = g;
            trackBarRGBB.Value = b;
            trackBarWidth.Value = (int)wid;

            //开始画
            drawCayleyTree(10, 335, 500, 100, -Math.PI / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoIt();
        }

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0)
                return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            //左边子树的坐标
            double x2 = x0 + k * leng * Math.Cos(th);
            double y2 = y0 + k * leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            //右边
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            //左边
            drawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2);
        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        //pen的属性
        void setPen(int r, int g, int b, float w)
        {
            pen.Color = Color.FromArgb(r, g, b);
            pen.Width = w;
        }

        //滚动条 —— 角度
        private void trackBarL_Scroll(object sender, EventArgs e)
        {
            thL = trackBarL.Value;
            Th2 = trackBarL.Value;
            label2.Text = trackBarL.Value.ToString() + "°";
        }
        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            thR = trackBarR.Value;
            Th1 = trackBarR.Value;
            label3.Text = trackBarR.Value.ToString() + "°";
        }

        //滚动条 —— 长度
        private void trackBarLen_Scroll(object sender, EventArgs e)
        {
            Per2 = (double)(trackBarLen.Value) / 10;
            lengthL.Text = Per2.ToString();
        }
        private void trackBarLenR_Scroll(object sender, EventArgs e)
        {
            Per1 = (double)(trackBarLenR.Value) / 10;
            lengthR.Text = Per1.ToString();
        }

        //滚动条 —— k
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            k = (double)(trackBar1.Value) / 10;
            labelOfK.Text = k.ToString();
        }

        //滚动条 —— RGB
        private void trackBarRGBR_Scroll(object sender, EventArgs e)
        {
            r = trackBarRGBR.Value;
            rgbR.Text = r.ToString();
        }
        private void trackBarRGBG_Scroll(object sender, EventArgs e)
        {
            g = trackBarRGBG.Value;
            rgbG.Text = g.ToString();
        }
        private void trackBarRGBB_Scroll(object sender, EventArgs e)
        {
            b = trackBarRGBB.Value;
            rgbB.Text = b.ToString();
        }

        //滚动条 —— 宽度
        private void trackBarWidth_Scroll(object sender, EventArgs e)
        {
            wid = (float)trackBarWidth.Value;
            width.Text = wid.ToString();
        }

        //是否随机颜色
        private void checkBoxRnd_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxRnd.Checked)
            {
                trackBarRGBR.Enabled = false;
                trackBarRGBG.Enabled = false;
                trackBarRGBB.Enabled = false;
            }
            else
            {
                trackBarRGBR.Enabled = true;
                trackBarRGBG.Enabled = true;
                trackBarRGBB.Enabled = true;
            }
        }
    }
}
