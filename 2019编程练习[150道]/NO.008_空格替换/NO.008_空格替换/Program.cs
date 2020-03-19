using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._008_空格替换 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(replaceSpace("a a ",4));
            Console.ReadLine();
        }
        public static string replaceSpace(string iniString, int length) {
            // write code here
            string temp = "";
            for (int i = 0; i < length; i++) 
                temp += iniString[i] == ' ' ? "%20" : iniString[i]+"";
            return temp;
        }
    }
}
