using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._003_安置路灯 {
    class Program {
        static void Main(string[] args) {
            int numOfUseCase = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numOfUseCase; i++) {
                int count = 0;
                int num = Convert.ToInt32(Console.ReadLine());
                string roadConstruction = Console.ReadLine();
                for (int j = 0; j < roadConstruction.Length;) {
                    if (roadConstruction[j] == '.') {
                        j += 3;
                        count++;
                    }
                    else {
                        j++;
                    }
                }
                Console.WriteLine(count);
            }
            Console.ReadLine();
        }
    }
}
