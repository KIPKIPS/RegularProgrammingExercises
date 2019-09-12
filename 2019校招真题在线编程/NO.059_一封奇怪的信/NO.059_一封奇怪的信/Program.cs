using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._059_一封奇怪的信 {
    class Program {
        static void Main(string[] args) {
            int a = 'a';//97
            string[] input = Console.ReadLine().Split(' ');
            int[]charLength=new int[26];
            for (int i = 0; i < charLength.Length; i++) {
                charLength[i] = Convert.ToInt32(input[i]);
            }

            string letter = Console.ReadLine();
            int row = 1;
            int rowLength = 0;
            int lastRow = 0;
            for (int i = 0; i < letter.Length; i++) {
                int temp = letter[i];
                rowLength += charLength[temp - 97];
                lastRow = rowLength;
                if (rowLength>100) {
                    rowLength =0;
                    lastRow = 0;
                    row++;
                    i--;
                }
            }
            Console.Write(row+" "+lastRow);
            Console.ReadLine();
        }
    }
}
