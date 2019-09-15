using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._078_最大新整数 {
    class Program {
        static void Main(string[] args) {
            string[] inp = Console.ReadLine().Split(' ');
            List<int>info=new List<int>();
            for (int i = 0; i < inp[0].Length; i++) {
                info.Add(Convert.ToInt32(inp[0][i]+""));
            }

            for (int i = 0; i < Convert.ToInt32(inp[1]); i++) {
                info.Remove(info.Min());
            }
            foreach (var VARIABLE in info) {
                Console.Write(VARIABLE);
            }

            Console.ReadLine();
        }
    }
}
