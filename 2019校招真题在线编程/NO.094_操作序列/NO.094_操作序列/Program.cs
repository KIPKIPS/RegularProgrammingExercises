using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._094_操作序列 {
    class Program {
//        static void Test(string[] args) {
//            Console.ReadLine();
//            string input = Console.ReadLine().Replace(" ","");
//            string temp = "";
//            for (int i = 0; i < input.Length; i++) {
//                temp += input[i] + "";
//                string n = "";
//                for (int j = temp.Length-1; j >=0; j--) {
//                    n += temp[j] + "";
//                }
//                temp = n+" ";
//            }
//            Console.WriteLine(temp.Trim());
//            Console.ReadLine();
//        }
        static void Main(string[] args) {
            Console.ReadLine();
            string[] input = Console.ReadLine().Split(' ');
            Stack<string> A=new Stack<string>();
            A.Push(input[0]);
            Stack<string> B = new Stack<string>();
            int num = 0;
            for (int i = 1; i < input.Length; i++) {
                if (num%2==0) {
                    if (B.Count!=0) {
                        while (B.Count!=0) {
                            A.Push(B.Pop());
                        }
                    }
                    A.Push(input[i]);
                }
                else {
                    if (A.Count != 0) {
                        while (A.Count != 0) {
                            B.Push(A.Pop());
                        }
                    }
                    B.Push(input[i]);
                }
                num++;
            }

            if (input.Length%2!=0) {
                while (B.Count != 0) {
                    if (B.Count == 1) {
                        Console.Write(B.Pop());
                    }
                    else {
                        Console.Write(B.Pop() + " ");
                    }
                }
            }
            else {
                while (A.Count != 0) {
                    if (A.Count == 1) {
                        Console.Write(A.Pop());
                    }
                    else {
                        Console.Write(A.Pop() + " ");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
