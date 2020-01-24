using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._142_整数转换 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(ToBinary(68794));
            Console.WriteLine(ToBinary(15646));
            Console.ReadLine();
        }
        public int calcCost(int A, int B) {
            // write code here
            string longStr = ToBinary(A).Length>ToBinary(B).Length ? ToBinary(A) : ToBinary(B);
            string shortStr = ToBinary(A).Length <= ToBinary(B).Length ? ToBinary(A) : ToBinary(B);
            int res = 0;
            for (int i =0; i <shortStr.Length; i++) {
                res += longStr[longStr.Length - 1 - i] != shortStr[shortStr.Length - 1 - i] ? 1 : 0;
            }
            int oneNum = 0;
            for (int i = 0; i < longStr.Length-shortStr.Length; i++) {
                oneNum += longStr[i] == '1' ? 1 : 0;
            }
            return res + oneNum;
        }
        //十进制转二进制
        public static string ToBinary(int num) {
            string res = "";
            while (num != 0) {
                res = (num % 2) + res;
                num = num / 2;
            }
            return res;
        }
        //二进制转十进制
        public static int ToDecimalism(string binary) {
            int res = 0;
            for (int i = 0; i < binary.Length; i++) {
                res += int.Parse(binary[i] + "") * (int)Math.Pow(2, binary.Length - i - 1);
            }
            return res;
        }
    }
}
