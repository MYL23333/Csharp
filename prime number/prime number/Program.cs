using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                String s = "";
                Console.WriteLine("请输入要求素数的整数:");
                s = Console.ReadLine();
                int m = int.Parse(s);
                for (int i = 2; i <= m;)
                {
                    if (m % i == 0 && i != m)
                    {
                        Console.WriteLine(i);
                        m = m / i;
                    }
                    else if (m % i == 0 && i == m)
                    {
                        Console.WriteLine(i);
                        m = m / i;

                    }
                    else i++;
                }
                Console.WriteLine("这个数没有素数");
            }
            catch(FormatException)
            {
                Console.WriteLine("您输入的格式有错误！请输入一个整数！");

            }
           }

        }
    }