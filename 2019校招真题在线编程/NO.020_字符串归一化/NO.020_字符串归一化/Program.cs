using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._020_字符串归一化 {
    class Program {
        static void Main(string[] args) {
            string str = Console.ReadLine();
            int[]info=new int[26];
            
            for (int i = 0; i < str.Length; i++) {
                info[str[i] - 97]++;
            }

            for (int i = 0; i < info.Length; i++) {
                if (info[i]!=0) {
                    char temp = (char)(i + 97);
                    Console.Write(temp);
                    Console.Write(info[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
