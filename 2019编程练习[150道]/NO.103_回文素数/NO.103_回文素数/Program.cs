using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._103_回文素数 {
    class Program {
        static void Main(string[] args) {
            string[] str = Console.ReadLine().Split(' ');
            Console.WriteLine(PalindromePrimesNum(int.Parse(str[0]), int.Parse(str[1])));
        }

        public static int PalindromePrimesNum(int l, int r) {
            int count = 0;
            for (int i = l; i <= r; i++)
                if (IsPrime(i) && IsPalindrome(i + ""))
                    count++;
            return count;
        }

        public static bool IsPrime(int num) {
            if (num == 1)
                return false;
            if (num == 2)
                return true;
            for (int i = 2; i < Math.Sqrt(num) + 1; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        public static bool IsPalindrome(string str) {
            for (int i = 0; i < str.Length / 2; i++)
                if (str[i] != str[str.Length - i - 1])
                    return false;
            return true;
        }
    }
}
