using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace 求次方 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Power(2,2));
            Console.WriteLine(Power(2, 0));
            Console.WriteLine(Power(0, 2));
            Console.WriteLine(Power(0, 0));
            Console.WriteLine(Power(2, -1));
            Console.WriteLine(Power(0, -1));
            Console.WriteLine(Power(-2, 2));
            Console.WriteLine(Power(-2, 0));
            Console.WriteLine(Power(0, 2));
            Console.WriteLine(Power(0, 0));
            Console.WriteLine(Power(-2, -1));
            Console.ReadLine();
        }
        public static double Power(double thebase, int exponent) {
            // write code here
            if (thebase==0) {
                if (exponent>=0) {
                    return 0;
                }
                else {
                    return Double.NaN;
                }
            }
            else {
                if (exponent>0) {
                    double num = thebase;
                    for (int i = 0; i < exponent-1; i++) {
                        num = num * thebase;
                    }
                    return num;
                }
                else {
                    if (exponent==0) {
                        return 1;
                    }

                    else {
                        double num = thebase;
                        for (int i = 0; i < (exponent+2*-exponent)-1; i++) {
                            num = num * thebase;
                        }

                        num = 1 / num;
                        return num;
                    }
                }
            }
        }

    }
}
