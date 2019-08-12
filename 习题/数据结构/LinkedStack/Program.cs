using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedStack {
    class Program {
        static void Main(string[] args) {
            LinkedStack stack=new LinkedStack();
            stack.Push(1);
            stack.Push(2);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.GetLength());
            Console.ReadLine();
        }
    }
}
