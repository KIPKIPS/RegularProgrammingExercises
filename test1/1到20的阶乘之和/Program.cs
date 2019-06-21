using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1到20的阶乘之和
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int temp = 1;
            for (int i = 1; i < 21; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    temp = j * temp;
                }

                sum += temp;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
