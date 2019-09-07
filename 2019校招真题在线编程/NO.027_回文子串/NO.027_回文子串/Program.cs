using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._027_回文子串 {
    class Program {
        static void Main(string[] args) {
            //while (true) {
            //    string s = Console.ReadLine();
            //    char[] t = new char[s.Length];
            //    for (int i = 0; i < s.Length; i++) {
            //        t[i] = s[i];
            //    }
            //    Console.WriteLine(IsPalindromeString(t));
            //}
            string str = Console.ReadLine();
            int count = str.Length;
            for (int i = 0; i < str.Length - 1; i++) {
                for (int j = i + 1; j < str.Length; j++) {
                    char[] temp = new char[str.Length-j+1];
                    //Console.WriteLine("字符串长度"+(str.Length - j+1));
                    str.CopyTo(i,temp,0, str.Length - j + 1);
                    //Console.WriteLine(i + "  " + j);
                    if (IsPalindromeString(temp)) {
                        //foreach (var VARIABLE in temp) {
                        //    Console.Write(VARIABLE);
                        //}
                        //Console.Write("  "+IsPalindromeString(temp));
                        //Console.WriteLine();
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }

        public static bool IsPalindromeString(char[] target) {
            for (int i = 0; i < target.Length / 2; i++) {
                if (target[i] != target[target.Length - i - 1]) {
                    return false;
                }
            }

            return true;
        }
    }
}
