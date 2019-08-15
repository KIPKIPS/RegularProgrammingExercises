using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变态跳台阶 {
    //一只青蛙一次可以跳上1级台阶，也可以跳上2级……它也可以跳上n级。求该青蛙跳上一个n级的台阶总共有多少种跳法。
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(jumpFloorII(2));
            Console.ReadLine();
        }
        public static int jumpFloorII(int number) {
            // write code here
            if (number==0) {
                return 0;
            }

            int a = 1;
            for (int i = 0; i < number-1; i++) {
                a = a * 2;
            }
            return a;
        }
    }
}
