using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderS
{
  public  class OrderItem
    {
        private double Price { get; set; }
        public string ProductName { get; set; }
        public int SerialNumber { get; set; }
        private int PoductCount { get; set; }
        public double TotalPrice
        {
            get
            {
                return PoductCount * Price;
            }
        }
        public override string ToString()
        {
            return $"[编号:{SerialNumber},商品名称:{ProductName},数量:{PoductCount},总价:{TotalPrice}]";
        }
        public OrderItem(int SerialNumber, string productname, double price, int PoductCount)
        {
            this.SerialNumber = SerialNumber;
            ProductName = productname;
            Price = price;
            this.PoductCount = PoductCount;
        }

    }
}
