using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._033_数字序列第n位的值 {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; ; i++) {
                if (i*(i+1)/2>=n) {
                    Console.WriteLine(i);break;
                }
            }

            Console.ReadLine();
        }
    }
}
