using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数字在排序数组中出现的次数 {
    class Program {
        static void Main(string[] args) {
            Program x=new Program();
            
                Console.WriteLine(x.GetNumberOfK(new[] { 1, 2, 2, 3, 3, 3, 4, 4 }, 4));
                Console.ReadLine();
        }
        public int GetNumberOfK(int[] data, int k) {
            if (data==null) {
                return -1;
            }
            // write code here
            int count = 0;
            for (int i = 0; i < data.Length; i++) {
                if (k==data[i]) {
                    count++;
                }
            }
            return count;
        }
    }
}
