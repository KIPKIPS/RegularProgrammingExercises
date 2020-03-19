using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 和为S的连续正数序列 {
    class Program {
        static void Main(string[] args) {
        }
        public List<List<int>> FindContinuousSequence(int sum) {
            // write code here
            int[]arr=new int[sum];
            for (int i = 1; i <= sum; i++) {
                arr[i - 1] = i;
            }
            
        }
    }
}
