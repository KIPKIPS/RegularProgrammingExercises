using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000以内素数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1000以内的素数为：");
            for (int i=2;i<1001;i++)
            {
                bool isPrime = true;
                for(int j = 2; j < i; j++)
                {
                    if(i%j==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i+" ");
                }
            }
            Console.ReadLine();
        }
    }
}
