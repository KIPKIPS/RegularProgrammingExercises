using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._098_循环数比较 {
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            string v1 = Repeat(input[0], input[1]);
            string v2 = Repeat(input[2], input[3]);
            //Console.WriteLine(v1+" "+v2);
            if (v1.Length > v2.Length)
                Console.WriteLine("Greater");
            if (v2.Length > v1.Length)
                Console.WriteLine("Less");
            if (v1.Length == v2.Length) {
                if (v1 == v2)
                    Console.WriteLine("Equal");
                else {
                    bool oneGreaterThanTwo = true;
                    for (int i = 0; i < v1.Length; i++) {
                        if (v2[i] > v1[i]) {
                            oneGreaterThanTwo = false;
                            break;
                        }
                        if (v1[i] > v2[i])
                            break;
                    }
                    Console.WriteLine(oneGreaterThanTwo ? "Greater" : "Less");
                }
            }
            Console.ReadLine();
        }

        public static string Repeat(string obj, string times) {
            string res = "";
            for (int i = 0; i < Convert.ToInt32(times + ""); i++) {
                res += obj;
            }
            return res;
        }
    }
}
