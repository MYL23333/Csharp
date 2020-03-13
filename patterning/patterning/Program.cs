using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterning
{
    interface Tetragonum
    {
        void Area();
    }
    interface Judge
    {
        void Form();

    }
    class Square : Rectangle
    {

        public override void Form()
        {
            if (Width == Length && Width > 0 && Length > 0)
            {
                Console.Write("该正方形形状合法。");

            }
            else
            {
                Console.Write("该正方形形状不合法。");
            }
        }
        public override void Area()
        {
            if (Width == Length && Width > 0 && Length > 0)
            {
                Console.Write("该正方形面积为：" + Width * Length);
            }
            else return;
        }

    }
    class Rectangle : Tetragonum, Judge
    {
        public Double Length { get; set; }
        public Double Width { get; set; }
        public virtual void Form()
        {
            if (Length != Width && Length != 0 && Width != 0)
            {
                Console.Write("该长方形形状合法。");
            }

            else Console.Write("这个长方形形状不合法。");
        }
        public virtual void Area()
        {
            if (Length != Width && Length > 0 && Width > 0)
            {
                Console.Write("该长方形面积为：" + Width * Length);
            }
            else return;
        }
        class Triangle : Tetragonum, Judge
        {
            public Double Side1 { get; set; }
            public Double Side2 { get; set; }
            public Double Side3 { get; set; }
            public void Form()
            {
                if (Side1 + Side2 > Side3 && Side1 - Side2 < Side3 && Side1 > 0 && Side2 > 0 && Side3 > 0)
                {
                    Console.Write("该三角形形状合法。");
                }

                else Console.Write("这个三角形形状不合法。");
            }
            public void Area()
            {
                double p;
                double h;
                if (Side1 + Side2 > Side3 && Side1 - Side2 < Side3 && Side1 > 0 && Side2 > 0 && Side3 > 0)
                {
                    p = Side1 + Side2 + Side3;
                    h = p / 2;
                    Console.Write("该三角形面积为：" + Math.Sqrt(h * (h - Side1) * (h - Side2) * (h - Side3)));
                }
                else return;
            }
        }
        class Shape : Tetragonum
        {  
            public static int MinNum = 0;
            public static int MaxNum = 4;
            public static Random rd = new Random();
            int i = rd.Next(MinNum, MaxNum + 1);
            public Double SArea;
            public void Area()
            {
                if (i == 0 || i == 1 || i == 2)
                {
                     SArea = 0;
                }
                if (i == 3)
                {
                  Random rd2 = new Random();
                  int Side1 = rd2.Next();
                    int Side2 = rd2.Next();
                    int Side3= rd2.Next();
                    double p;
                    double h;
                    if (Side1 + Side2 > Side3 && Side1 - Side2 < Side3 && Side1 > 0 && Side2 > 0 && Side3 > 0)
                    {
                        p = Side1 + Side2 + Side3;
                        h = p / 2;
                        SArea= Math.Sqrt(h * (h - Side1) * (h - Side2) * (h - Side3));
                    }
                    else SArea=0;
                }
                if(i==4)
                {
                    Random rd3 = new Random();
                    int Sides1 = rd3.Next();
                    int Sides2 = rd3.Next();
                    int Sides3 = rd3.Next();
                    int Sides4 = rd3.Next();
                    if(Sides1==Sides2&&Sides3==Sides4&&Sides1>0&&Sides2>0&&Sides3>=0&&Sides4>=0)
                    {
                        SArea= Sides1 * Sides3;
                    }
                    if(Sides1 == Sides3 && Sides2 == Sides4 && Sides1 > 0 && Sides2 > 0 && Sides3 >= 0 && Sides4 >= 0)
                    {
                        SArea = Sides1 * Sides2;
                    }
                    if (Sides1 == Sides4 && Sides3 == Sides2 && Sides1 > 0 && Sides2 > 0 && Sides3 >= 0 && Sides4 >= 0)
                    {
                        SArea = Sides1 * Sides3;
                    }
                    else SArea = 0; 
                }
                else SArea = 0;
            }

    }

    class Program
        {
            static void Main(string[] args)
            {
                Square Square1 = new Square();
                Square1.Length = 9;
                Square1.Width = 9;
                Square1.Form();
                Square1.Area();
                Rectangle Rectangle1 = new Rectangle();
                Rectangle1.Length = 9;
                Rectangle1.Width = 8;
                Rectangle1.Form();
                Rectangle1.Area();
                Triangle Triangle1 = new Triangle();
                Triangle1.Side1 = 3;
                Triangle1.Side2 = 4;
                Triangle1.Side3 = 5;
                Triangle1.Form();
                Triangle1.Area();
                Shape Shape1 = new Shape();
                Shape Shape2= new Shape();
                Shape Shape3 = new Shape();
                Shape Shape4 = new Shape();
                Shape Shape5 = new Shape();
                Shape Shape6 = new Shape();
                Shape Shape7 = new Shape();
                Shape Shape8 = new Shape();
                Shape Shape9 = new Shape();
                Shape Shape10 = new Shape();
                Console.Write(Shape1.SArea+ Shape2.SArea + Shape3.SArea + Shape4.SArea + Shape5.SArea + Shape6.SArea + Shape7.SArea + Shape8.SArea + Shape9.SArea + Shape10.SArea);


            }
        }
    }
}