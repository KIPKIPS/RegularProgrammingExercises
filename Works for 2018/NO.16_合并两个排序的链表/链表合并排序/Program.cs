using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 链表合并排序 {
    class Program {
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int x) {
                val = x;
            }
        }
        static void Main(string[] args) {
            ListNode a=new ListNode(3);
            ListNode b = new ListNode(4);
            ListNode c = new ListNode(5);
            ListNode d = new ListNode(6);
            ListNode e = new ListNode(7);
            a.next = b;b.next = c;c.next = d;d.next = e;
            ListNode f = new ListNode(1);
            ListNode g = new ListNode(2);
            ListNode h = new ListNode(3);
            ListNode i = new ListNode(4);
            f.next = g;g.next = h;h.next = i;
            ListNode j = Merge(a,f);
            while (j!=null) {
                Console.Write(j.val+" ");
                j = j.next;
            }

            Console.ReadLine();
        }
        public static ListNode Merge(ListNode pHead1, ListNode pHead2) {
            // write code here
            ListNode temp1 = pHead1;
            ListNode temp2 = pHead2;
            ListNode newNode=new ListNode(0);
            ListNode temp = newNode;
            while (temp1!=null&&temp2!=null) {
                
                if (temp1.val>temp2.val) {
                    temp.next = temp2;
                    temp = temp.next;
                    temp2 = temp2.next;
                }
                else {
                    temp.next = temp1;
                    temp = temp.next;
                    temp1 = temp1.next;
                }
            }
            if (temp2==null) {
                temp.next = temp1;
            }
            if (temp1 == null) {
                temp.next = temp2;
            }
            return newNode.next;
        }
    }
}
