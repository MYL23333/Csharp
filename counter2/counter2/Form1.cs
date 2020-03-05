using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace counter2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String num3 = textBox1.Text;            String num4 = textBox2.Text;            try            {                double num1 = double.Parse(num3);                double num2 = double.Parse(num4);                double m = 0;                if (Convert.ToString(comboBox1.SelectedItem)=="+")
                { m = 0; }                if (Convert.ToString(comboBox1.SelectedItem) == "-")
                { m = 1; }
                if (Convert.ToString(comboBox1.SelectedItem) == "*")
                { m = 2; }
                if (Convert.ToString(comboBox1.SelectedItem) == "/")
                { m = 3; }

                switch (m)                {                    case 0:                       m=num1+num2;                        break;                    case 1:                        m = num1 - num2;                        break;                    case 2:
                        m = num1 * num2;                        break;                    case 3:                        if (num2 == 0)                        {                            MessageBox.Show("除数不能为0！");                        }
                       m =num1 / num2;                        break;
                      
                }
          

                 result.Text = "result=" + Convert.ToString(m);
            }



            catch (FormatException)
            {                MessageBox.Show("输入格式不正确！");
            }            catch (OverflowException)            {                MessageBox.Show("输入超出数值范围！");            }
         
        
        
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }

 
}
