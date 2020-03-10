using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3 {
    class Program {
        static void Main(string[] args) {
            int num = Convert.ToInt32(Console.ReadLine());
            int n4 = num % 4 == 0 ? num / 4 : num / 4 + 1;
            int n7= num % 7 == 0 ? num / 7 : num / 7 + 1;
            int min = n4+n7;
            Console.WriteLine(n4+" "+n7);
            for (int i = 0; i < n4; i++) {
                for (int j = 0; j < n7; j++) {
                    if (i*4+j*7==num) {
                        if (i+j<=min) {
                            min = i + j;
                            Console.WriteLine(i+" "+j);
                        }
                    }
                }
            }
            Console.WriteLine(min);
            Console.ReadLine();
        }
    }
}
