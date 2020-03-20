using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._43_左旋转字符串 {
    class Program {
        static void Main(string[] args) {
            Program x=new Program();
            Console.WriteLine(x.LeftRotateString("abcxyz", 4));
            Console.Read();
        }
        public string LeftRotateString(string str, int n) {
            if (n>str.Length) {
                return "";
            }
            // write code here
            string str1 = "";
            string str2 = "";
            for (int i = 0; i < n; i++) {
                str1 += str[i];
            }
            for (int i = n; i <str.Length; i++) {
                str2 += str[i];
            }
            return str2+str1;
        }
    }
}
