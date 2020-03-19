using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._012_翻转子串 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(checkReverseEqual("abcd", "bcad"));
            Console.ReadLine();
        }

        public static bool checkReverseEqual(string s1, string s2) {
            // write code here
            for (int i = 0; i <s1.Length; i++) 
                if (s1.Substring(i) + s1.Substring(0, i) == s2) 
                    return true;
            return false;
        }
    }
}
