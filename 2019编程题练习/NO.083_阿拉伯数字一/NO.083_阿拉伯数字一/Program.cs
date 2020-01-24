using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._083_阿拉伯数字一 {
    class Program {
        static void Main(string[] args) {
            string temp = "";
            for (int i = 100; i <= 199; i++) {
                temp += i.ToString();
            }

            int count = 0;
            for (int i = 0; i < temp.Length; i++) {
                if (temp[i]=='1') {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
