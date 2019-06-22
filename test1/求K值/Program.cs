using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 求K值
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOk = true;
            int sum = 0;
            int k = 1;
            while (isOk)
            {
                sum += k * k;
                
                if (sum >= 2000)
                {
                    break;
                }
                k++;
            }

            sum = sum - k * k;

            Console.WriteLine("满足条件的最小K值为: "+(k-1)+",他们的和为: "+sum);
            Console.ReadLine();
        }
    }
}
