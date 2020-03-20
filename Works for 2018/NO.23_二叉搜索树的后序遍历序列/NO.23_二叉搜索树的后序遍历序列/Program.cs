using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._23_二叉搜索树的后序遍历序列 {
    class Program {
        static void Main(string[] args) {
            //读取输入
            string[] input = Console.ReadLine().Split(' ');
            int[] arr=new int[input.Length];
            //输入格式化
            for (int i = 0; i < input.Length; i++) {
                arr[i] = int.Parse(input[i]);
            }
            //存储函数返回值
            bool res=VerifySequenceOfBST(arr);
            Console.WriteLine(res);
            Console.ReadLine();
        }
        //二叉树的后序遍历序列函数
        public static bool VerifySequenceOfBST(int[] sequence) {
            // write code here
            if (sequence.Length == 0)
                return false;
            return Verify(sequence, 0, sequence.Length - 1);
        }
        //验证函数
        //参数为二叉树序列数组,起始索引,结束索引
        public static bool Verify(int[] sequence, int start, int end) {
            if (end <= start)
                return true;
            else {
                int midIndex = end - 1;
                while (midIndex >= start) {
                    if (sequence[midIndex] >= sequence[end])
                        midIndex--;
                    else
                        break;
                }
                for (int i = start; i <= midIndex; i++)
                    if (sequence[i] > sequence[end])
                        return false;
                bool nextLeftResult = Verify(sequence, start, midIndex);
                bool nextRightResult = Verify(sequence, midIndex + 1, end - 1);
                return nextLeftResult && nextRightResult;
            }
        }

    }
}
