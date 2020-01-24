using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NO._141_最接近的数 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(getCloseNumber(21)[0]+" "+getCloseNumber(21)[1]);
            //Console.WriteLine(ToBinary(76351));
            Console.ReadLine();
        }
        public static int[] getCloseNumber(int x) {
            // write code here
            int[] a = new int[2];
            int xCount = theNumberOfOne(x);
            int m = x;
            while (true) {
                m--;
                if (theNumberOfOne(m) == xCount) {
                    a[0] = m;
                    break;
                }
            }
            m = x;
            while (true) {
                m++;
                if (theNumberOfOne(m) == xCount) {
                    a[1] = m;
                    break;
                }
            }

            return a;
        }
        public static int theNumberOfOne(int n) {
            List<int> binary = new List<int>();
            string s = Convert.ToString(n, 2);

            for (int i = 0; i < s.Length; i++)
                binary.Add(s[i] - 48);
            int count = binary.Count(delegate (int item) { return item == 1; });
            return count;
        }

        //十进制转二进制
        public static string ToBinary(int num) {
            string res = "";
            while (num!=0) {
                res = (num % 2) + res;
                num = num / 2;
            }
            return res;
        }
        //二进制转十进制
        public static int ToDecimalism(string binary) {
            int res = 0;
            for (int i = 0; i < binary.Length; i++) {
                res+=int.Parse(binary[i]+"") * (int)Math.Pow(2, binary.Length - i - 1);
            }
            return res;
        }
    }
}
