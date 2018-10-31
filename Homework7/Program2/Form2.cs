using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Order = Program1.Order;
using OrderDetail = Program1.OrderDetail;
using OrderService = Program1.OrderService;

namespace Program2
{
    public partial class Form2 : Form
    {
        private Order order;
        private OrderService service;
        private Form1 form1;

        public Form2(Form1 form1)
        {
            this.form1 = form1;

            InitializeComponent();
            InitOrderService();
            InitComboBox();
        }

        public Form2(Form1 form1, string id)
        {
            InitializeComponent();
            InitOrderService();
            InitComboBox();
            order = service.SearchOrderByID(id);
            this.Text = "修改订单！";
            this.button1.Text = "改了！";
            //客户不可修改名称
            this.textBox1.Enabled = false;
            this.textBox1.Text = order.Client;
            //物品选中已选物品
            this.comboBox1.SelectedIndex = comboBox1.Items.IndexOf(order.Good);
            //数目为已选物品的总价
            this.comboBox2.SelectedIndex = comboBox2.Items.IndexOf(order.Num.ToString());
            //改单价
            this.label5.Text = order.Price.ToString();
            //改总价
            this.label7.Text = order.Total.ToString();
            //绑定Form1对象
            this.form1 = form1;
        }

        //初始化选择表
        private void InitComboBox()
        {
            comboBox1.Items.Add("iPhone");
            comboBox1.Items.Add("iPad");
            comboBox1.Items.Add("Sumsung");

            for(int i = 1; i <= 10; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }

            comboBox1.SelectedIndex = comboBox1.Items.IndexOf("iPhone");
            comboBox2.SelectedIndex = comboBox2.Items.IndexOf("1");

            this.textBox1.Enabled = true;
        }

        //初始化OrderService
        private void InitOrderService()
        {
            service = new OrderService();
            service.List = service.ImportList();
        }

        //按下按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Enabled)
            {
                if (order != null && textBox1.Text != "")
                {
                    service.AddOrder(order);
                    service.ExportList();
                    service.List = service.ImportList();
                    MessageBox.Show("添加到订单啦！");
                    form1.ReFresh();
                    this.Close();

                }
                else if (textBox1.Text == "" || order == null)
                    MessageBox.Show("这还不是个订单！");
            }
            else
            {
                service.ChangeOrderByTempOrder(order);
                service.ExportList();
                service.List = service.ImportList();
                MessageBox.Show("改完啦！");
                form1.ReFresh();
                this.Close();
            }            
        }

        //用户名
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入客户姓名！");
                label5.Text = "0";
                label7.Text = "0";
                return;
            }
            if (!textBox1.Enabled)
                return;
            order = new Order(textBox1.Text, Int32.Parse(comboBox2.SelectedItem.ToString()), comboBox1.SelectedItem.ToString());
            label5.Text = order.Price.ToString();
            label7.Text = order.Total.ToString();
        }

        //物品
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if(order != null)
            {
                order.Good = comboBox1.SelectedItem.ToString();
                label5.Text = order.Price.ToString();
                label7.Text = order.Total.ToString();
            }
        }

        //数量
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (order != null)
            {
                order.Num = Int32.Parse(comboBox2.SelectedItem.ToString());
                label5.Text = order.Price.ToString();
                label7.Text = order.Total.ToString();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}