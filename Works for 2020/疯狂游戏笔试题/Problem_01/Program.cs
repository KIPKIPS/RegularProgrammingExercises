using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01 {
    class Program {
        static void Main(string[] args) {
            string[] data = Console.ReadLine().Split('*');
            long res = 1;
            for (int i = 0; i < data.Length; i++) {
                res*= long.Parse(data[i]);
            }

            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
