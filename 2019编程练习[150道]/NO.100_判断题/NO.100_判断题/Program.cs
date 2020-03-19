using System;
namespace NO._100_判断题 {
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            int[] a ={ int.Parse(input[1]), int.Parse(input[0]) - int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[0]) - int.Parse(input[2]) };
            Console.WriteLine((a[0] > a[2] ? a[2] : a[0]) + (a[1] > a[3] ? a[3] : a[1]));
        }
    }
}
