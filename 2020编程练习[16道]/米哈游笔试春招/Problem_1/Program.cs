using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1 {
    class Program {
        struct CharIndex {
            public char ch;
            public int index;
        }
        static void Main(string[] args) {
            string inp = Console.ReadLine();
            CharIndex[] charIndex = new CharIndex[inp.Length];
            for (int i = 0; i < inp.Length; i++) {
                charIndex[i].ch = inp[i];
                charIndex[i].index = i;
            }
            List<int> index = new List<int>();
            Stack<CharIndex> stack = new Stack<CharIndex>();
            for (int i = 0; i < inp.Length; i++) {
                if (inp[i] == '(') {
                    CharIndex temp = new CharIndex {
                        ch = '(',
                        index = i
                    };
                    stack.Push(temp);
                }
                if (inp[i] == ')') {
                    if (stack.Count > 0) {
                        if (stack.Peek().ch == '(') {
                            stack.Pop();
                        }
                        else {
                            index.Add(i);
                        }
                    }
                    else {
                        index.Add(i);
                    }
                }
            }
            
            while (stack.Count!=0) {
                index.Add(stack.Peek().index);
                stack.Pop();
            }
            string res = "";
            if (index.Count!=0) {
                for (int i = 0; i < inp.Length; i++) {
                    for (int j = 0; j < index.Count; j++) {
                        if (i!=index[j]) {
                            res += inp[i];
                        }
                    }
                }
            }
            else {
                res = inp;
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
