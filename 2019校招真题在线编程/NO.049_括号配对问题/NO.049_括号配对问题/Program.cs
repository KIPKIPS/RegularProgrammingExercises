using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NO._049_括号配对问题 {
    class Program {
        static void Main(string[] args) {
            string inp = Console.ReadLine();
            if (IsMatch(inp)) {
                Console.WriteLine("true");
            }
            else {
                Console.WriteLine("false");
            }
            Console.ReadLine();
        }

        public static bool IsMatch(string str) {
            Stack<char> bracket = new Stack<char>();
            for (int i = 0; i < str.Length; i++) {
                if (str[i] == '(' ||str[i]=='[') {
                    bracket.Push(str[i]);
                }
                if (str[i]==')'||str[i]==']') {
                    if (bracket.Count==0) {
                        return false;
                    }
                    if (bracket.Peek()!='('&& str[i] == ')') {
                        return false;
                    }
                    if (bracket.Peek() != '[' && str[i] == ']') {
                        return false;
                    }
                    if (bracket.Count!=0&& bracket.Peek() == '[' && str[i] == ']') {
                        bracket.Pop();
                    }
                    if (bracket.Count != 0 && bracket.Peek() == '(' && str[i] == ')') {
                        bracket.Pop();
                    }
                    
                }
            }

            if (bracket.Count==0) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
