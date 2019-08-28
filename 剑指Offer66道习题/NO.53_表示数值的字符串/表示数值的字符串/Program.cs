using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 表示数值的字符串 {
    class Program {
        static void Main(string[] args) {
            Program x=new Program();
            Console.WriteLine(x.isNumeric(new []{'1','2','e'}));
            Console.ReadLine();
        }
        public bool isNumeric(char[] str) {
            // write code here
            string st = "";
            //for (int i = 0; i < str.Length; i++) {
            //    st += str[i];
            //}
            return Regex.IsMatch(st, "[\\+\\-]?\\d*(\\.\\d+)?([eE][\\+\\-]?\\d+)?");
            Console.WriteLine("正则表达式");
        }
    }
}
