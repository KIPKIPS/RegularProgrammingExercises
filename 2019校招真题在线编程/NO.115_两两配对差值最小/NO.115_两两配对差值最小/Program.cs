using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._115_两两配对差值最小 {
    class Program {
        static void Main(string[] args) {
            string a = Console.ReadLine();
            string[] inp = Console.ReadLine().Split(' ');
            int[]num=new int[inp.Length];
            for (int i = 0; i < inp.Length; i++) {
                num[i] = int.Parse(inp[i]);
            }
            Array.Sort(num);
            Console.WriteLine(((num[num.Length - 1] + num[0])-(num[num.Length-2]+num[1])));
            Console.ReadLine();
        }
    }
}
