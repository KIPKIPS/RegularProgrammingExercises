using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习4
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 101; i++)
            {
                Console.WriteLine(i + "的平方为：" + i * i);
                Console.WriteLine(i + "的平方根为：" + Math.Sqrt(i));
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}