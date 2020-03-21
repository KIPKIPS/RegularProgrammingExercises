using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 删除重复节点 {
    class Program {
        class Node {
            public int val;
            public Node next;
            public Node(int x) {
                val = x;
            }
        }
        static void Main(string[] args) {
            Node a=new Node(1);
            Node b = new Node(2);
            Node c = new Node(2);
            Node d = new Node(2);
            Node e = new Node(3);
            Node f = new Node(4);
            Node g = new Node(4);
            Node h = new Node(5);
            a.next = b;b.next = c;c.next = d;d.next = e;e.next = f;f.next = g;g.next = h;
            DeleteRepeatNode(a);
            Console.ReadLine();

        }

        static Node DeleteRepeatNode(Node head) {
            Node newTemp = new Node(0);
            Node newHead = newTemp;
            Node temp = head;
            List< int>res=new List<int>();
            HashSet<int>del=new HashSet<int>();
            while (temp!=null) {
                if (temp.next!=null) {
                    if (temp.val != temp.next.val && del.Contains(temp.val) == false) {
                        newTemp.next = temp;
                        res.Add(temp.val);
                        newTemp = newTemp.next;
                        temp = temp.next;
                    }
                    else {
                        if (del.Contains(temp.val) == false) {
                            del.Add(temp.val);
                        }
                        temp = temp.next;
                    }
                }
                else {
                    if (!del.Contains(temp.val)) {
                        newTemp.next = temp;
                        res.Add(temp.val);
                    }
                    break;
                }
                
            }
            foreach (var VARIABLE in res) {
                Console.WriteLine(VARIABLE);
            }

            Console.WriteLine(newHead.next.val);
            Console.WriteLine(newHead.next.next.val);
            Console.WriteLine(newHead.next.next.next.val);
            return newHead.next;
        }
    }
}
