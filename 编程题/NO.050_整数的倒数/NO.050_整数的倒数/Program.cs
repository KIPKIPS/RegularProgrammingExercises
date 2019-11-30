using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._050_整数的倒数 {
    class Program {
        static void Main(string[] args) {
            string str = Console.ReadLine();
            if (str[0]=='-') {
                string temp = "";
                for (int i = str.Length-1; i >=1; i--) {
                    temp += str[i] + "";
                }
                Console.WriteLine("-"+temp);
            }
            else {
                string temp = "";
                for (int i = str.Length - 1; i >= 0; i--) {
                    temp += str[i] + "";
                }
                Console.WriteLine(temp);
            }

            Console.ReadLine();
        }
    }
}
