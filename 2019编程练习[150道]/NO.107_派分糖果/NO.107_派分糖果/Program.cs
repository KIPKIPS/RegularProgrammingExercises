using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._107_派分糖果 {
    class Program {
        static void Main(string[] args) {
            string[] inp = Console.ReadLine().Split(',');
            int[]num=new int[inp.Length];
            for (int i = 0; i < inp.Length; i++) {
                num[i] = int.Parse(inp[i]);
            }
            int[]res=new int[inp.Length];
            res[0] = 1;
            for (int i = 1; i < num.Length; i++) {
                res[i] = 1;
                if (num[i] > num[i - 1])
                    res[i] = res[i - 1] + 1;
            }
            for (int i = num.Length - 2; i >= 0; i--) {
                if (num[i] > num[i + 1])
                    res[i] = Math.Max(res[i], res[i + 1] + 1);
            }
            Console.WriteLine(res.Sum());
            Console.ReadLine();
        }
    }
}
