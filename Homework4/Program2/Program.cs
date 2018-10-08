using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            var all = new OrderDetail(0);
            all.ShowGoods();

            try
            {
                Order order1 = new Order(2, 1, "CC");
                Order order2 = new Order(1, 100, "PP");
                Order order3 = new Order(3, 1, "TuHao");
                Order order4 = new Order(1, 1, "A");

                OrderService service = new OrderService();
                service.AddOrder(order1);
                service.AddOrder(order2);
                service.AddOrder(order3);
                service.AddOrder(order4);

                service.ShowGouWuChe();
                Console.WriteLine("");

                System.Threading.Thread.Sleep(2000);
                service.DeleteOrder(order4.ID);
                service.ShowGouWuChe();
                Console.WriteLine("");

                System.Threading.Thread.Sleep(2000);
                service.ChangeOrder(order2.ID, 2, 9);
                service.ShowGouWuChe();
                Console.WriteLine("");

                System.Threading.Thread.Sleep(2000);
                service.DeleteOrder("123456");
            }
            catch (DefaultInfluenceOrder e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }

    class Order
    {
        static int PPP = 76;

        private int num;
        private int count;
        private string id;
        private string goods;
        private string client;
        private OrderDetail detail;

        public Order(int goodsNo, int count, string client)
        {
            //为购物单号码准备
            var dt = DateTime.Now;

            this.Count = count;
            this.Num = goodsNo;
            this.Detail = new OrderDetail(goodsNo);
            this.Goods = Detail.GoodsName;
            this.Client = client;
            this.ID = "88459" + dt.Year.ToString() + dt.Month.ToString() + dt.Hour.ToString() + dt.Minute.ToString() + PPP.ToString();
            PPP += 3;
        }

        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value - 1;
            }
        }                       //物品代码

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }                     //购买数量

        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
        }                     //购物单代码

        public string Goods
        {
            get
            {
                return goods;
            }
            set
            {
                this.goods = Detail.GoodsName;
            }
        }                  //商品名称，与Detail有关

        public string Client
        {
            get
            {
                return client;
            }
            set
            {
                this.client = value;
            }
        }                 //客户名称

        public OrderDetail Detail
        {
            get
            {
                return detail;
            }
            set
            {
                this.detail = new OrderDetail(num);
            }
        }            //订单细节，与Num有关
    }

    class OrderDetail
    {
        private string[][] goodsDetails = new string[3][] {
            new string[]{ "9999", "1", "789456123", "Gold" },
            new string[]{ "6666", "2", "123456789", "Gem4CP" },
            new string[]{ "78910", "1", "22222222", "Room" } };

        private int idno;
        private string price;
        private string count;
        private string barcode;
        private string goodsnm;

        public OrderDetail(int num)
        {
            IdNo = num;
        }

        public int IdNo
        {
            get
            {
                return idno;
            }
            set
            {
                idno = value;
            }
        }

        public string Price
        {
            get
            {
                return goodsDetails[idno][0]; ;
                //return price;
            }
            set
            {
                price = goodsDetails[idno][0];
            }
        }

        public string Count
        {
            get
            {
                return count;
            }
            set
            {
                count = goodsDetails[idno][1];
            }
        }

        public string Barcode
        {
            get
            {
                return barcode;
            }
            set
            {
                barcode = goodsDetails[idno][2];
            }
        }

        public string GoodsName
        {
            get
            {
                return goodsDetails[idno][3];
                //return goodsnm;
            }
            set
            {
                goodsnm = goodsDetails[idno][3];
            }
        }

        public void ShowGoods()
        {
            Console.WriteLine("No\tName\tPrice\tCount\tBarcode\n");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine((i+1) + "\t" + goodsDetails[i][3] + "\t" + goodsDetails[i][0] + "\t" + goodsDetails[i][1] + "\t" + goodsDetails[i][2] + "\n");
            }
        }
    }

    class OrderService
    {
        private List<Order> listOfOrders;

        public OrderService()
        {
            listOfOrders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            listOfOrders.Add(order);
        }

        public void DeleteOrder(string id)
        {
            for(int i = 0; i < listOfOrders.Count; i++)
            {
                if (listOfOrders[i].ID == id)
                {
                    listOfOrders.Remove(listOfOrders[i]);
                    return;
                }
            }

            throw new DefaultInfluenceOrder("删除失败！");
        }

        public void ChangeOrder(string id, int goodsNo, int count)
        {
            for (int i = 0; i < listOfOrders.Count; i++)
            {
                if (listOfOrders[i].ID == id)
                {
                    listOfOrders[i].Num = goodsNo;
                    listOfOrders[i].Count = count;
                    return;
                }
            }

            throw new DefaultInfluenceOrder("修改失败！");
        }

        public Order SearchOrder(string id)
        {
            bool exist = false;
            for (int i = 0; i < listOfOrders.Count; i++)
            {
                if (listOfOrders[i].ID == id)
                {
                    return listOfOrders[i];
                    exist = true;
                    break;
                }
            }
            if(!exist)
            {
                Console.WriteLine("没有这个订单!");
                return null;
            }
            return null;
        }

        public void ShowGouWuChe()
        {
            Console.WriteLine("No\tName\tPrice\tCount\tID\t\t\tClient\n");
            for(int i = 0; i < listOfOrders.Count; i++)
            {
                Console.WriteLine((i + 1) + "\t" + (listOfOrders[i].Goods) + "\t" + listOfOrders[i].Detail.Price + "\t" + listOfOrders[i].Count + "\t" + listOfOrders[i].ID + "\t" + listOfOrders[i].Client + "\n");
            }
        }
    }

    class DefaultInfluenceOrder:ApplicationException
    {
        public DefaultInfluenceOrder(string message):base(message)
        {

        }
    }
}