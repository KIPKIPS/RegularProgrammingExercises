using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环链表 {
    class Program {
        class Node {
            public int data;
            public Node next;
            public Node(int x) {
                data = x;
            }
        }

        static void Main(string[] args) {
            Node a=new Node(1);
            Node b = new Node(2);
            Node c = new Node(3);
            Node d = new Node(4);
            a.next = b;b.next = c;c.next = d;d.next = b;
            Console.WriteLine(IsLoopList(a));
            Console.ReadLine();
        }

        static bool IsLoopList(Node head) {
            HashSet<Node>map=new HashSet<Node>();
            Node temp = head;
            while (temp!=null) {
                if (!map.Contains(temp)) {
                    map.Add(temp);
                    temp = temp.next;
                }
                else {
                    return true;
                }
            }
            return false;
        }
    }
}
