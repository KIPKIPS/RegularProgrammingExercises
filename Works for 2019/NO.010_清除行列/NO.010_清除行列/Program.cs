using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._010_清除行列 {
    class Program {
        static void Main(string[] args) {
            int[][] mat = new[] {new[] {1, 2, 3}, new[] {0, 1, 2}, new[] {0, 0, 1}};
            clearZero(mat, 3);
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) 
                    Console.Write(mat[i][j]+" ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static int[][] clearZero(int[][] mat, int n) {
            // write code here
            List<int[]> RCInfo = new List<int[]>();//存储矩阵点坐标信息
            for (int i = 0; i < n; i++) 
                for (int j = 0; j < n; j++) 
                    if (mat[i][j] == 0) 
                        RCInfo.Add(new[] { i, j });//记录坐标
            for (int i = 0; i < RCInfo.Count; i++) 
                for (int j = 0; j < n; j++) {
                    mat[RCInfo[i][0]][j] = 0;//清除行
                    mat[j][RCInfo[i][1]] = 0;//清除列
                }
            return mat;
        }
    }
}
