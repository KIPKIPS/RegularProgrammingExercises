using System;
using System.Collections.Generic;

namespace NO._057_求角度 {
    class Program {
        static void Main(string[] args) {
            
            try {
                string[] str = Console.ReadLine().Split(' ');
                Console.WriteLine(Math.Acos(Convert.ToInt32(str[0]) / Math.Sqrt(Convert.ToInt32(str[0]) * Convert.ToInt32(str[0]) + Convert.ToInt32(str[1]) * Convert.ToInt32(str[1]))) / Math.PI * 180);
            }
            catch (Exception e) {
            }
            Console.ReadLine();
        }
    }
}
