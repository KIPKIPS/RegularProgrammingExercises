using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._035_比特币最佳买卖时机 {
    class Program {
        static void Main(string[] args) {
            string[] inp = Console.ReadLine().Split(' ');
            int []info=new int[inp.Length];
            for (int i = 0; i < info.Length; i++) {
                info[i] = Convert.ToInt32(inp[i]);
            }
            List<int> profit=new List<int>();
            for (int i = 0; i < info.Length-1; i++) {
                for (int j = i+1; j < info.Length; j++) {
                    profit.Add(info[j]-info[i]);
                }
            }

            Console.WriteLine(profit.Max() <= 0 ? 0:profit.Max());
            Console.ReadLine();
        }
    }
}
