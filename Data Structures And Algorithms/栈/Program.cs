using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 栈 {
    class Program {
        static void Main(string[] args) {
            //BCL中的栈
            Stack<int> sta=new Stack<int>();
            sta.Push(1);
            sta.Push(2);
            sta.Push(3);
            sta.Push(4);
            sta.Push(5);
            Console.WriteLine("栈顶元素为: "+sta.Peek());
            Console.WriteLine(sta.Count);
            Console.ReadLine();
        }
    }
}
