using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderWF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Order order { get; set; }
        public Order CurrentOrder { get; set; }
        private void Save_Click(object sender, EventArgs e)
        {
            AddOrder(order);
      

        }
        List<Order> orders = new List<Order>();
        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
                throw new ApplicationException($"Add Order Error: Order with id {order.OrderId} already exists!");
            orders.Add(order);
        }

        public void Form2_Load(object sender, EventArgs e)
    {

            CurrentOrder = order;
            orderBindingSource.DataSource = CurrentOrder;

        }

    }
}
