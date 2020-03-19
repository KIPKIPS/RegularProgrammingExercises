using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//一只青蛙一次可以跳上1级台阶，也可以跳上2级。求该青蛙跳上一个n级的台阶总共有多少种跳法（先后次序不同算不同的结果）。
namespace NO._08_跳台阶 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine(jumpFloor(10));
            Console.ReadLine();
        }
        public static int jumpFloor(int number) {
            // write code here
            if (number <= 0) {
                return -1;
            }
            else if (number==1) {
                return 1;
            }

            else if (number==2) {
                return 2;
            }
            else{
                return jumpFloor(number - 1) + jumpFloor(number - 2);
            }
        }
    }
}
