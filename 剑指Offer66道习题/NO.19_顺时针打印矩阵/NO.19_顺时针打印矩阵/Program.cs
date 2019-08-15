using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._19_顺时针打印矩阵 {
    class Program {
        static void Main(string[] args) {
            int[][] num= {new [] {1,2,3,4},new [] {5,6,7,8},new []{9,10,11,12},new []{13,14,15,16}};
        }
        public List<int> printMatrix(int[][] matrix) {
            // write code here
            var top = 0;
            var bottom = matrix.Length - 1;
            var left = 0;
            var right = matrix[0].Length - 1;
            List<int> list = new List<int>();
            while (top <= bottom && left <= right) {
                for (int i = left; i <= right; i++) {
                    list.Add(matrix[top][i]);
                }
                for (int i = top + 1; i <= bottom; i++) {
                    list.Add(matrix[i][right]);
                }
                if (top != bottom) {
                    for (int i = right - 1; i >= left; i--) {
                        list.Add(matrix[bottom][i]);
                    }
                }
                if (left != right) {
                    for (int i = bottom - 1; i > top; i--) {
                        list.Add(matrix[i][left]);
                    }
                }
                left++;
                right--;
                top++;
                bottom--;
            }
            return list;
        }
    }
}