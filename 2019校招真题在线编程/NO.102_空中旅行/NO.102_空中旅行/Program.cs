using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._102_空中旅行 {
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            int capacity = int.Parse(input[1]);
            string[] input2 = Console.ReadLine().Split(' ');
            int[] num = new int[input2.Length];
            for (int i = 0; i < input2.Length; i++)
                num[i] = int.Parse(input2[i]);
            int times = 0;
            for (int i = 0; i < num.Length; i++) {
                if (capacity >= num[i]) {
                    capacity -= num[i];
                    times++;
                }
                else
                    break;
            }
            Console.WriteLine(times);
            Console.ReadLine();
        }
    }
}
