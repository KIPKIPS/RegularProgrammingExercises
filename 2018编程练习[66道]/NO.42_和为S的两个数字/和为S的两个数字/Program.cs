using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 和为S的两个数字 {
    class Program {
        //输入一个递增排序的数组和一个数字S，在数组中查找两个数，使得他们的和正好是S，如果有多对数字的和等于S，输出两个数的乘积最小的。
        static void Main(string[] args) {
            Program x=new Program();
            foreach (var VARIABLE in x.FindNumbersWithSum(new[] { -1,0, 2, 4, 7, 8, 9, 11,15 }, 11)) {
                Console.Write(VARIABLE+" ");
            }
            Console.ReadLine();

        }
        
        public List<int> FindNumbersWithSum(int[] array, int sum) {
            List<int> temp = new List<int>();
            List<int> res = new List<int>();
            // write code here
            for (int i = 0; i < array.Length-1; i++) {
                for (int j = array.Length - 1; j >0; j--) {
                    if (array[i]+array[j]==sum&&i<j) {
                        temp.Add(array[i]);
                        temp.Add(array[j]);
                    }
                }
            }
            if (temp.Count==0) {
                return temp;
            }
            res.Add(temp[0]); res.Add(temp[1]);
            return res;
        }
    }
}
