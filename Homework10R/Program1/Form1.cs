using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Order = Program0.Order;
using OrderDetail = Program0.OrderDetail;
using OrderService = Program0.OrderService;

namespace Program1
{
    public partial class Form1 : Form
    {
        public OrderService service;
        public OrderService tempService;
        public List<Order> list;

        public Form1()
        {
            InitializeComponent();

            service = new OrderService();
            tempService = new OrderService();
            list = new List<Order>();
            InitService();
            InitComboBox();

            bindingSource1.DataSource = service;
        }

        private void InitComboBox()
        {
            comboBoxToSearch.Items.Add("Client");
            comboBoxToSearch.Items.Add("ID");
        }
        private void InitService()
        {
            List<OrderDetail> listOfItems1 = new List<OrderDetail>()
            {
                new OrderDetail("1", "iPhone", 10),
                new OrderDetail("2", "XiaoMi", 1)
            };
            Order order1 = new Order("CC", "15827082200", listOfItems1);
            service.AddOrder(order1);

            List<OrderDetail> listOfItems2 = new List<OrderDetail>()
            {
                new OrderDetail("1", "iPhone", 10),
                new OrderDetail("2", "XiaoMi", 1)
            };
            Order order2 = new Order("PP", "15827082200", listOfItems2);
            service.AddOrder(order2);
        }

        private void buttonToRefresh_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = service;
        }
        private void buttonToDelete_Click(object sender, EventArgs e)
        {
            if (service.DelOrder(labelOfCheckedID.Text.ToString()))
                MessageBox.Show("删完啦！");
            bindingSource1.DataSource = service;

            BindingSource bs = new BindingSource();
            bs.DataSource = service;
            this.bindingSource1.DataSource = bs;

            //tempService.DelOrder(labelOfCheckedID.ToString());
        }
        private void buttonToSearch_Click(object sender, EventArgs e)
        {
            if(comboBoxToSearch.SelectedItem != null)
            {
                if(textBoxToSearch.Text.ToString() != "")
                {
                    if (comboBoxToSearch.SelectedItem.ToString() == "Client")
                        tempService.List = service.SearchOrderByClient(textBoxToSearch.Text.ToString());
                    else if (comboBoxToSearch.SelectedItem.ToString() == "ID")
                        tempService.List = service.SearchOrderByID(textBoxToSearch.Text.ToString());
                }
                else
                {
                    MessageBox.Show("未填写！");
                    return;
                }
            }
            else
            {
                MessageBox.Show("未选中！");
                return;
            }
            if(tempService.List.Count == 0)
            {
                MessageBox.Show("未找到！");
                return;
            }
            else
            {
                bindingSource1.DataSource = tempService;
            }
        }
        private void buttonToChange_Click(object sender, EventArgs e)
        {

        }
        private void buttonToAdd_Click(object sender, EventArgs e)
        {

        }
    }
}