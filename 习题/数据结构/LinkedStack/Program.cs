using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedStack {
    class Program {
        static void Main(string[] args) {
            while (true) {
                Console.WriteLine("请输入字符串 : ");
                string input = Console.ReadLine();
                Console.WriteLine(ParenthesisMatching(input));
                //ParenthesisMatching(input);
            }
        }

        public static string ParenthesisMatching(string str) {
            bool left = true;
            if (str.Length!=0) {
                LinkedStack stack = new LinkedStack();
                for (int i = 0; i < str.Length; i++) {
                    switch (str[i]) {
                        case '(':
                            if (left) {
                                stack.Push(0);
                            }
                            else {
                                return "左(多余";
                            }
                            break;
                        case '[':
                            if (left == true) {
                                stack.Push(1);
                            }
                            else {
                                return "左[多余";
                            }
                            break;
                        case '{':
                            if (left == true) {
                                stack.Push(2);
                            }
                            else {
                                return "左{多余";
                            }
                            break;
                        case ')':
                            if (!stack.IsEmpty()) {
                                int temp = 0;
                                if (stack.Peek() == temp) {
                                    stack.Pop();
                                    left = false;
                                }
                                else {
                                    return "右)不匹配";
                                }
                            }
                            else {
                                return "右)多余";
                            }
                            
                            break;
                        case ']':
                            if (!stack.IsEmpty()) {
                                int temp = 1;
                                if (stack.Peek() == temp) {
                                    stack.Pop();
                                    left = false;
                                }
                                else {
                                    return "右]不匹配";
                                }
                            }
                            else {
                                return "右]多余";
                            }
                            break;
                        case '}':
                            if (!stack.IsEmpty()) {
                                int temp = 2;
                                if (stack.Peek() == temp) {
                                    stack.Pop();
                                    left = false;
                                }
                                else {
                                    return "右}不匹配";
                                }
                            }
                            else {
                                return "右}多余";
                            }
                            break;
                    }
                }
                if (stack.IsEmpty()) {
                    return "匹配";
                }
                else {
                    switch (stack.Peek()) {
                        case '[': return "左[多余";
                        case '{': return "左{多余"; 
                        case '(': return "左(多余"; 
                        case ']': return "右]多余"; 
                        case '}': return "右}多余"; 
                        case ')': return "右)多余";
                        default: return "1";
                    }
                }
            }
            else {
                return "空串";
            }
        }
    }
}
