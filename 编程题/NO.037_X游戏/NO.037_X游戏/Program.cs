using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._037_X游戏 {
    class Program {
        static void Main(string[] args) {
            int N = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= N; i++) {
                if (IsGoodNum(i)) {
                    count++;
                }
            }
            Console.WriteLine(count);
            //Console.WriteLine(IsGoodNum(101));
            Console.ReadLine();
        }

        public static bool IsGoodNum(int num) {
            string str = num.ToString();
            char[] temp = new char[str.Length];//旋转后的字符数组
            str.CopyTo(0, temp, 0, temp.Length);
            for (int i = 0; i < temp.Length; i++) {
                if (str[i] == '3' || str[i] == '4' || str[i] == '7') {
                    return false;
                }
                else {
                    if (temp[i] == '2') {
                        temp[i] = '5';
                        continue;
                    }
                    if (temp[i] == '5') {
                        temp[i] = '2';
                        continue;
                    }
                    if (temp[i] == '6') {
                        temp[i] = '9';
                        continue;
                    }
                    if (temp[i] == '9') {
                        temp[i] = '6';
                        continue;
                    }
                }
            }
            string res = "";
            for (int i = 0; i < temp.Length; i++) {
                res += temp[i] + "";
            }
            //Console.WriteLine(res);
            if (num == Convert.ToInt32(res)) {
                return false;
            }
            return true;
        }
    }
}
