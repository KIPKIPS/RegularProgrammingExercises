using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组复制 {
    class Program {
        static void Main(string[] args) {
            int[] source = { 1, 2, 3, 4, 5, 6 };
            int[] des = new int[3];
            Copy(source, 1, des, 0, 3);
            for (int i = 0; i < des.Length; i++) {
                Console.WriteLine(des[i]);
            }

            Console.ReadLine();

        }

        static void Copy(int[] sourceArray, int sourceIndex, int[] destinationArray, int destinationIndex, int length) {
            for (int i = sourceIndex; i < length + 1; i++) {
                destinationArray[destinationIndex] = sourceArray[i];
                destinationIndex++;
            }
        }
    }
}
