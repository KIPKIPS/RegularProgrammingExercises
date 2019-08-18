using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 丑数 {
    class Program {
        static void Main(string[] args) {
            Program x = new Program();


            Console.WriteLine(x.GetUglyNumber_Solution(5));
            
            Console.ReadLine();
        }
        public int GetUglyNumber_Solution(int index) {
            if (index < 7)
                return index;

            int n2 = 0, n3 = 0, n5 = 0;
            int temp, count = 0, max = 0;
            int[] num = new int[index];
            num[0] = 1;
            for (int i = 1; i < index; i++) {
                num[i] = Math.Min(num[n2] * 2, Math.Min(num[n3] * 3, num[n5] * 5));
                if (num[i] == num[n2] * 2) n2++;
                if (num[i] == num[n3] * 3) n3++;
                if (num[i] == num[n5] * 5) n5++;
            }
            return num[index - 1];
        }

        public bool IsUglyNumber(int num) {
            while (num % 2 == 0)
                num /= 2;
            while (num % 3 == 0)
                num /= 3;
            while (num % 5 == 0)
                num /= 5;
            return num == 1;
        }
    }
}
