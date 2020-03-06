using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace screening
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[199];
            number[0] = 2;
            int k = 2;
            int m = 0;
            while(m<199)
            {
                for (int i = 1; i < number.Length; i++)
                    if (i % k == 0 && i != k)
                        number[i] = 1;
                for(int i=1;i<number.Length;i++)
                    if(i>k&&number[i]==0)
                    {
                        k = i;
                        break;
                    }
                m++;
            }
            for (int i = 1; i < number.Length; i++)
                if (number[i] == 0)
                    Console.WriteLine(i);
        }
    }
}
