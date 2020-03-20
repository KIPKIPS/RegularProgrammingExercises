using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 栈的压入弹出序列 {
    class Program {
        static void Main(string[] args) {
            Program x = new Program();
            Console.WriteLine(x.IsPopOrder(new[] { 1, 2, 3, 4, 5 }, new[] { 4, 5, 3, 2, 1 }));
            Console.ReadLine();
        }
        Stack<int> pushStack = new Stack<int>();
        public bool IsPopOrder(int[] pushV, int[] popV) {
            // write code here
            if (pushV.Length == 0 || popV.Length == 0) {
                return false;
            }
            int popIndex = 0;
            for (int i = 0; i < pushV.Length; i++) {
                pushStack.Push(pushV[i]);
                //如果栈不为空，且栈顶元素等于弹出序列
                while (pushStack.Count!=0 && pushStack.Peek() == popV[popIndex]) {
                    pushStack.Pop();
                    popIndex++;
                }
            }
            return pushStack.Count == 0;
        }
    }
}
