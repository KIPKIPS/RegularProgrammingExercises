using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._070_数组操作 {
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            int[] nums=new int[input.Length];
            List<int> odd = new List<int>();
            List<int> even = new List<int>();
            for (int i = 0; i < nums.Length; i++) {
                nums[i] = Convert.ToInt32(input[i]);
                if (nums[i]%2==0) {
                    even.Add(nums[i]);
                }
                else {
                    odd.Add(nums[i]);
                }
            }
            int[]sort=new int[nums.Length];
            for (int i = 0; i <sort.Length; i++) {
                if (i<even.Count) {
                    sort[i] = even[i];
                }
                else {
                    sort[i] = odd[i-even.Count];
                }
            }

            for (int i = 0; i < sort.Length; i++) {
                if (i<sort.Length-1) {
                    Console.Write(sort[i]+" ");
                }
                else {
                    Console.Write(sort[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
