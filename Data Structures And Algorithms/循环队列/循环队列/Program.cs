using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环队列 {
    class Program {
        static void Main(string[] args) {
            LoopQueue lq=new LoopQueue(3);
            lq.EnQueue(2);
            lq.EnQueue(3);
            lq.EnQueue(4);
            Console.WriteLine(lq.rear);
            Console.WriteLine(lq.IsEmpty());
            Console.WriteLine(lq.IsFull());
            Console.ReadLine();
        }
    }
}
