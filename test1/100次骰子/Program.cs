using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100次骰子
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0;
            Random a = new Random();
            Console.WriteLine("一百次随机掷骰子的结果为:");
            for(int x = 0; x < 100; x++)
            {
                int i = a.Next(1,7);
                Console.Write(i+" ");
                switch (i)
                {
                    case 1:
                        num1++;
                        break;
                    case 2:
                        num2++;
                        break;
                    case 3:
                        num3++;
                        break;
                    case 4:
                        num4++;
                        break;
                    case 5:
                        num5++;
                        break;
                    case 6:
                        num6++;
                        break;
                }
            }
            Console.WriteLine("");
           Console.WriteLine("结果为1有：" + num1+ "次");
            Console.WriteLine("结果为2有：" + num2 + "次");
            Console.WriteLine("结果为3有：" + num3 + "次");
            Console.WriteLine("结果为4有：" + num4 + "次");
            Console.WriteLine("结果为5有：" + num5 + "次");
            Console.WriteLine("结果为6有：" + num6 + "次");
            Console.ReadLine();
        }
    }
}
