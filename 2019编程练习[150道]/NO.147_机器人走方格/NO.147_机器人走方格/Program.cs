using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._147_机器人走方格 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(countWays(3,3));
            Console.ReadLine();
        }
        public static int countWays(int x, int y) {
            // write code here
            return process(x, y, 0, 0);
        }
        public static int process(int x, int y, int i, int j) {
            if (i == x - 1 && j == y - 1)
                return 1;
            if (i < 0 || i >= x || j < 0 || j >= y)
                return 0;
            return process(x, y, i, j + 1) +
                   process(x, y, i + 1, j);
        }
    }
}
