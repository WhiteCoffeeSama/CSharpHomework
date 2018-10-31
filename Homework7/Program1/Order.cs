using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Program1
{
    class Test
    {
        static void Main(string[] args)
        {
            Order order1 = new Order("CC", 3, "iPhone");
            Order order2 = new Order("PP", 1, "iPad");
            Order order3 = new Order("EE", 9, "iPhone");

            OrderService service = new OrderService();
            service.AddOrder(order1);
            service.AddOrder(order2);
            service.AddOrder(order3);

            Console.WriteLine("Xml文件");
            service.ExportList();

            List<Order> list = new List<Order>();
            list = service.ImportList();

            Console.WriteLine("原先的订单");
            service.DisplayOrderList();
            Console.WriteLine("新的订单");
            OrderService.DisplayList(list);

            Console.WriteLine("iPhone");
            List<Order> list2 = new List<Order>();
            list2 = service.SearchOrderLinqByGood("iPhone");
            OrderService.DisplayList(list2);

            Console.WriteLine("Change Count of iPhone");
            service.ChangeOrder(order1.ID, 30);
            service.DisplayOrderList();

            Console.WriteLine("Change the Price of Order1 to 9999");
            service.SearchOrderByID(order1.ID).Detail[service.SearchOrderByID(order1.ID).Good, "Price"] = 9999.ToString();
            service.DisplayOrderList();

            Console.ReadLine();
        }
    }

    public class Order
    {
        private string  client;                                                        //客户姓名
        private int     num;                                                           //物品数量
        private string  good;                                                          //物品
        private string  id;                                                            //订单号
        private OrderDetail detail;                                                    //细节

        public string  Client
        {
            set { client = value; }
            get { return client; }
        }
        public int     Num
        {
            set { num = value; }
            get { return num; }
        }
        public string  Good
        {
            set { good = value; }
            get { return good; }
        }
        public string  ID
        {
            set { id = value; }
            get { return id; }
        }
        public OrderDetail Detail
        {
            set { detail = new OrderDetail(Good); }
            get { return detail; }
        }

        public int Price
        {
            set { Detail[Good, "price"] = value.ToString(); }
            get
            {
                return Int32.Parse(Detail[Good, "Price"]);
            }
        }
        public int Total
        {
            get { return Price * Num; }
        }



        static int IDSuffix = 124;                                                     //ID后缀

        public Order() { }                                                             //无参构造
        public Order(string client, int num, string good)
        {
            this.Client = client;
            this.Num = num;
            this.Good = good;
            this.ID = "88459" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + IDSuffix.ToString();
            this.Detail = new OrderDetail(this.Good);
            IDSuffix += 19;
        }                           //有参构造
    }

    public class OrderDetail
    {
        private string[] good;                                                         //商品属性

        private string[] keysOfGoodDetail =
        {
            "Name", "Price", "Barcode"
        };                                        //商品属性关键字

        List<string[]> goods = new List<string[]>()
        {
            new string[] {"iPhone",  "1234", "123456789"},
            new string[] {"iPad",    "2345", "234567891"},
            new string[] {"Sumsung", "1111", "345678912"}
        };                                //商品清单

        public OrderDetail() { }
        public OrderDetail(string name)
        {
            good = this[name];
        }

        public string[] this[string key]
        {
            get
            {
                foreach(string[] good in goods)
                {
                    if (good[0] == key)
                        return good;
                }
                return null;
            }
        }                                            //通过    商品名称    获取    商品细节
        
        public string this[string key1, string key2]
        {
            set
            {
                foreach (string[] good in goods)
                    if (good[0] == key1)
                    {
                        int i = 0;
                        for (; i < keysOfGoodDetail.Length; i++)
                            if (key2 == keysOfGoodDetail[i])
                                break;
                        if (i >= 2) return;
                        good[i] = value.ToString();
                    }
            }
            get
            {
                foreach (string[] good in goods)
                    if (good[0] == key1)
                    {
                        int i = 0;
                        for (; i < keysOfGoodDetail.Length; i++)
                            if (key2 == keysOfGoodDetail[i])
                                break;
                        if (i == 3) return null;
                        return good[i];
                    }
                return null;
            }
        }                                //通过    商品名称    与      Price或Barcode     获取/修改      价格      或      二维码    //应使用Dictionary或Hashtable，但是忘记了

        public string GetInformation(string key1, string key2)
        {
            foreach (string[] good in goods)
                if (good[0] == key1)
                {
                    int i = 0;
                    for (; i < keysOfGoodDetail.Length; i++)
                        if (key2 == keysOfGoodDetail[i])
                            break;
                    if (i == 3) return null;
                    return good[i];
                }
            return null;
        }                      //通过    商品名称    与      Price或Barcode     获取      价格      或      二维码
    }

    [Serializable]
    public class OrderService
    {
        private List<Order> list;                                                       //订单

        public List<Order> List
        {
            set { list = value; }
            get { return list; }
        }

        static XmlSerializer xmlserList = new XmlSerializer(typeof(List<Order>));       //XmlSerializer

        static string xmlFileNameList = "OrderServiceList.xml";                         //xml文件

        public OrderService()
        {
            list = new List<Order>();
        }                                                        //构造

        public void AddOrder(Order order)
        {
            list.Add(order);
        }                                            //添加订单

        public bool DeleteOrder(string id)
        {
            foreach (Order order in list)
                if (order.ID == id)
                {
                    list.Remove(order);
                    return true;
                }
            return false;
            //throw new DefaultInfluenceOrder("删除失败!");
        }                                           //删除订单

        public Order SearchOrderByID(string id)
        {           
            foreach (Order order in this.list)
                if (order.ID == id)
                    return order;

            return null;
        }                                      //通过ID获得订单

        public List<Order> SearchOrderByGood(string good)
        {
            List<Order> list = new List<Order>();

            foreach (Order order in this.list)
                if (order.Good == good)
                    list.Add(order);

            return list;
        }                            //通过商品名称获得订单

        public List<Order> SearchOrderLinqByGood(string good)
        {
            List<Order> list = new List<Order>();

            list = this.list
                .Where(order => order.Good == good)
                .Select(order => order)
                .ToList();

            //list.Add(
            //    this.list
            //    .Where(order => order.Good == good)
            //    .Select(order => order)
            //    .ToList());

            return list;
        }                        //通过商品名称获得订单

        public List<Order> SearchOrderLinqByClient(string client)
        {
            List<Order> list = new List<Order>();

            list = this.list
                .Where(order => order.Client == client)
                .Select(order => order)
                .ToList();

            return list;
        }                    //通过顾客称获得订单

        public List<Order> SearchOrderByTwoKeys(string key1, string key2)               //查找
        {
            List<Order> list = new List<Order>();

            if(key1 == "Client")
            {
                list = SearchOrderLinqByClient(key2);
            }
            else if(key1 == "Good")
            {
                list = SearchOrderLinqByGood(key2);
            }
            else if(key1 == "ID")
            {
                Order order = SearchOrderByID(key2);
                list.Add(order);
            }
            else
            {

            }
            return list;
        }

        public int[] SearchOrderBySettingVisible(string key1, string key2)              //运用BitArray来设置可见不可见
        {
            BitArray bit = new BitArray(this.list.Count);
            int i = 0;

            if (key1 == "Client")
            {
                foreach(Order order in list)
                {
                    if(order.Client == key2)
                    {
                        bit.Bits[i] = 1;
                    }
                    else
                    {
                        bit.Bits[i] = 0;
                    }
                    i++;
                }
                i = 0;
            }
            else if (key1 == "Good")
            {
                foreach (Order order in list)
                {
                    if (order.Good == key2)
                    {
                        bit.Bits[i] = 1;
                    }
                    else
                    {
                        bit.Bits[i] = 0;
                    }
                    i++;
                }
                i = 0;
            }
            else if(key1 == "ID")
            {
                foreach (Order order in list)
                {
                    if (order.ID == key2)
                    {
                        bit.Bits[i] = 1;
                    }
                    else
                    {
                        bit.Bits[i] = 0;
                    }
                    i++;
                }
                i = 0;
            }
            else
            {

            }

            return bit.Bits;
        }

        public bool AddNewOrder(string key1, string key2, string key3)                  //增加新的订单
        {
            Order order = new Order(key1, Int32.Parse(key2), key3);
            return true;
        }

        public bool ChangeOrderByTempOrder(Order order)                                 //修改订单
        {
            int i = 0;
            for (; i < list.Count; i++)
                if (list[i].ID == order.ID)
                    break;
            if (i >= list.Count)
                return false;
            list[i].Good = order.Good;
            list[i].Num = order.Num;

            return true;
        }

        public void ChangeClient(Order order, string key)                               //修改买家，防止先选物品在填写名字
        {
            order.Client = key;
        }

        public bool ChangeOrder(string id, int newNum)
        {           
            Order order = new Order();
            order = SearchOrderByID(id);
            order.Num = newNum;

            if(newNum == 0)
            {
                DeleteOrder(id);
            }

            return true;
        }                               //改变购买商品的数量

        public bool DisplayOrderList()
        {
            if(list.Count > 0)
            {
                Console.WriteLine("No\tName\tPrice\tCount\tID\t\t\tTotal\tClient\n");
                for (int i = 0; i < list.Count; i++)
                    Console.WriteLine((i + 1).ToString() + "\t" + list[i].Good + "\t" + list[i].Detail[list[i].Good, "Price"] + "\t" + list[i].Num + "\t" + list[i].ID + "\t" + (Int32.Parse(list[i].Detail[list[i].Good, "Price"]) * list[i].Num).ToString() + "\t" + list[i].Client + "\n");
                return true;
            }
            else
            {
                return false;
                //throw new DefaultInfluenceOrder("订单为空!");
            }
        }                                               //展示订单

        public static bool DisplayList(List<Order> list)
        {
            if(list.Count > 0)
            {
                Console.WriteLine("No\tName\tPrice\tCount\tID\t\t\tTotal\tClient\n");
                for (int i = 0; i < list.Count; i++)
                    Console.WriteLine((i + 1).ToString() + "\t" + list[i].Good + "\t" + list[i].Detail[list[i].Good, "Price"] + "\t" + list[i].Num + "\t" + list[i].ID + "\t" + (Int32.Parse(list[i].Detail[list[i].Good, "Price"]) * list[i].Num).ToString() + "\t" + list[i].Client + "\n");
                return true;
            }
            else
            {
                return false;
                //throw new DefaultInfluenceOrder("订单为空，展示失败！");
            }
        }                             //展示List<Order>

        public void ExportList()
        {
            FileStream fs = new FileStream(xmlFileNameList, FileMode.Create);
            xmlserList.Serialize(fs, list);
            fs.Close();

            string xml = File.ReadAllText(xmlFileNameList);
            Console.WriteLine(xml);
        }                                                     //转为xml文件     typeof(List<Order>)

        public List<Order> ImportList()
        {
            List<Order> listImport = new List<Order>();
            FileStream fs = new FileStream(xmlFileNameList, FileMode.Open);

            listImport = xmlserList.Deserialize(fs) as List<Order>;

            fs.Close();

            return listImport;
        }                                              //转为List<Order>

        ////typeof(Order)，失败
        //static XmlSerializer xmlser = new XmlSerializer(typeof(Order));                 //XmlSerializer
        //static string xmlFileName = "OrderService.xml";                                 //xml文件
        //public void Export()
        //{
        //    FileStream fs = new FileStream(xmlFileName, FileMode.Create);
        //    foreach (Order order in list)
        //        xmlser.Serialize(fs, order);
        //    fs.Close();

        //    string xml = File.ReadAllText(xmlFileName);
        //    Console.WriteLine(xml);
        //}
        //public List<Order> Import()
        //{
        //    //List<Order> listImport = new List<Order>();
        //    //FileStream fs = new FileStream(xmlFileName, FileMode.Open);

        //    ////Order[] order = xmlser.Deserialize(fs) as Order[];

        //    ////foreach(Order o in order)
        //    ////    listImport.Add(o);

        //    //return listImport;

        //    return null;
        //}

    }

    public class BitArray
    {
        int[] bits;
        int length;

        public BitArray(int length)
        {
            if (length < 0) throw new ArgumentException();
            this.length = length;
            bits = new int[length];
        }

        public int Length
        {
            get { return length; }
        }
        public int[] Bits
        { get { return bits; } }
    }
}

public class DefaultInfluenceOrder : ApplicationException
{
    public DefaultInfluenceOrder(string message)
        : base(message)
    {

    }
}