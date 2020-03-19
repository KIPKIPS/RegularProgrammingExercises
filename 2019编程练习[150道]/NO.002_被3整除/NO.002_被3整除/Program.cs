using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NO._002_被3整除 {
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            Console.WriteLine(DividedByThree(Convert.ToInt32(input[0]), Convert.ToInt32(input[1])));
            Console.ReadLine();
        }
        public static int DividedByThree(int front, int rear) {
            string temp = "";
            int count = 0;
            string[] num = new string[rear];
            int[] number = new int[rear];
            for (int i = 1; i <= rear; i++) {
                temp += i.ToString();
                num[i-1] = temp;
                //Console.WriteLine(num[i-1]);
                //诸位相加
                int t = 0;
                for (int j = 0; j < num[i-1].Length; j++) {
                    t += Convert.ToInt32(num[i - 1][j] + "");
                }
                //Console.WriteLine(t);
                number[i - 1] = t;
            }

            for (int i = front-1; i <= rear-1; i++) {
                if (number[i]%3==0) {
                    count++;
                }
            }
            return count;
        }
    }
}
