using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 链栈 {
    class Program {
        static void Main(string[] args) {
            LinkStack<int> linkStack=new LinkStack<int>();
            linkStack.Push(1);
            linkStack.Push(2);
            linkStack.Push(3);
            linkStack.Push(4);
            linkStack.Push(5);
            linkStack.Push(6);
            Console.WriteLine(linkStack.GetLength());
            Console.WriteLine(linkStack.Count);
            while (linkStack.Count!=0) {
                Console.Write(linkStack.Pop()+" ");
            }

            Console.ReadLine();
        }
    }
}
