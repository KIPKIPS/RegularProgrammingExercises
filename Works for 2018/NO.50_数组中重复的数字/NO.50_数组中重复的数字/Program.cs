using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._50_数组中重复的数字 {
    class Program {
        static void Main(string[] args) {
        }
        public bool duplicate(int[] numbers, int[] duplication) {
            // write code here
            if (numbers.Length==0) {
                return false;
            }
            Dictionary<int,int> coll=new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++) {
                if (coll.ContainsKey(numbers[i])) {
                    coll[numbers[i]]++;
                }
                else {
                    coll.Add(numbers[i],1);
                }
            }

            foreach (KeyValuePair<int,int> VARIABLE in coll) {
                if (VARIABLE.Value>1) {
                    duplication[0] = VARIABLE.Key;
                    return true;
                }
            }

            return false;
        }

    }
}
