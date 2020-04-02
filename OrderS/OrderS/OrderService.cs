using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.IO;


namespace OrderS
{
   public class OrderService
    {
        public List<Order> Orders
        {
            get => orders;
        }
        private List<Order> orders1;
        public string Client { set; get; }
        public string ProductName { set; get; }
        public int OrderNumber { set; get; }
        public void CreateOrder(Order order)
        {
            
            orders.Add(order);
        }
        private List<Order> orders = new List<Order>();

        List<OrderService> OrderLists = new List<OrderService>();
        public Order GetOrder(uint id)
        {
            return orders.Where(o => o.OrderNumber == id).FirstOrDefault();
        }
        public List<Order> QueryOrdersByGoodsName(string goodsName)
        {
            var query = orders
                    .Where(order => order.Items.Exists(item => item.ProductName == goodsName))
                    .OrderBy(o => o.TotalPrice);
            return query.ToList();
        }

        public List<Order> QueryOrdersByCustomerName(string customerName)
        {
            return orders
                .Where(order => order.Client == customerName)
                .OrderBy(o => o.TotalPrice)
                .ToList();
        }
        public void Export(String fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, orders1);
            }
        }

        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                temp.ForEach(order =>
                {
                    if (!orders.Contains(order))
                    {
                        orders.Add(order);
                    }
                });
            }
        }
    }
}

