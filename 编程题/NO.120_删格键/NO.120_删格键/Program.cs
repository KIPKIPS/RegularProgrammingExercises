using System;
using System.Collections.Generic;

namespace NO._120_删格键 {
    //模拟栅格键,例:Y;123Y12    输出1212
    class Program {
        static void Main(string[] args) {
            Stack<char> stack = new Stack<char>();
            string temp = Console.ReadLine();
            string[] a = temp.Split(';');
            char b = temp[0];
            for (int i = 0; i < a[1].Length; i++) {
                if (a[1][i] != b)
                    stack.Push(a[1][i]);
                if (a[1][i] == b && stack.Count != 0)
                    stack.Pop();
            }
            string mid = "";
            while (stack.Count != 0)
                mid = stack.Pop() + "" + mid;
            Console.WriteLine(mid);
            Console.ReadLine();
        }
    }
}
