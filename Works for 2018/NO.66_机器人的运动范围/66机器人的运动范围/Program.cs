using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66机器人的运动范围 {
    //地上有一个m行和n列的方格。一个机器人从坐标0,0的格子开始移动，每一次只能向左，右，上，下四个方向移动一格，
    //但是不能进入行坐标和列坐标的数位之和大于k的格子。 例如，当k为18时，机器人能够进入方格（35,37），因为3+5+3+7 = 18。
    //但是，它不能进入方格（35,38），因为3+5+3+8 = 19。请问该机器人能够达到多少个格子？
    class Program {
        static void Main(string[] args) {
        }
        public int movingCount(int threshold, int rows, int cols) {
            // write code here
            if (threshold < 0 || rows <= 0 || cols <= 0)
                return 0;
            bool[,] visited = new bool[rows, cols];
            int[,] sums = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                sums[i, j] = digitSum(i) + digitSum(j);
            return core(threshold, rows, cols, 0, 0, visited, sums);
        }

        private int core(int thres, int rows, int cols, int i, int j, bool[,] visited, int[,] sums) {
            if (i >= 0 && i < rows && j >= 0 && j < cols && !visited[i, j] && sums[i, j] <= thres) {
                visited[i, j] = true;
                int ret = 0;
                int down = core(thres, rows, cols, i + 1, j, visited, sums);
                int up = core(thres, rows, cols, i - 1, j, visited, sums);
                int left = core(thres, rows, cols, i, j - 1, visited, sums);
                int right = core(thres, rows, cols, i, j + 1, visited, sums);
                return 1 + left + down + right + up;
            }
            else
                return 0;
        }

        private int digitSum(int num) {
            int sum = 0;
            for (; num > 0;) {
                sum += num % 10;
                num = num / 10;
            }
            return sum;
        }

    }
}
