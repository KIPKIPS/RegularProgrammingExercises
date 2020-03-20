using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._061_字符串相乘 {
    class Program {
        static void Main(string[] args) {
            double num = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((num*num2).ToString("#"));
            Console.ReadLine();
        }
    }
}
