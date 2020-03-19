using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 斐波那契数列 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Fibonacci(7));
            Console.ReadLine();
        }
        public static int Fibonacci(int n) {
            // write code here
            int f0 = 0;
            int f1 = 1;
            if (n < 2) {
                if (n == 0) {
                    return f0;
                }

                if (n == 1) {
                    return f1;
                }
            }
            else {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }

            return -1;
        }
    }
}
