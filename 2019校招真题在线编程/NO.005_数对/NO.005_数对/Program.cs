using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._005_数对 {
    class Program {
        long get_num(int n, int k) {
            long num = 0;
            int num1, num2, num3;
            for (int i = k + 1; i <= n; i++) {
                num1 = n / i;
                num2 = i - k;
                num3 = n % i;
                if (num3 < k) {
                    num = num + num1 * num2;
                }
                else num = num + num1 * num2 + num3 - k + 1;
            }
            if (k == 0) { num = num - n; }
            return num;
        }
        static void Main(string[] args) {
            string[] s = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(s[0]);
            int k = Convert.ToInt32(s[1]);
            Program pro = new Program();
            Console.WriteLine(pro.get_num(n, k).ToString());
        }
    }
}
