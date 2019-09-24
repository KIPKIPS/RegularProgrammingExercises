using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._082_二维数组中的查找 {
    class Program {
        static void Main(string[] args) {
            int[][] array =  {new[] {1, 2, 3}, new[] {2, 3, 4}};
            Console.WriteLine(Find(2,array));
            Console.Read();

        }

        public static bool Find(int target, int[][] array) {
            // write code here
            for (int i = 0; i < array.GetLength(0); i++) {
                for (int j = 0; j < array.GetLength(1); j++) {
                    if (array[i][j]==target) {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
