using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02 {
    class Program {
        static void Main(string[] args) {
            string[] inp = Console.ReadLine().Split(' ');
            int buildNum = Convert.ToInt32(inp[0]);
            int maxDis = Convert.ToInt32(inp[1]);
            int[] buildData = new int[buildNum];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < t.Length; i++) {
                buildData[i] = Convert.ToInt32(t[i]);
            }

            long res = 0;
            int j;
            for (int i = 0; i < buildData.Length-2; i++) {
                 j = i + 2;
                while (j < buildData.Length&& buildData[j] - buildData[i] <= maxDis) {
                    res += j - i - 1;
                    j++;
                }
            }

            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
