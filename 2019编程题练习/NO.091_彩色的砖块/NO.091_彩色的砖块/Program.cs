using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._091_彩色的砖块 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            int[] word = new int[26];
            for (int i = 0; i < input.Length; i++)
                word[input[i] - 65]++;
            int count = 0;
            for (int i = 0; i < word.Length; i++) {
                if (word[i] != 0)
                    count++;
                if (count > 2)
                    break;
            }
            if (count > 2)
                Console.WriteLine(0);
            else if (count == 2)
                Console.WriteLine(2);
            else
                Console.WriteLine(1);
        }
    }
}
