using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._077_求整数阶乘 {
    class Program {
        static void Main(string[] args) {
            int num = Convert.ToInt32(Console.ReadLine());
            long res = 1;
            for (long i = num; i >=1; i--) {
                res *= i;
                //Console.WriteLine("res"+res+"num"+num);
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
