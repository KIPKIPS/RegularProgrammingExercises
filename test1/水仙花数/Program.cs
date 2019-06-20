using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 水仙花数
{
    class Program
    {
        static void Main(string[] args)
        {
            //找出1到999的水仙花数
            for(int i = 1; i < 1000; i++)
            {
                if (i >= 1 && i <= 9)
                {
                    if (i == i * i * i)
                    {
                        Console.WriteLine(i + " 是水仙花数");
                    }
                }
                if (i > 9 && i < 100)
                {
                    if((i%10)*(i % 10)* (i % 10)+(i/10)* (i / 10)* (i / 10) == i)
                    {
                        Console.WriteLine(i + " 是水仙花数");
                    }
                }
                if (i > 99 && i < 1000)
                {
                    if ((i % 10) * (i % 10) * (i % 10)+((i / 10) % 10) * ((i / 10) % 10) * ((i / 10) % 10) + (i / 100) * (i / 100) * (i / 100) == i)
                    {
                        Console.WriteLine(i + " 是水仙花数");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
