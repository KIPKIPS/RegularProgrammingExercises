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
            int[] buildData = new int [buildNum];
            string[] t = Console.ReadLine().Split(' ');
            for (int k = 0; k < t.Length; k++) {
                buildData[k] = Convert.ToInt32(t[k]);
            }

            int res = 0;
            int i = 0;
            while (i < buildData.Length - 2) {
                int j = i + 2;
                while (j< buildData.Length&& buildData[j] - buildData[i] <= maxDis) {
                    res += j - i - 1;
                    j++;
                }
                i++;
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
