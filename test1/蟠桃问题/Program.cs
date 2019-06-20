using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 蟠桃问题
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=1;
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            for(int i = 0; i < num-1; i++)
            {
                sum = (sum + 1) * 2;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
