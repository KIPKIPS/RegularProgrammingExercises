using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._004_迷路的牛牛 {
    class Program {
        static void Main(string[] args) {
            int numberOfTurns = Convert.ToInt32(Console.ReadLine());
            string info = Console.ReadLine();
                int numOfL = 0;
                int numOfR = 0;
                for (int j = 0; j < info.Length; j++) {
                    if (info[j]=='L') {
                        numOfL++;
                    }
                    if (info[j] == 'R') {
                        numOfR++;
                    }
                }
                if (numOfL>=numOfR) {
                    switch ((numOfL - numOfR) % 4) {
                        case 0:Console.WriteLine("N");break;
                        case 1: Console.WriteLine("W"); break;
                        case 2: Console.WriteLine("S"); break;
                        case 3: Console.WriteLine("E"); break;
                    }
                }
                else {
                    switch ((numOfR - numOfL) % 4) {
                        case 1: Console.WriteLine("E"); break;
                        case 2: Console.WriteLine("S"); break;
                        case 3: Console.WriteLine("W"); break;
                    }
                }

                Console.ReadLine();
        }
    }
}
