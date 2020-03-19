using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._030_求连续子数组的最大和 {
    class Program {
        static void Main(string[] args) {
            string[] nums = Console.ReadLine().Split(',');
            int[] cursum = new int[nums.Length];
            int max = int.MinValue;
            for (int i = 0; i < nums.Count(); i++) {
                if (i > 0)
                    cursum[i] = cursum[i - 1] + int.Parse(nums[i]);
                else
                    cursum[i] = int.Parse(nums[i]);
                max = max > cursum[i] ? max : cursum[i];
                for (int j = 0; j <= i; j++) {
                    max = max > cursum[i] - cursum[j] ? max : cursum[i] - cursum[j];
                }
            }
            Console.WriteLine(max);
        }
    }
}
