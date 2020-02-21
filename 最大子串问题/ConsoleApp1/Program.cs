using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            string tar = Console.ReadLine();
            char[] tarCharArray = tar.ToCharArray();
            Array.Sort(tarCharArray);
            Array.Reverse(tarCharArray);
            string d = "";
            string result = "";
            HashSet<char> dic=new HashSet<char>();
            foreach (char VARIABLE in tarCharArray) {
                if (!dic.Contains(VARIABLE)) {
                    dic.Add(VARIABLE);
                    d += VARIABLE;
                }
            }
            //Console.WriteLine("降序字典"+d);
            for (int i = 0; i < tar.Length; i++) {
                for (int j = 0; j < d.Length; j++) {
                    if (j > 0) {
                        if (tar[i] == d[j] && i > IndexOfLastChar(d[j - 1], tar)) {
                            result += tar[i];
                        }
                    }
                    else {
                        if (tar[i] == d[j]) {
                            result += tar[i];
                        }
                    }
                    
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
        //最后一个字符在串中的位置
        static int IndexOfLastChar(char tar, string s) {
            for (int i = s.Length-1; i >=0; i--) {
                if (s[i]==tar) {
                    return i;
                }
            }
            return -1;
        }
    }
}
