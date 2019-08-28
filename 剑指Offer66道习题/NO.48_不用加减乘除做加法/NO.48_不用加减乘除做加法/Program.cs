using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._48_不用加减乘除做加法 {
    class Program {
        static void Main(string[] args) {

        }
        public int Add(int num1, int num2) {
            while (num2 != 0) {
                int temp = num1 ^ num2;
                num2 = (num1 & num2) << 1;
                num1 = temp;
            }
            return num1;
        }
    }
}
