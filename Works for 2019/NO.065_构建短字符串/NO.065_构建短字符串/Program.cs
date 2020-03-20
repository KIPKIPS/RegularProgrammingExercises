using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._065_构建短字符串 {
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            string shortStr = input[0];
            string longStr = input[1];
            Dictionary<char,int>dic=new Dictionary<char, int>();
            for (int i = 0; i < longStr.Length; i++) {
                if (dic.ContainsKey(longStr[i])) {
                    dic[longStr[i]]++;
                }
                else {
                    dic.Add(longStr[i],1);
                }
            }

            int can = 0;//0可以,1不行
            for (int i = 0; i < shortStr.Length; i++) {
                if (dic.ContainsKey(shortStr[i])) {
                    dic[shortStr[i]]--;
                }
                else {
                    can = 1;
                }
            }

            foreach (KeyValuePair<char,int> VARIABLE in dic) {
                if (VARIABLE.Value<0) {
                    can = 1;
                }
            }

            if (can==0) {
                Console.WriteLine("true");
            }
            else {
                Console.WriteLine("false");
            }
        }
    }
}
