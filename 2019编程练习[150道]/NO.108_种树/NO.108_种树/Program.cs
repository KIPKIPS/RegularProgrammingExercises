using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NO._108_种树 {
    class Program {
        static void Main(string[] args) {
            string nu = Console.ReadLine();
            string[] input = Console.ReadLine().Split(' ');
            List<int>num=new List<int>();
            for (int i = 0; i < input.Length; i++) {
                 num.Add(int.Parse(input[i]));
            }
            //操作计数器
            int count = input.Length;
            //数组下标计数器
            int index = 0;
            int[] treeNum=new int[input.Length];//记录树的个数
            int[]treeIndex=new int[input.Length];//记录树的品种
            while (count>0) {
                treeNum[index] = num.Max();

            }
        }
    }
}
