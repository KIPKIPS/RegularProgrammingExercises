using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f_n__f_n_1__f_n_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] f = new int[41];
            f[0] = 2;
            f[1] = 3;
            for (int i = 2; i <= 40; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
                
            }
            Console.Write(f[40]);
            Console.ReadLine();
;
        }
    }
}
