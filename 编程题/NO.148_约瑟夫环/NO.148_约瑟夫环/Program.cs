using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._148_约瑟夫环 {
    
    class Program {
        public class Node {
            public bool inside;
            public int index;
            public Node next;
            public Node(bool x,int index) {
                inside = x;
                this.index = index;
            }
        }
        static void Main(string[] args) {
            Node a=new Node(true,1);
            Node b = new Node(true, 2);
            Node c = new Node(true, 3);
            Node d = new Node(true, 4);
            Node e = new Node(true, 5);
            Node f = new Node(true, 6);
            Node g = new Node(true, 7);
            a.next = b;b.next = c;c.next = d;d.next = e;
            e.next = f;f.next = g;
            g.next = a;
            int count = 0;
            int outNum = 0;
            int n = 7;
            int m = 4;
            Node temp = a;
            while (outNum < n-1) {
                count++;
                //Console.WriteLine(count);
                if (count == m) {
                    if (temp.inside==false) {
                        while (temp.inside ==false) {
                            temp = temp.next;
                        }
                        Console.WriteLine(temp.index);
                        temp.inside = false;
                    }
                    else {
                        Console.WriteLine(temp.index);
                        temp.inside = false;
                        temp = temp.next;
                    }
                    count = 0;
                    outNum++;
                }
                else {
                    if (temp.next.inside==true) {
                        temp = temp.next;
                    }
                    else {
                        while (temp.inside == false) {
                            temp = temp.next;
                        }
                    }
                    //count++;
                }
                //Console.WriteLine(outNum);
            }
//            Console.WriteLine(a.index+" "+a.inside);
//            Console.WriteLine(b.index + " " + b.inside);
//            Console.WriteLine(c.index + " " + c.inside);
//            Console.WriteLine(d.index + " " + d.inside);
//            Console.WriteLine(e.index + " " + e.inside);
//            Console.WriteLine(f.index + " " + f.inside);
//            Console.WriteLine(g.index + " " + g.inside);
            Console.ReadLine();
        }
        public static int getResult(int n, int m) {
            // write code here
            //建立环路链表
            Node head=new Node(true,1);
            Node temp = head;
            for (int i = 0; i < n-1; i++) {
                Node newNode=new Node(true,i+2);
                temp.next = newNode;
                temp = temp.next;
            }
            temp.next = head;//链表尾指向链表头,环路建立
            temp = head;
            int count = 0;
            int outNum = 0;
            //删除数据
            while (outNum < n) {
                count++;
                if (count == m) {
                    if (temp.inside) {
                        while (temp.next.inside == false) {
                            temp = temp.next;
                        }
                    }
                    else {
                        temp.inside = false;
                        temp = temp.next;
                    }
                    count = 1;
                    outNum++;

                }
                else {
                    while (temp.next.inside == false) {
                        temp = temp.next;
                    }
                    //count++;
                }
            }
            temp = head;
            for (int i = 0; i < n; i++) {
                if (temp.inside!=false) {
                    return temp.index;
                }
                temp = temp.next;
            }
            return 0;
        }
    }
}
