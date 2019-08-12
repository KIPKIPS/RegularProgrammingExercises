using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反转链表输出表头 {
    class Program {
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int x) {
                val = x;
            }
        }
        static void Main(string[] args) {
            ListNode a = new ListNode(1);
            ListNode b = new ListNode(2);
            ListNode c = new ListNode(3);
            ListNode d = new ListNode(4);
            ListNode e = new ListNode(5);
            ListNode f = new ListNode(6);
            a.next = b;
            b.next = c;
            c.next = d;
            d.next = e;
            e.next = f;


            Console.WriteLine(ReverseList(a).next.next.next.next.next.val);
            Console.ReadLine();
        }
        public static ListNode ReverseList(ListNode pHead) {
            if (pHead==null) {
                return null;
            }
            ListNode head = pHead;
            List<ListNode> a = new List<ListNode>();
            while (head != null) {
                a.Add(head);
                head = head.next;
            }

            for (int i = a.Count - 1; i >= 1; i--) {
                a[i].next = a[i - 1];
            }
            a[0].next = null;
            return a[a.Count - 1];

        }
    }
}
