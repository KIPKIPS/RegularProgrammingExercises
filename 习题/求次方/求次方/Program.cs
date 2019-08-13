using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 求次方 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Power(2,-1));
            Console.ReadLine();
        }
        public static double Power(double thebase, int exponent) {
            // write code here

            return (double)Math.Pow(thebase, (double)exponent);


        }

    }
}
