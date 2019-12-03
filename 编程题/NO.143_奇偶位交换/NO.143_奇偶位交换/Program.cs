using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NO._143_奇偶位交换 {
    class Program<T> {
        static void Main(string[] args) {
            Console.WriteLine(exchangeOddEven(5));
            Console.ReadLine();
        }
        public static int exchangeOddEven(int x) {
            //格式化二进制数据
            string binary = ToBinary(x).Length % 2 == 0 ? ToBinary(x) : "0" + ToBinary(x);
            string resStr = "";
            //奇偶位置对换,迭代量为2
            for (int i = 0; i < binary.Length; i += 2) {
                resStr += binary[i + 1] + "" + binary[i] + "";
            }
            return ToDecimalism(resStr);
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
            //计算二进制每一位的十进制数值,循环相加
            for (int i = 0; i < binary.Length; i++) {
                res += int.Parse(binary[i] + "") * (int)Math.Pow(2, binary.Length - i - 1);
            }
            return res;
        }
    }
}
