using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单表达式计算 {
    class Program {
        static void Main(string[] args) {
            List<string> input=new List<string>();
            while (true) {
                string temp = Console.ReadLine();
                if ( temp == "END") 
                    break;
                input.Add(temp);
            }
            List<int>res=new List<int>();
            for (int i = 0; i < input.Count; i++) {
                res.Add(Calculate(input[i]));
            }
            foreach (var VARIABLE in res) {
                Console.WriteLine(VARIABLE);
            }
            Console.ReadLine();
        }

        static int Calculate(string obj) {
            Stack<char>op=new Stack<char>();
            Stack<int>num=new Stack<int>();
            //处理乘法
            for (int i = 0;;) {
                if (i<obj.Length) {
                    if (obj[i] >= 48 && obj[i] <= 57 && i < obj.Length) {
                        num.Push(int.Parse(obj[i] + ""));
                        i++;
                    }
                    if (obj[i] == '*') {
                        num.Push(num.Pop() * int.Parse(obj[i + 1] + ""));
                        i += 2;
                    }
                    if (obj[i] == '-' || obj[i] == '+' && i < obj.Length) {
                        op.Push(obj[i]);
                        i++;
                    }
                }
                else {
                    break;
                }
                
            }

            foreach (var VARIABLE in op) {
                Console.WriteLine(VARIABLE);
            }

            foreach (var VARIABLE in num) {
                Console.WriteLine(VARIABLE);
            }

            Console.ReadLine();
            //
            Stack<char>op2=new Stack<char>();
            Stack<int>num2=new Stack<int>();
            while (op.Count!=0) {
                op2.Push(op.Pop());
            }
            while (num.Count!=0) {
                num2.Push(num.Pop());
            }

            while (op2.Count!=0) {
                if (op2.Pop()=='-') {
                    num2.Push(num2.Pop()-num2.Pop());
                }
                else {
                    num2.Push(num2.Pop() + num2.Pop());
                }
            }
            return num2.Peek();
        }
    }
}
