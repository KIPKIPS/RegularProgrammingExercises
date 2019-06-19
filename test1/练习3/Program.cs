using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;
            for(int i = 1; i < 1001; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                    count++;
                    if (count == 5)
                    {
                        Console.WriteLine(sum);
                        count = 0;
                        sum = 0;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
