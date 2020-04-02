using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;


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
        public void QueryOrdersByGoodsNameTest()
        {
            Order order2 = new Order(2, "Customer2", new List<OrderItem> { egg, milk });
            Order o = orderservice.GetOrder(2);
            Assert.IsNotNull(o);
            Assert.AreEqual(order2, o);
            o = orderservice.GetOrder(4);
            Assert.IsNull(o);
        }
    

        [TestMethod()]
        public void QueryOrdersByCustomerNameTest()
        {
        Assert.AreEqual(2, orderservice.QueryOrdersByGoodsName("apple").Count);
        Assert.AreEqual(2, orderservice.QueryOrdersByGoodsName("egg").Count);
        Assert.AreEqual(3, orderservice.QueryOrdersByGoodsName("milk").Count);
        Assert.AreEqual(0, orderservice.QueryOrdersByGoodsName("orange").Count);
    }

        [TestMethod()]
        public void ExportTest()
        {
            String file = "temp.xml";
            orderservice.Export(file);
            Assert.IsTrue(File.Exists(file));
            List<String> expectLines = File.ReadLines("expectedOrders.xml").ToList();
            List<String> outputLines = File.ReadLines(file).ToList();
            Assert.AreEqual(expectLines.Count, outputLines.Count);
            for (int i = 0; i < expectLines.Count; i++)
            {
                Assert.AreEqual(expectLines[i].Trim(), outputLines[i].Trim());
            }
        }

        [TestMethod()]
        public void ImportTest()
        {
            OrderService os = new OrderService();
            os.Import("./expectedOrders.xml");
            Assert.AreEqual(3, os.Orders.Count);

            os.Import("./newOrders.xml");
            Assert.AreEqual(5, os.Orders.Count);
        }
    }
}