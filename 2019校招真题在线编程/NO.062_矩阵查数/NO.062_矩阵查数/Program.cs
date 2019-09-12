using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._062_矩阵查数 {
    class Program {
        static void Main(string[] args) {
            string[] inp = Console.ReadLine().Split(' ');
            int row = Convert.ToInt32(inp[0]);
            int col = Convert.ToInt32(inp[1]);
            int[,] matrix = new int[row,col];
            for (int i = 0; i < row; i++) {
                string[] temp = Console.ReadLine().Split(' ');
                for (int j = 0; j < col; j++) {
                    matrix[i, j] = Convert.ToInt32(temp[j]);
                }
            }

            int has = 0;
            int find = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < row; i++) {
                if (matrix[i,0]<=find&&matrix[i,col-1]>=find) {
                    for (int j = 0; j < col; j++) {
                        if (matrix[i, j]==find) {
                            has = 1;
                        }
                    }
                }
            }

            if (has==0) {
                Console.WriteLine("false");
            }
            else {
                Console.WriteLine("true");
            }
        }
    }
}
