using System;

namespace NO._040_员工考勤记录 {
    class Program {
        static void Main(string[] args) {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            //int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(1 + n + n * (n - 1) / 2);
        }
    }
}
