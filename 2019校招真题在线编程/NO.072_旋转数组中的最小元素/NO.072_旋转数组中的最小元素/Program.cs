using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._072_旋转数组中的最小元素 {
    class Program {
        static void Main(string[] args) {
            string[] read = Console.ReadLine().Split(' ');
            int[]nums=new int[read.Length];
            for (int i = 0; i < nums.Length; i++) {
                nums[i] = Convert.ToInt32(read[i]);
            }
            Console.WriteLine(nums.Min());
        }
    }
}
