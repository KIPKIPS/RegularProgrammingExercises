using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem {
    class Program {
        static void Main(string[] args) {
            string[] inp = Console.ReadLine().Split(' ');
            int[]data=new int[inp.Length];
            for (int i = 0; i < data.Length; i++) {
                data[i] = Convert.ToInt32(inp[i]);
            }

            int max = GreatestArray(data);
            Console.WriteLine(max);
            Console.ReadLine();
        }

        static int GreatestArray(int[] data) {
            int max = 0;
            int curMax = 0;
            for (int i = 0; i < data.Length; i++) {
                curMax += data[i];
                if (curMax>=max) {
                    max = curMax;
                }
                if (curMax<=0) {
                    curMax = 0;
                }
            }
            return max;
        }
    }
}
