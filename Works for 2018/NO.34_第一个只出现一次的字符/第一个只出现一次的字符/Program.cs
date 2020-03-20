using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一个只出现一次的字符 {
    class Program {
        static void Main(string[] args) {
            Program x=new Program();
            Console.WriteLine(x.FirstNotRepeatingChar("google"));
            Console.ReadLine();
        }
        public int FirstNotRepeatingChar(string str) {
            // write code here
            Dictionary<char,int>dic=new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++) {
                if (dic.ContainsKey(str[i])) {
                    dic[str[i]]++;
                }
                else {
                    dic.Add(str[i], 1);
                }
            }

            //foreach (KeyValuePair<char, int> VARIABLE in dic) {
            //    Console.WriteLine(VARIABLE.Key+"  "+VARIABLE.Value);
            //}
            foreach (KeyValuePair<char, int> VARIABLE in dic) {
                if (VARIABLE.Value == 1) {
                    for (int i = 0; i < str.Length; i++) {
                        if (VARIABLE.Key.Equals(str[i])) {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }
    }
}
