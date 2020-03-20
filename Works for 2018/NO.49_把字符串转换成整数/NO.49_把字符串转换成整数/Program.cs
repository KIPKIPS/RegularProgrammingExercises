using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._49_把字符串转换成整数 {
    class Program {
        static void Main(string[] args) {
            Program x=new Program();
            Console.WriteLine(x.StrToInt("-2340a"));
            //Console.WriteLine('2'-48);
            Console.ReadLine();
        }
        public int StrToInt(string str) {
            // write code here
            if (str.Length==0) {
                return 0;
            }
            for (int i = 1; i < str.Length; i++) {
                if ((str[i] < 48|| str[i] > 57)){
                    return 0;
                }
            }
            int res = 0;
            if ( str[0] == 43 || str[0] == 45) {
                
                //加号
                if (str[0] == 43) {
                    for (int i = 1; i < str.Length; i++) {
                        res += (str[i] - 48) * (int)Math.Pow(10, str.Length - i - 1);
                    }
                }
                //减号
                if (str[0] == 45) {
                    for (int i = 1; i < str.Length; i++) {
                        res += (str[i] - 48) * (int)Math.Pow(10, str.Length - i - 1);
                    }
                    res = -res;
                }
                return res;
            }

            if (str[0] >=48 || str[0] <=57) {
                for (int i = 0; i < str.Length; i++) {
                    res += (str[i] - 48) * (int)Math.Pow(10, str.Length - i - 1);
                }
                return res;
            }
            return 0;

        }
    }
}
