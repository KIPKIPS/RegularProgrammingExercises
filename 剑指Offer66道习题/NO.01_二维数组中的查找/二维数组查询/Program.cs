using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二维数组查询 {
    class Program {
        static void Main(string[] args) {
            int[,] array = new int[3, 4] {{1, 2, 3, 4}, {2, 3, 4, 5}, {3, 4, 5, 6}};
            Console.WriteLine(Find(1, array));
            //for (int i = 0; i < row; i++) {
            //    for (int j = 0; j < col; j++) {
            //        Console.Write(array[i,j]+" ");
            //    }
            //}
            Console.ReadLine();
        }
        public static bool Find(int target, int[,] array) {
            //int row = array.GetLength(0);//行
            //int col = array.GetLength(1);//列
            //for (int i = 0; i < row; i++) {
            //    if (target<=array[i,col-1]) {
            //        for (int j = 0; j < col; j++) {
            //            if (array[i, j] == target) {
            //                return true;
            //            }
            //        }
            //    }
            //}
            //return false;
            if (array.GetLength(0) == 0 || array.GetLength(1) == 0 || array == null) {
                return false;
            }
            else {
                int row = array.GetLength(0);//行
                int col = array.GetLength(1);//列
                for (int i = 0; i < row; i++) {
                    if (target <= array[i,col - 1]) {
                        for (int j = 0; j < col; j++) {
                            if (array[i,j] == target) {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
        }
    }
}
