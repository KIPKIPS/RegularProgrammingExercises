using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._105_字符串价值 {
    class Program {
        static void Main(string[] args) {
            string str = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            int[]dic=new int[26];
            for (int i = 0; i < str.Length; i++) {
                dic[str[i] - 97] ++;
            }

            int res = 0;
            if (k<dic.Max()) {
                for (int i = 0; i < dic.Length; i++) {
                    if (dic[i]==dic.Max()) {
                        dic[i] -= k;
                        break;
                    }
                }
                int temp = 0;
                for (int i = 0; i < dic.Length; i++) {
                    temp += dic[i] * dic[i];
                }
                res = temp;
            }
            else {
                while (k>0) {
                    if (k>=dic.Max()) {
                        for (int i = 0; i < dic.Length; i++) {
                            if (dic[i]==dic.Max()) {
                                dic[i] = 0;
                                k -= dic.Max();
                                break;
                            }
                        }
                    }
                    else {
                        for (int i = 0; i < dic.Length; i++) {
                            if (dic[i] == dic.Max()) {
                                dic[i] -= k;
                                k = 0;
                                break;
                            }
                        }
                    }
                }
                int temp = 0;
                for (int i = 0; i < dic.Length; i++) {
                    temp += dic[i] * dic[i];
                }
                res = temp;
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
