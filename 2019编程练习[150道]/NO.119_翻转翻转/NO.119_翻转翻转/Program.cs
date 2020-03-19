using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._119_翻转翻转 {
    class Program {
        static void Main(string[] args) {
            string[] inp = Console.ReadLine().Split(' ');
            int[] num = new int[inp.Length];
            for (int i = 0; i < inp.Length; i++)
                num[i] = int.Parse(inp[i]);
            for (int i = 0; i < num[0]; i++) {
                int[,] temp = new int[num[i * 2 + 1], num[i * 2 + 2]];
                temp = Turn(temp);
                if (i != num[0] - 1)
                    Console.Write(Count(temp) + " ");
                else
                    Console.Write(Count(temp));
                //Console.WriteLine(temp.GetLength(0)+" "+temp.GetLength(1));
            }

            Console.ReadLine();
        }
        //翻转函数
        static int[,] Turn(int[,] num) {
            for (int i = 0; i < num.GetLength(0); i++) {//行
                for (int j = 0; j < num.GetLength(1); j++) {//列
                    num[i, j] = 1 - num[i, j];//自身点
                    if (i - 1 >= 0 && j - 1 >= 0)
                        num[i - 1, j - 1] = 1 - num[i - 1, j - 1];//左上角
                    if (j - 1 >= 0)
                        num[i, j - 1] = 1 - num[i, j - 1];//正上方
                    if (i + 1 <= num.GetLength(0) - 1 && j - 1 >= 0)
                        num[i + 1, j - 1] = 1 - num[i + 1, j - 1];//右上角
                    if (i + 1 <= num.GetLength(0) - 1)
                        num[i + 1, j] = 1 - num[i + 1, j];//正右方
                    if (i + 1 <= num.GetLength(0) - 1 && j + 1 <= num.GetLength(1) - 1)
                        num[i + 1, j + 1] = 1 - num[i + 1, j + 1];//右下角
                    if (j + 1 <= num.GetLength(1) - 1)
                        num[i, j + 1] = 1 - num[i, j + 1];//正下方
                    if (i - 1 >= 0 && j + 1 <= num.GetLength(1) - 1)
                        num[i - 1, j + 1] = 1 - num[i - 1, j + 1];//左下角
                    if (i - 1 >= 0)
                        num[i - 1, j] = 1 - num[i - 1, j];//正左方
                }
            }
            return num;
        }

        static int Count(int[,] num) {
            int count = 0;
            for (int i = 0; i < num.GetLength(0); i++) {
                for (int j = 0; j < num.GetLength(1); j++)
                    if (num[i, j] == 1)
                        count++;
            }
            return count;
        }
    }
}
