using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void DeleteOrderTest()
        {
            OrderService service = new OrderService();
            Order order = new Order("a", 1, "iPad");
            service.AddOrder(order);

            bool n1 = service.DeleteOrder(order.ID);
            bool n2 = service.DeleteOrder(order.ID);
            bool n3 = service.DeleteOrder("asd");

            Assert.IsTrue(n1);
            Assert.IsFalse(n2);
            Assert.IsFalse(n3);
        }

        [TestMethod()]
        public void DisplayOrderListTest()
        {
            OrderService service = new OrderService();
            Order order = new Order("a", 1, "iPad");
            service.AddOrder(order);

            bool n1 = service.DisplayOrderList();

            bool a = service.DeleteOrder(order.ID);
            bool n2 = service.DisplayOrderList();

            Assert.IsTrue(n1);
            Assert.IsFalse(n2);
        }
    }
}