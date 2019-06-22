using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace f_n__f_n_1__f_n_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //普通方法
            int[] f = new int[41];
            f[0] = 2;
            f[1] = 3;
            for (int i = 2; i <= 40; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
                
            }

            //递归方法

            Console.WriteLine("普通方法: "+f[40]);
            Console.WriteLine("递归方法: "+f1(40));
            Console.ReadLine();
;
        }

        static int f1(int n)
        {
            if (n == 0) return 2;
            if (n == 1) return 3;
            return f1(n - 1) + f1(n - 2);
        }
    }
}
