using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeqSatck {
    class Program {
        static void Main(string[] args) {
            SeqStack stack=new SeqStack(3);
            stack.Init();
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek()+" "+stack.GetLength());
            Console.ReadLine();

        }
    }
}
