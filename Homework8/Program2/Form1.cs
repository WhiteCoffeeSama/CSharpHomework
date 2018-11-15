using System;
using System.Collections.Generic;
using System.IO;
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
    public partial class Form1 : Form
    {
        public OrderService service = new OrderService();
        List<Order> list = new List<Order>();

        public Form1()
        {
            InitializeComponent();
            InitOrderList();
            InitComboBosToSearch();

            bindingOrderService.DataSource = service;

            dataGridView1.Columns[0].Visible = false;
        }

        //初始化订单
        private void InitOrderList()
        {
            if(File.Exists(@"OrderServiceList.xml"))
            {
                service.List = service.ImportList();
            }
            if(service.List.Count == 0)
            {
                //Order order1 = new Order("CC", 3, "iPhone");
                //Order order2 = new Order("PP", 1, "iPad");
                //Order order3 = new Order("EE", 9, "iPhone");

                //service.AddOrder(order1);
                //service.AddOrder(order2);
                //service.AddOrder(order3);

                Order order4 = new Order("CC", 3, "iPhone", "+86-15827080000");
                Order order5 = new Order("PP", 1, "iPad", "+86-18966874511");
                Order order6 = new Order("EE", 9, "iPhone", "+86-15569875325");

                service.AddOrder(order4);
                service.AddOrder(order5);
                service.AddOrder(order6);

                list = service.List;
                service.ExportList();
            }
        }

        //初始化多选框
        private void InitComboBosToSearch()
        {
            comboBoxToSearch.Items.Add("Client");
            comboBoxToSearch.Items.Add("Good");
            comboBoxToSearch.Items.Add("ID");
        }

        //查询按钮被按下
        private void buttonToSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

            //先恢复所有的可见度
            for (int i = 0; i < service.List.Count; i++)
                dataGridView1.Rows[i].Visible = true;

            SearchList();
        }

        //鼠标点击了列表
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
                return;
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == null || dataGridView1.CurrentCell.Value == null)
                return;
            string str1 = dataGridView1.Columns[e.ColumnIndex].HeaderText.ToString() + ":";
            string str2 = dataGridView1.CurrentCell.Value.ToString();

            labelSelectedRow.Text = str1;
            labelSelectedText.Text = str2;
        }

        //按下new按钮
        private void addNewOrder_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
        }

        //按下re按钮，刷新列表
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxToSearch.Text = "";
            //先恢复所有的可见度
            for (int i = 0; i < service.List.Count; i++)
                dataGridView1.Rows[i].Visible = true;
            SearchList();
        }

        //按下del按钮
        private void delOrder_Click(object sender, EventArgs e)
        {
            labelSelectedRow.Text = "类型";
            labelSelectedText.Text = "物品";

            service.List = service.ImportList();

            string key1 = labelID.Text.ToString();
            if (service.DeleteOrder(key1))
            {
                MessageBox.Show("删除成功！");
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = service;
            this.bindingOrderService.DataSource = bs;

            SearchList();

            //重新导出导入，否则会出现两个同样的订单
            service.ExportList();
            service.List = service.ImportList();
        }

        //按下修改按钮
        private void buttonToChange_Click(object sender, EventArgs e)
        {
            string id = labelID.Text.ToString();
            Form2 form = new Form2(this, id);
            form.Show();
        }

        //刷新列表
        public void ReFresh()
        {
            service.List = service.ImportList();

            BindingSource bs = new BindingSource();
            bs.DataSource = service;
            this.bindingOrderService.DataSource = bs;
        }

        //搜索
        private void SearchList()
        {
            //若没选择项目，则返回
            if (comboBoxToSearch.SelectedItem == null)
                return;
            //选择的项目
            string key1 = comboBoxToSearch.SelectedItem.ToString();
            //输入的关键字
            string key2 = textBoxToSearch.Text.ToString();
            //如果关键字为空，则返回
            if (key2 == "")
                bindingOrderService.DataSource = this.service;
            else
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[this.dataGridView1.DataSource];
                cm.SuspendBinding();

                //通过BitArray来设置这一行是否可见  主要是为了删除查到的订单方便一些
                int[] bits = service.SearchOrderBySettingVisible(key1, key2);
                for (int i = 0; i < service.List.Count; i++)
                {
                    //如果不是，则不可见
                    if (bits[i] == 0)
                        dataGridView1.Rows[i].Visible = false;
                }

                cm.ResumeBinding();
            }
        }

        //按下HTML按钮，生成HTML文件
        private void button2_Click(object sender, EventArgs e)
        {
            service.TransformToHTML();
        }

        //多余
        private void labelID_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
