using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList {
    class Program {
        static void Main(string[] args) {
            LinkedList l=new LinkedList();
            l.AddFromTail(1);
            l.AddFromTail(2);
            l.AddFromTail(3);
            l.AddFromTail(4);
            l.Disp();

            Console.ReadLine();
        }
    }
}
