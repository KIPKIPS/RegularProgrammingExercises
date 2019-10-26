using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._117_代价 {
    class Program {
        static void Main(string[] args) {
            string[] n = Console.ReadLine().Split(' ');
            int[] num = {int.Parse(n[0]), int.Parse(n[1]), int.Parse(n[2])};
            Array.Sort(num);
            Console.WriteLine(num[1]-num[0]+num[2]-num[1]);
        }
    }
}
