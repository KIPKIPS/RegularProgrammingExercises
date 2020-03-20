using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NO._52_正则表达式匹配 {
    class Program {
        static void Main(string[] args) {
            Program x=new Program();
            Console.WriteLine(x.match(new[] { 'a', 'a' }, new[] { '.' }));
            Console.ReadLine();
        }
        public bool match(char[] str, char[] pattern) {
            if (pattern.Length==0&&str.Length!=0) {
                return false;
            }
            if (pattern.Length == 0 && str.Length == 0) {
                return true;
            }
            for (int i = 0; i < UPPER; i++) {
                
            }
        }
    }
}
