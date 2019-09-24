using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._092_等差数列 {
    class Program {
        static void Main(string[] args) {
            int a = Convert.ToInt32(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] num = new int[input.Length];
            for (int i = 0; i < num.Length; i++)
                num[i] = Convert.ToInt32(input[i]);
            Array.Sort(num);
            string res = "Possible";
            for (int i = 0; i < num.Length - 1; i++)
                if (num[i + 1] - num[i] != num[1] - num[0]) {
                    res = "Impossible";
                    break;
                }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
