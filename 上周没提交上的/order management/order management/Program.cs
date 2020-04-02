using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order_management
{
      class Program
    {
        static void Main(string[] args)
        {

            OrderService os = new OrderService();

                Console.WriteLine("a.查询订单，b.创建订单，c.退出系统,你的选择是：");
                string m = Console.ReadLine();
                switch (m)
                {
                    case "a":
                        os.OrderInquiry();
                        break;
                    case "b":
                    Console.WriteLine("请输入订单的订单号，商品名称，客户名：");
                    os.CreateOrder(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
                        break;
                    case "c":
                        return;
                    default:
                        Console.WriteLine("输入不规范，请重新输入。");
                        return;
                }
            }
        }
    }
