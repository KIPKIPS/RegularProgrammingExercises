using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._129_加法运算替代 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(calc(10, 2, 1));
            Console.ReadLine();
        }
        public static int calc(int a, int b, int type) {
            // write code here
            switch (type) {
                case 1:
                    int add = 0;
                    int big;
                    int small;
                    if (a>=b) {
                        big = a;
                        small = b;
                    }
                    else {
                        big = b;
                        small = a;
                    }
                    for (int i = 0; i < small; i++) {
                        add += big;
                    }
                    return add;
                case 0:
                    int minus = 0;
                    while (a>0) {
                        a -= b;
                        minus++;
                    }

                    return minus-1;
                case -1:
                    return a + (~b) + 1;
            }

            return 0;
        }
    }
}
