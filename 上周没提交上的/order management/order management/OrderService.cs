using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order_management
{
    class OrderService
    {
        public string Client { set; get; }
        public string ProductName { set; get; }
        public int OrderNumber { set; get; }
        public void CreateOrder(int ordernumber, string productname, string client)
        {

            OrderNumber = ordernumber;
            ProductName = productname;
            Client = client;
            Order newOrder = new Order();
            orders.Add(newOrder);
        }
        private List<Order> orders = new List<Order>();
       
        List<OrderService> OrderLists = new List<OrderService>();
        public void OrderInquiry()
        {
            Console.Write("你想根据什么来查询？a.OrderNumber b.ProductName c.Client");
            switch (Console.ReadLine())
            {
                case "a":
                    Console.Write("输入订单号：");
                    var query = OrderLists.Where(s => s.OrderNumber == int.Parse(Console.ReadLine()));
                    break;
                case "b":
                    Console.Write("输入商品名称：");
                    var query2 = OrderLists.Where(s => s.ProductName == Console.ReadLine());
                    break;
                case "c":
                    Console.Write("客户名");
                    var query3 = OrderLists.Where(s => s.Client == Console.ReadLine());
                    break;
            }
        }
    }
}
