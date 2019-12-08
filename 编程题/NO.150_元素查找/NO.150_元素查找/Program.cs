using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._150_元素查找 {
    class Program {
        static void Main(string[] args) {
        }
        public static int findElement(int[] A, int n, int x) {
            // write code here
            return x <= (A[0] - 1) ? x + n - (A[0] - 1) - 1 : x - (A[0] - 1) - 1;
        }
    }
}
