using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 最大公约数和最小公倍数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数:");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("最大公约数为: "+ GreatestCommonDivisor(m,n));
            Console.WriteLine();
            Console.WriteLine("最小公倍数为: " + LeastCommonMultiple(m, n));
            Console.ReadLine();
        }
        //最小公倍数
        public static int LeastCommonMultiple(int m, int n)
        {
            bool isNoFound = true;
            int i = 1;
            int result=1;
            while (isNoFound)
            {
                i++;
                if (i % m == 0 && i % n == 0)
                {
                    result=i;
                    isNoFound = false;
                }
            }
            return result;
        }

        //最大公约数
            public static int GreatestCommonDivisor(int m, int n)
        {
            int num=1;
            if (m > n)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (m % i == 0 && n % i == 0)
                    {
                        num = i;
                    }
                }
            }
            else
            {
                for (int i = 1; i <= m; i++)
                {
                    if (m % i == 0 && n % i == 0)
                    {
                        num = i;
                    }
                }
            }
            return num;
        }
    }
}
