using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._36_两个链表的第一个公共节点 {
    class Program {
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int x) {
                val = x;
            }
        }
        static void Main(string[] args) {
            Program x=new Program();
            ListNode a=new ListNode(1);
            ListNode b = new ListNode(2);
            ListNode c = new ListNode(3);
            ListNode d = new ListNode(4);
            ListNode e = new ListNode(5);
            ListNode f = new ListNode(6);
            a.next = b; b.next = c; c.next = d;
            d.next = e;e.next = f;

            Console.WriteLine(x.FindFirstCommonNode(a, e).val);
            Console.ReadLine();

        }
        public ListNode FindFirstCommonNode(ListNode pHead1, ListNode pHead2) {
            // write code here
            if (pHead1==null||pHead2==null) {
                return null;
            }
            ListNode temp1 = pHead1;
            while (temp1.next!=null) {
                ListNode temp2 = pHead2;
                while (temp2.next != null) {
                    if (temp1.next==temp2.next) {
                        if (temp1==pHead1) {
                            return temp1;
                        }
                        if (temp2 == pHead2) {
                            return temp2;
                        }
                        return temp1.next;
                    }
                    temp2 = temp2.next;
                    if (temp2==null) {
                        break;
                    }
                }
                temp1 = temp1.next;
                if (temp1==null) {
                    return null;
                }
            }

            return null;
        }
    }
}
