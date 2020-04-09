using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cayley_Tree
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        double leng { get; set; }
        double per1 { get; set; }
        double per2 { get; set; }
        double th1;
        double th2;
        int n { get; set; }
        double m { get; set; }
        double x { get; set; }
        public Pen drawColor { get; set; }



        private void TextDepth_TextChanged(object sender, EventArgs e)
        {
          /*  n = int.Parse(TextDepth.Text);*/
        }

        private void TextLength_TextChanged(object sender, EventArgs e)
        {
           /* leng = double.Parse(TextLength.Text);*/
        }

        private void TextPer1_TextChanged(object sender, EventArgs e)
        {
           /* per1 = double.Parse(TextPer1.Text);*/
        }

        private void TextPer2_TextChanged(object sender, EventArgs e)
        {
           /* per2 = double.Parse(TextPer2.Text);*/
        }

        private void TextTh1_TextChanged(object sender, EventArgs e)
        {
            /*m = double.Parse(TextTh1.Text);*/

        }

        private void TextTh2_TextChanged(object sender, EventArgs e)
        {
            /*x = double.Parse(TextTh2.Text);*/

        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            /*if (Convert.ToString(comboBoxColor.SelectedItem) == "Red")
              {
                  drawColor = Pens.Red;
              }
              if (Convert.ToString(comboBoxColor.SelectedItem) == "Blue")
              {
                  drawColor = Pens.Blue;
              }
              if (Convert.ToString(comboBoxColor.SelectedItem) == "Black")
              {
                  drawColor = Pens.Black;
              }
              if (Convert.ToString(comboBoxColor.SelectedItem) == "Purple")
              {
                  drawColor = Pens.Purple;
              }*/
            /*  Pen[] pens = { Pens.Red, Pens.Blue, Pens.Black, Pens.Purple };
              comboBoxColor.DataSource = pens;
              comboBoxColor.DisplayMember = "Color";*/
        }
        void drawCalayTree(int n, double x0, double y0, double len, double th)
        {
            
            
            /*th1 = this.m * Math.PI / 180;
            th2 = this.x * Math.PI / 180;*/
            if (n == 0) return;
            double x1 = x0 + len * Math.Cos(th);
            double y1 = y0 + len * Math.Sin(th);
            
            graphics.DrawLine(drawColor,
          (int)x0, (int)y0, (int)x1, (int)y1);
            drawCalayTree(n - 1, x1, y1, this.per1 * len, th + this.m * Math.PI / 180);
            drawCalayTree(n - 1, x1, y1, this.per2 * len, th - this.x * Math.PI / 180);
        }
        private Graphics graphics;
        

        private void button_Click(object sender, EventArgs e)
        {
            if (graphics == null)
                graphics = this.panel1.CreateGraphics();
            graphics.Clear(panel1.BackColor);
            drawCalayTree(this.n, panel1.Width / 2, panel1.Height - 20, this.leng, -Math.PI / 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           m = 30; x= 20; per1 = 0.6; per2 = 0.7; leng = 100; n = 10;
            drawColor = Pens.Red;
            comboBoxColor.Items.Add(Pens.Black);
            comboBoxColor.Items.Add(Pens.Red);
            comboBoxColor.Items.Add(Pens.Blue);
            comboBoxColor.Items.Add(Pens.Purple);

            comboBoxColor.DisplayMember = "Color";
           comboBoxColor.DataBindings.Add("SelectedItem", this, "drawColor");

            TextTh1.DataBindings.Add("Text", this, "m");
            TextTh2.DataBindings.Add("Text", this, "x");
            TextPer1.DataBindings.Add("Text", this, "Per1");
            TextPer2.DataBindings.Add("Text", this, "Per2");
            TextLength.DataBindings.Add("Text", this, "Leng");
            TextDepth.DataBindings.Add("Text", this, "n");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
