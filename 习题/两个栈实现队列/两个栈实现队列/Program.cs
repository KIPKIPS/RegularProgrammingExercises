using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 两个栈实现队列 {
    class Program {
        
        static void Main(string[] args) {
            //int[][]a=new int[][]{new int[]{1,2,3},new int[]{2,3,4}};
            Program test=new Program();
            test.push(1);
            test.push(2);
            test.push(3);
            test.push(4);
            Console.WriteLine(test.pop());

            Console.ReadLine();
        }
        Stack<int> pushStack = new Stack<int>();
        Stack<int> popStack = new Stack<int>();
        public void push(int node) {
            while (popStack.Count > 0) {
                pushStack.Push(popStack.Pop());
            }
            pushStack.Push(node);
        }
        public int pop() {
            while(pushStack.Count>0) {
                popStack.Push(pushStack.Pop());
            }
            return popStack.Pop();
        }
    }
}
