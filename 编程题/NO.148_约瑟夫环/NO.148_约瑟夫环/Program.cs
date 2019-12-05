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
            a.next = b;b.next = c;c.next = d;d.next = e;
            e.next = f;f.next = a;
            int count = 0;
            int outNum = 0;
            int n = 6;
            int m = 4;
            Node temp = a;
            while (outNum < n) {
                count++;
                Console.WriteLine(count);
                if (count == m) {
                    //Console.WriteLine(temp.index);
                    if (temp.inside==false) {
                        while (temp.next.inside ==false) {
                            temp = temp.next;
                        }
                        temp.inside = false;
                    }
                    else {
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
                        while (temp.next.inside == false) {
                            temp = temp.next;
                        }
                    }
                   
                    //count++;
                }
                //Console.WriteLine(outNum);
            }
            
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
