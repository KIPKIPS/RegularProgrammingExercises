using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100可3不可5
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                    count++;
                    
                }
            }
            Console.WriteLine("100以内一共"+count+"个可以被三整除不能被五整除的数");
            Console.ReadLine();
        }
    }
}
