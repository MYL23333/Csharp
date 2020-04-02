using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderS
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OrderItem apple = new OrderItem(1, "apple", 10.0, 80);
                OrderItem egg = new OrderItem(2, "eggs", 1.2, 200);
                OrderItem milk = new OrderItem(3, "milk", 50, 10);

                Order order1 = new Order(1, "Customer1", new List<OrderItem> { apple, egg, milk });
                Order order2 = new Order(2, "Customer2", new List<OrderItem> { egg, milk });
                Order order3 = new Order(3, "Customer2", new List<OrderItem> { apple, milk });

                OrderService os = new OrderService();
                os.CreateOrder(order1);
                os.CreateOrder(order2);
                os.CreateOrder(order3);
                os.Export(@"./orders.xml");

               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

        }
    }
}
