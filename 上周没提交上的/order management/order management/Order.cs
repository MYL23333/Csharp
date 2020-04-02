using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order_management
{
    class Order
    {
        public string Client { set; get; }
        Random rand = new Random();
        public int OrderNumber
        {

            get { return rand.Next(10000, 19999); }
        }
        private DateTime OrderTime;


        public Order()
        {

            OrderTime = DateTime.Now;
            this.items = new List<OrderItem>();
            this.Client = Client;
            CreateOrderItem();
        }



        private List<OrderItem> items = new List<OrderItem>();

        private bool InsertItem(int SerialNumber, string productname, double price, int PoductCount)
        {
            OrderItem newItem = new OrderItem(SerialNumber, "productname", price, PoductCount);
            items.Add(newItem);
              return true;
        }


        private void CreateOrderItem()
        {

                Console.WriteLine("请输入商品编号，商品名称，价格，数量:");
                InsertItem(Convert.ToInt32(Console.ReadLine()),(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            }

        }
    }
        