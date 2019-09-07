using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._057_求角度 {
    class Program {
        static void Main(string[] args) {
            string[] str = Console.ReadLine().Split(' ');
            Console.WriteLine(Math.Acos(Convert.ToInt32(str[0]) / Math.Sqrt(Convert.ToInt32(str[0]) * Convert.ToInt32(str[0]) + Convert.ToInt32(str[1]) * Convert.ToInt32(str[1]))) / Math.PI*180);
            Console.ReadLine();
        }
    }
}
