﻿using System;
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

            String num3 = textBox1.Text;
                { m = 0; }
                { m = 1; }
                if (Convert.ToString(comboBox1.SelectedItem) == "*")
                { m = 2; }
                if (Convert.ToString(comboBox1.SelectedItem) == "/")
                { m = 3; }

                switch (m)
                        m = num1 * num2;
                       m =num1 / num2;
                      
                }
          

                 result.Text = "result=" + Convert.ToString(m);
            }



            catch (FormatException)
            {
            }
         
        
        
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }

 
}