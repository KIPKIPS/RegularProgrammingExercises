using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._063_爬楼梯 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(jumpFloor(Convert.ToInt32(Console.ReadLine())));
            Console.ReadLine();
        }
        public static int jumpFloor(int number) {
            // write code here
            if (number <= 0) {
                return -1;
            }
            else if (number == 1) {
                return 1;
            }

            else if (number == 2) {
                return 2;
            }
            else {
                return jumpFloor(number - 1) + jumpFloor(number - 2);
            }
        }
    }
}
