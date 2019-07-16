using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 栈和队列的应用_判断回文字符串 {
    class Program {
        static void Main(string[] args) {
            string str = Console.ReadLine();
            Stack<char> stack=new Stack<char>();
            Queue<char> queue=new Queue<char>();
            for (int i = 0; i < str.Length; i++) {
                stack.Push(str[i]);
                queue.Enqueue(str[i]);
            }

            //方法一
            //for (int i = 0; i < str.Length; i++) {
            //    if (stack.Peek()==queue.Peek()) {
            //        stack.Pop();
            //        queue.Dequeue();
            //    }
            //    else {
            //        Console.WriteLine("你输入的不是回文串");
            //        break;
            //    }
            //    if (stack.Count == 0 && queue.Count == 0) {
            //        Console.WriteLine("你输入的是回文串");
            //    }
            //}

            //方法二
            bool isHui = true;
            while (stack.Count!=0) {
                if (stack.Pop() != queue.Dequeue()) {
                    isHui = false;
                    break;
                }
            }
            string output=isHui == true ? "你输入的是回文串" :"你输入的不是回文串";
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
