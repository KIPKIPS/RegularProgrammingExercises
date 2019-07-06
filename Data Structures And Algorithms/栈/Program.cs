using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 栈 {
    class Program {
        public static void Main(string[] args) {
            //BCL中的栈
            SeqStack<int> classStack=new SeqStack<int>();//BCL类的实现方式
            //使用自定义的栈
            IStack<int> interfaceStack=new SeqStack<int>();//接口的实现方式,可以解决命名和基类库一致的问题
            interfaceStack.Push(1);
            interfaceStack.Push(2);
            interfaceStack.Push(3);
            interfaceStack.Push(4);
            interfaceStack.Push(5);
            Console.WriteLine("栈顶元素为: "+ interfaceStack.Peek());
            Console.WriteLine(interfaceStack.Count);
            Console.ReadLine();

        }
    }
}
