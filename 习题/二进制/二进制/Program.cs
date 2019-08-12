using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 二进制 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine(NumberOf1(0));
            Console.ReadLine();

        }
        public static int NumberOf1(int n) {
            int count = 0;
            for (int i = 0; i < Fun(n).Count; i++) {
                if (Fun(n)[i]==1) {
                    count++;
                }
            }
            return count;
        }

        public static List<int> Fun(int n) {
            List<int> a = new List<int>();
            int re;
            if (n >= 2) {
                while (true) {
                    re = n % 2;
                    n /= 2;
                    a.Add(re);
                    if (n == 1) {
                        a.Add(1);
                        break;
                    }
                }
            }
            else {
                if (n==0) {
                    a.Add(0);
                }

                if (n==1) {
                    a.Add(1);
                }
            }
            
            return a;
        }
    }
}
