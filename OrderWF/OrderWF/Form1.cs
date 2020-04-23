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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
           

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {

        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

        }

        private void ImportButton_Click(object sender, EventArgs e)
        {

        }

        private void QuerycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QueryText_TextChanged(object sender, EventArgs e)
        {

        }

        private void QueryButton_Click(object sender, EventArgs e)
        {

        }
        public void Form1_Load(object sender, EventArgs e)
        {
            if (this.QuerycomboBox.Items.Count>0)
            {
                this.QuerycomboBox.Items.Clear();
                this.QuerycomboBox.Items.AddRange(new object[] { "Customer", "GoodsName"});
                QuerycomboBox.Text = "OrederId";
                QuerycomboBox.SelectedIndex = 0;

            }
            if (QuerycomboBox.SelectedItem.ToString() == "GoodsName")
            {
                QueryOrdersByGoodsName( QueryText.Text);
            }
            if (QuerycomboBox.SelectedItem.ToString() == "Customer")
            {
                QueryOrdersByCustomerName(QueryText.Text);
            }


        }
        List<Order> orders = new List<Order>();
        public List<Order> QueryOrdersByGoodsName(string goodsName)
        {
            var query = orders
                    .Where(order => order.Items.Exists(item => item.GoodsName == goodsName))
                    .OrderBy(o => o.TotalPrice);
            return query.ToList();
        }

        public List<Order> QueryOrdersByCustomerName(string customerName)
        {
            return orders
                .Where(order => order.Customer == customerName)
                .OrderBy(o => o.TotalPrice)
                .ToList();
        }
    }
}
