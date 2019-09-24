using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace 委托进阶 {
    class Program {
        public delegate int PlusCalculate(int a, int b);
        static void Main(string[] args) {
            
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            PlusCalculate method = x > y ? (PlusCalculate)Minus :Plus;
            Console.WriteLine(method(x, y));
            Console.ReadLine();
        }

        public static int Plus(int a, int b) {
            return a + b;
        }
        public static int Minus(int a, int b) {
            return a - b;
        }
    }
}
