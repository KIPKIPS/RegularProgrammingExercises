using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._074_数组下标标杆值 {
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(',');
            int[]inp=new int[input.Length];
            for (int i = 0; i < input.Length; i++) {
                inp[i] = Convert.ToInt32(input[i]);
            }

            List<int> list = Find(inp);
            int sum = 0;
            foreach (var VARIABLE in list) {
                sum += VARIABLE;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        static List<int>res=new List<int>();
        public static List<int> Find(int[] input) {
            int[]num=new int[input.Length-1];
            for (int i = 0; i < num.Length; i++)
                num[i] = input[i];
            int flag = input[input.Length - 1];//flag为input最后一个数字
            for (int i = 0; i < num.Length-1; i++) {
                for (int j = i+1; j < num.Length; j++) {
                    if (num[i]+num[j]==flag) {
                        res.Add(i);
                        res.Add(j);
                    }
                }
            }
            return res;
        }
    }
}
