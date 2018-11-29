using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Collections;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;


namespace Program0
{
    public class Text
    {
        static void Main()
        {
            OrderService service = new OrderService();
            //orderService.Delete("001");

            List<OrderDetail> goods = new List<OrderDetail>() {
                new OrderDetail("1", "iPhone", 20),
                new OrderDetail("2", "iPad", 100)
            };

            //Order order = new Order("cc", "15827082200", goods);
            //service.Add(order);

            Order order2 = new Order("ccc", "15827082200", goods);
            service.Update(order2);


            List<Order> orders = service.QueryByClient("ccc");
            orders.ForEach(
              o => Console.WriteLine($"{o.ID},{o.Client}"));

            Console.WriteLine("Succeed!");
            Console.ReadLine();
        }
    }

    public class Order
    {
        static int IDSuffix = 100;

        [Key]
        private string id;
        private string client;
        private string tel;
        private List<OrderDetail> goods;

        public string ID
        {
            set => id = value;
            get => id;
        }
        public string Client
        {
            set => client = value;
            get => client;
        }
        public string Tel
        {
            get => tel;
            set => tel = value;
        }
        public List<OrderDetail> Goods
        {
            get => goods;
            set => goods = value;
        }

        public Order()
        {
            Goods = new List<OrderDetail>();
        }
        public Order(string client, string tel, List<OrderDetail> goods)
        {
            this.ID = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + (IDSuffix++).ToString();
            this.Client = client;
            this.Tel = tel;
            this.Goods = goods;
        }
    }

    public class OrderDetail
    {
        Hashtable shopping;
        //Dictionary<string, int> shopping = new Dictionary<string, int>();

        [Key]
        private string id;
        private string good;
        private int price;
        private int count;

        public string ID
        {
            set => id = value;
            get => id;
        }
        public string Good
        {
            set => good = value;
            get => good;
        }
        public int Price
        {
            set => price = value;
            get => price;
        }
        public int Count
        {
            set => count = value;
            get => count;
        }
        public int Total
        {
            get => price * count;
        }

        public OrderDetail() { }
        public OrderDetail(string id, string good, int count)
        {
            if (initShopping() && shopping.ContainsKey(good))
            {
                this.ID = id;
                this.Good = good;
                this.Count = count;
                this.Price = (int)shopping[good];
            }
        }

        private bool initShopping()
        {
            shopping = new Hashtable();
            shopping["iPhone"] = 6999;
            shopping["iPad"] = 10899;
            shopping["XiaoMi"] = 2999;
            shopping["Huawei"] = 2999;
            return true;
        }
    }

    [Serializable]
    public class OrderService
    {
        static XmlSerializer xmlserList;
        static string xmlFileName = "../../OrderServiceList.xml";

        private List<Order> list;
        public List<Order> List
        {
            set => list = value;
            get => list;
        }

        public OrderService()
        {
            list = new List<Order>();
            xmlserList = new XmlSerializer(typeof(List<Order>));
        }

        public bool AddOrder(Order order)
        {
            list.Add(order);
            return true;
        }
        public bool DelOrder(string id)
        {
            foreach (Order o in list)
                if (o.ID == id)
                {
                    list.Remove(o);
                    return true;
                }
            return false;
        }
        public bool ChangeOrder(Order order)
        {
            int i = 0;
            for (; i < list.Count; i++)
                if (list[i].ID == order.ID)
                    break;
            if (i < list.Count)
            {
                list[i].Client = order.Client;
                list[i].Tel = order.Tel;
                list[i].Goods = order.Goods;
                return true;
            }
            return false;
        }
        public bool ChangeOrder(string id, string client, string tel, List<OrderDetail> goods)
        {
            foreach (Order o in list)
                if (o.ID == id)
                {
                    o.Client = client;
                    o.Tel = tel;
                    o.Goods = goods;
                    return true;
                }
            return false;
        }

        public List<Order> SearchOrderByID(string id)
        {
            List<Order> list = new List<Order>();

            list = this.list
                .Where(order => order.ID == id)
                .Select(order => order)
                .ToList();

            return list;
        }
        public List<Order> SearchOrderByClient(string client)
        {
            List<Order> list = new List<Order>();

            list = this.list
                .Where(order => order.Client == client)
                .Select(order => order)
                .ToList();

            return list;
        }

        public void Add(Order order)
        {
            using (var db = new OrderDB())
            {
                db.Order.Add(order);
                //db.Order.Attach(order);
                //db.Entry(order).State = EntityState.Added;

                db.SaveChanges();
            }
        }
        public void Delete(String id)
        {
            using (var db = new OrderDB())
            {
                var order = db.Order.Include("Goods").SingleOrDefault(o => o.ID == id);
                db.OrderItem.RemoveRange(order.Goods);
                db.Order.Remove(order);
                db.SaveChanges();
            }
        }
        public void Update(Order order)
        {
            using (var db = new OrderDB())
            {
                db.Order.Attach(order);
                db.Entry(order).State = EntityState.Modified;
                order.Goods.ForEach(
                    good => db.Entry(good).State = EntityState.Modified);
                db.SaveChanges();
            }
        }
        public Order GetOrder(String id)
        {
            using (var db = new OrderDB())
            {
                return db.Order.Include("Goods").
                  SingleOrDefault(o => o.ID == id);
            }
        }
        public List<Order> GetAllOrders()
        {
            using (var db = new OrderDB())
            {
                return db.Order.Include("goods").ToList<Order>();
            }
        }
        public List<Order> QueryByClient(String client)
        {
            using (var db = new OrderDB())
            {
                return db.Order.Include("goods")
                  .Where(o => o.Client.Equals(client))
                  .Select(o => o)
                  .ToList();
            }
        }

    }

    public class OrderDB : DbContext
    {
        public OrderDB() : base("OrderDataBase") { }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderItem { get; set; }
    }
}