using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 兔子繁殖问题
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 1;
            for(int i = 1; i < 21; i++)
            {
               
                if (i % 3 == 0)
                {
                    num *= 2;
                    sum += num;
                }
            }
            Console.WriteLine(sum*2);
            Console.ReadKey();
        }
    }
}
