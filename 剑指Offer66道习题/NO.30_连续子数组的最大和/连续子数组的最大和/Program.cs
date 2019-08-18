using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 连续子数组的最大和 {
    class Program {
        static void Main(string[] args) {
            int[] array = new[] {1, 2, 3, -1};
            List<int> res = new List<int>();
            for (int i = 1; i <= array.Length; i++) {
                for (int j = 0; j <= array.Length - i; j++) {
                    int[] sonArray = new int[i];
                    Array.ConstrainedCopy(array, j, sonArray, 0, i);
                    int sum = 0;
                    for (int k = 0; k < sonArray.Length; k++) {
                        sum += sonArray[k];
                    }
                    res.Add(sum);
                }
            }
            Console.WriteLine(res.Max());
            Console.ReadLine();
        }
        public int FindGreatestSumOfSubArray(int[] array) {
            // write code here
            if (array==null) {
                return 0;
            }
            List<int> res = new List<int>();
            for (int i = 1; i <= array.Length; i++) {
                for (int j = 0; j <= array.Length - i; j++) {
                    int[] sonArray = new int[i];
                    Array.ConstrainedCopy(array, j, sonArray, 0, i);
                    int sum = 0;
                    for (int k = 0; k < sonArray.Length; k++) {
                        sum += sonArray[k];
                    }
                    res.Add(sum);
                }
            }
            return res.Max();
        }
    }
}
