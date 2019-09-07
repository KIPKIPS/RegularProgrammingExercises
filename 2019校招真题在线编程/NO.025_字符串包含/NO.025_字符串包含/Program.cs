using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._025_字符串包含 {
    class Program {
        static void Main(string[] args) {
            string inp;
            while ( (inp = Console.ReadLine())!=null) {
                string str1 = inp.Split(' ')[0];
                string str2 = inp.Split(' ')[1];
                string source="";
                string determinand="";
                if (str1.Length>str2.Length) {
                    source = str1;
                    determinand = str2;
                }
                else {
                    source = str2;
                    determinand = str1;
                }
                
                int res = 0;
                for (int i = 0; i <= source.Length - determinand.Length; i++) {
                    string temp = "";
                    for (int j = i; j < i + determinand.Length; j++) {
                        temp += source[j] + "";
                    }
                    //Console.WriteLine(temp);
                    if (temp == determinand) {
                        res = 1;
                    }
                }
                Console.WriteLine(res);
            }
            
            
        }
    }
}
