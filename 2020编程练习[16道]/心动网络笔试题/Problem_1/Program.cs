using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1 {
    class Program {
        static void Main(string[] args) {
            string[] inp = Console.ReadLine().Split(' ');
            string ori=inp[0];//源字符串
            string tar = inp[1];//目标字符串
            Stack<char> stack=new Stack<char>();
            string op = "";
            while (true) {
                if (ori==""&&tar!="") {
                    op = "-1";
                    break;
                }
                if (ori==""&&tar=="") {
                    break;
                }
                else {
                    if (ori[ori.Length-1]==tar[0]) {
                        op += "ED";
                        ori = ori.Substring(0, ori.Length - 1);
                        tar = tar.Substring(1, tar.Length-1);
                        //Console.WriteLine(ori+" "+tar);
                    }
                    else {
                        if (stack.Count != 0) {
                            if (stack.Peek() == tar[0]) {
                                tar = tar.Substring(1, tar.Length - 1);
                                stack.Pop();
                                op += "D";
                            }
                            else {
                                stack.Push(ori[ori.Length - 1]);
                                ori = ori.Substring(0, ori.Length - 1);
                                op += "E";
                            }
                        }
                        else {
                            stack.Push(ori[ori.Length - 1]);
                            ori = ori.Substring(0, ori.Length - 1);
                            op += "E";
                        }
                    }
                }
            }
            Console.WriteLine(op);
            Console.ReadLine();
        }
    }
}
