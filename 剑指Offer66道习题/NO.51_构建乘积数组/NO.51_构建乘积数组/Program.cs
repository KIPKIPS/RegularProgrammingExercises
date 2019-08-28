using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._51_构建乘积数组 {
    class Program {
        static void Main(string[] args) {
            Program x=new Program();
            foreach (var VARIABLE in x.multiply(new[] { 1, 2, 3, 4, 5 })) {
                Console.Write(VARIABLE+" ");
            }

            Console.ReadLine();
        }
        public int[] multiply(int[] A) {
            // write code here
            
            int[]B=new int[A.Length];
            for (int i = 0; i < B.Length; i++) {
                int res = 1;
                for (int j = 0; j < B.Length; j++) {
                    if (i!=j) {
                        res *= A[j];
                    }
                    
                }
                B[i] = res;
            }
            return B;
        }
    }
}
