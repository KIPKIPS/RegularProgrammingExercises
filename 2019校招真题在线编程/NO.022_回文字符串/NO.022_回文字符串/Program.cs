using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._022_回文字符串 {
    class Program {
        static void Main(string[] args) {
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length-1; i++) {
                char[] front =new char[i+1];
                str.CopyTo(0, front, 0, i + 1);
                char[] rear=new char[str.Length-(i+1)];
                str.CopyTo(i+1,rear,0, str.Length - (i + 1));
                rear.Reverse();

            }
            
        }
    }
}
