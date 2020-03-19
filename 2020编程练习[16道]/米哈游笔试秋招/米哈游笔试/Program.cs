using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 米哈游笔试 {
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            int[] num=new int[input.Length];
            for (int i = 0; i < input.Length; i++) {
                num[i] = int.Parse(input[i]);
            }

            int z = ZeroCount(num);
            if (Verfity(num)) {
                Console.WriteLine("YES+"+z);
            }
            else {
                Console.WriteLine("NO+"+z);
            }

            Console.ReadLine();
        }

        public static bool Verfity(int[] num) {
            if (num.Length==1) {
                return true;
            }
            int zeroCount = ZeroCount(num);
            List<int>newNum=new List<int>();
            //将非零元素存储到新数组
            for (int i = 0; i < num.Length; i++) {
                if (num[i]!=0) {
                    newNum.Add(num[i]);
                }
            }
            //查重
            Dictionary<int,int> dic=new Dictionary<int, int>();
            for (int i = 0; i < newNum.Count; i++) {
                if (dic.ContainsKey(newNum[i])) 
                    return false;
                else 
                    dic.Add(newNum[i],1);
            }

            if (newNum.Count!=0) {
                if (newNum.Max() - newNum.Min() - 1 - (newNum.Count - 2) > zeroCount) {
                    return false;
                }
                else {
                    return true;
                }
            }
            else {
                return true;
            }
        }

        public static int ZeroCount(int[] num) {
            int count = 0;
            foreach (var VARIABLE in num) {
                if (VARIABLE==0) {
                    count++;
                }
            }
            return count;
        }
    }
}
