using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._052_字符串旋转 {
    class Program {
        static void Main(string[] args) {
            string[] str = Console.ReadLine().Split(';');
            int can = 0;
            if (str[0]==str[1]) {
                Console.WriteLine("true");
            }
            else {
                for (int i = 1; i < str[0].Length; i++) {
                    string move = "";
                    string notMove = "";
                    for (int j = 0; j < i; j++) {
                        move += str[0][j];
                    }
                    for (int j = i; j < str[0].Length; j++) {
                        notMove += str[0][j];
                    }

                    if ((notMove+""+move)==str[1]) {
                        can = 1;
                        break;
                    }
                }

                if (can==0) {
                    Console.WriteLine("false");
                }
                else {
                    Console.WriteLine("true");
                }
            }

            Console.ReadLine();

        }
    }
}
