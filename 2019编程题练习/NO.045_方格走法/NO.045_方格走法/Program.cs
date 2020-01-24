using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._045_方格走法 {
    class Program {
        static void Main(string[] args) {
            string[] temp = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(temp[0]);
            int y = Convert.ToInt32(temp[1]);
            long op = x > y ? y : x;
            long denominator = 1;//分母
            long numerator = 1;//分子
            for (int i = 0; i < op; i++) {
                numerator *= (x + y - i);
                denominator *= op - i;
            }
            Console.WriteLine(numerator/denominator);
            Console.ReadLine();
        }
    }
}
