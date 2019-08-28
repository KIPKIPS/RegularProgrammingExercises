using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NO._002_被3整除 {
    class Program {
        static void Main(string[] args) {
            
        }
        public int DividedByThree(int front, int rear) {
            if (front>rear) {
                return 0;
            }
            string temp = "";
            int count = 0;
            int[] num = new int[rear];
            for (int i = 1; i <= rear; i++) {
                temp += i.ToString();
                num[i - 1] = Convert.ToInt32(temp);
                if (num[i-1]%3==0&&i-1>front-1) {
                    count++;
                }
            }
            return count;
        }
    }
}
