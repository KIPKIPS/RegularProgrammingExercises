using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NO._026_最少数量货物装箱问题 {
    class Program {
        static void Main(string[] args) {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsFull(num));
            Console.ReadLine();
        }
        public static int IsFull(int num) {
            int rem = num % 7;
            int n = num / 7 - 1;
            if (num < 7) {
                if (num == 1 || num == 2 || num == 4) {
                    return -1;
                }
                if (num == 3 || num == 5) {
                    return 1;
                }
                if (num == 6) {
                    return 2;
                }
            }
            else {
                switch (rem) {
                    case 0: return n+1;
                    case 1: case 3: case 5: return n + 2;
                    case 2: case 4: case 6: return n + 3;
                }
            }
            return 0;
        }
    }
}
