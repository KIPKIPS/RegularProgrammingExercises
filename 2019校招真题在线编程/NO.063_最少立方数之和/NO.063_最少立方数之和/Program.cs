using System;

namespace NO._063_最少立方数之和 {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine(Fun(29825));
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fun(num));
            Console.ReadLine();
        }

        public static int Fun(int num) {
            for (int i = 1; ; i++) {
                if (i * i * i > num) {
                    num -= (i - 1) * (i - 1) * (i - 1);
                    if (num==0) {
                        //Console.WriteLine("立方数"+(i-1));
                        return 1;
                    }
                    else {
                        //Console.WriteLine("立方数" + (i - 1));
                        return 1 + Fun(num);
                    }
                }
            }
        }
    }
}
