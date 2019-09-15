using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._073_求数列第n项 {
    class Program {
        static void Main(string[] args) {

            long index;
            long.TryParse(Console.ReadLine(), out index);
            if (index==1||index==0) {
                Console.WriteLine(0);
            }
            else {
                long sum = 0;
                for (int i = 1; ; i++) {
                    sum += fib(i);
                    if (sum <= index && index <= sum + fib(i + 1)) {
                        Console.WriteLine(sum);
                        break;
                    }
                }
            }
            Console.ReadLine();
        }

        public static int fib(int i) {
            int[]fib=new int[i+1];
            fib[0] = fib[1] = 1;
            if (i>=2) {
                for (int j = 2; j < i; j++) {
                    fib[j] = fib[j - 1] + fib[j - 2];
                }
                return fib[i-1];
            }
            else {
                return fib[i];
            }
            
        }
    }
}
