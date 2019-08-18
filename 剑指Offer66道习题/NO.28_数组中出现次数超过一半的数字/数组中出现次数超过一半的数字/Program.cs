using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组中出现次数超过一半的数字 {
    class Program {
        static void Main(string[] args) {
            Console.ReadLine();
        }
        public int MoreThanHalfNum_Solution(int[] numbers) {
            // write code here
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++) {
                if (dic.ContainsKey(numbers[i])) {
                    dic[numbers[i]]++;
                }
                else {
                    dic.Add(numbers[i], 1);
                }
            }

            foreach (KeyValuePair<int, int> VARIABLE in dic) {
                if (VARIABLE.Value>numbers.Length/2.0f) {
                    return VARIABLE.Key;
                }
            }
            return 0;
        }
    }
}
