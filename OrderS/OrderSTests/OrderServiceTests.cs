using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderS.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService orderservice = new OrderService();
        OrderItem apple = new OrderItem(1, "apple", 10.0, 80);
        OrderItem egg = new OrderItem(2, "egg", 1.2, 200);
        OrderItem milk = new OrderItem(3, "milk", 50, 10);

        [TestInitialize()]
        public void init()
        {
            Order order1 = new Order(1, "Customer1", new List<OrderItem> { apple, egg, milk });
            Order order2 = new Order(2, "Customer2", new List<OrderItem> { egg, milk });
            Order order3 = new Order(3, "Customer2", new List<OrderItem> { apple, milk });
            orderservice = new OrderService();
            orderservice.CreateOrder(order1);
            orderservice.CreateOrder(order2);
            orderservice.CreateOrder(order3);
        }
        [TestMethod()]
        public void CreateOrderTest()
        {
            Order order4 = new Order(4, "Customer2", new List<OrderItem> { milk });
            orderservice.CreateOrder(order4);
            Assert.AreEqual(4, orderservice.Orders.Count);
            CollectionAssert.Contains(orderservice.Orders, order4);
        }

        [TestMethod()]
        public void OrderInquiryTest()
        {
            Order order2 = new Order(2, "Customer2", new List<OrderItem> { egg, milk });
            Order o = orderservice.GetOrder(2);
            Assert.IsNotNull(o);
            Assert.AreEqual(order2, o);
            o = orderservice.GetOrder(4);
            Assert.IsNull(o);
        }

        [TestMethod()]
        public void ExportTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ImportTest()
        {
            Assert.Fail();
        }
    }
}