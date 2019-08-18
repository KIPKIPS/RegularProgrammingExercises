using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 最小的K个数 {
    class Program {
        static void Main(string[] args) {
            Program x=new Program();
            
            foreach (var UPPER in x.GetLeastNumbers_Solution(new[] { 1, 2, 3, 4, 6, 5, 4, 2, 1 }, 5)) {
                Console.Write(" "+UPPER);
            }

            Console.ReadLine();
        }
        public List<int> GetLeastNumbers_Solution(int[] input, int k) {
            // write code here
            List<int> res = new List<int>();
            if (k>input.Length) {
                return res;
            }
            Array.Sort(input);
            
            for (int i = 0; i < k; i++) {
                res.Add(input[i]);
            }

            return res;
        }
    }
}
