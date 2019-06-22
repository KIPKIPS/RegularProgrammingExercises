using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for循环实现1到5的平方数输出");
            for(int i = 1; i < 6; i++)
            {
                Console.Write(i * i + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("do while循环实现1到5的平方数输出");
            int j = 1;
            do
            {
                Console.Write(j * j + "  ");
                j++;
            } while (j < 6);
            Console.WriteLine();
            Console.WriteLine("while循环实现1到5的平方数输出");
            int k = 1;
            while (k < 6)
            {
                Console.Write(k*k+"  ");
                k++;
            }
            Console.ReadLine();
        }
    }
}
