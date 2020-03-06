using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var s = new int[6];
                for (int index = 0; index < s.Length; index++)
                {
                    System.Console.WriteLine(string.Format("请输入第{0}个数", index + 1));
                    var sStr = System.Console.ReadLine();
                    s[index] = Convert.ToInt32(sStr);
                }
                Console.WriteLine("这个数组为：" + s[0] + s[1] + s[2] + s[3] + s[4] + s[5]);
                Console.WriteLine("这个数组最小值为：" + s.Min());
                Console.WriteLine("这个数组最大值为：" + s.Max());
                Console.WriteLine("这个数组平均值为：" + s.Average());
                int sum = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    sum = sum + s[i];
                }
                Console.WriteLine("这个数组所有元素和为：" + sum);
            }
            catch(FormatException)
            {
                Console.WriteLine("输入格式不正确！请重新输入！");
            }

        }
    }
}
