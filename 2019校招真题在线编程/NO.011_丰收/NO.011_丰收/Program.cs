using System;
using System.Collections.Generic;

namespace NO._011_丰收 {
    class Program {
        static void Main(string[] args) {
            int num = Convert.ToInt32(Console.ReadLine());
            int[]pile=new int[num];
            string inp = Console.ReadLine();
            string[] temp = inp.Split(' ');
            for (int i = 0; i < temp.Length; i++) {
                pile[i] = Convert.ToInt32(temp[i]);
            }

            int num2 = Convert.ToInt32(Console.ReadLine());
            string inp2 = Console.ReadLine();
            string[] temp2 = inp2.Split(' ');
            int[]arr=new int[temp2.Length];
            for (int i = 0; i < temp2.Length; i++) {
                arr[i] = Convert.ToInt32(temp2[i]);
            }
            fun(arr,pile);
            Console.ReadLine();
        }
        public static void fun(int[]arr,int[]pile) {
            for (int i = 0; i < arr.Length; i++) {
                int sum = 0;
                for (int j = 0; j < pile.Length; j++) {
                    sum += pile[j];
                    if (arr[i] <= sum) {
                        Console.WriteLine(j + 1);
                        break;
                    }
                }
            }
        }
    }
}
