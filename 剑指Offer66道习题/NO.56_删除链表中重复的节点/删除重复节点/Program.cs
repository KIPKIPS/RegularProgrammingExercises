using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 删除重复节点 {
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
            ListNode b = new ListNode(1);
            ListNode c = new ListNode(3);
            ListNode d = new ListNode(3);
            ListNode e = new ListNode(6);
            ListNode f = new ListNode(4);
            ListNode g = new ListNode(4);
            a.next = b; b.next = c; c.next = d; d.next = e; e.next = f;
            f.next = g;
            
            ListNode temp = deleteDuplication(a);
            while (temp != null) {
                Console.Write(temp.val + " ");
                temp = temp.next;
            }

            Console.ReadLine();

        }
        public static ListNode deleteDuplication(ListNode pHead) {
            // write code here
            if (pHead == null || pHead.next == null) { return pHead; }
            ListNode newHead = new ListNode(0);
            newHead.next = pHead;
            ListNode sure = newHead;
            ListNode unsure = newHead.next;
            while (unsure != null) {
                if (unsure.next != null && unsure.val == unsure.next.val) {
                    while (unsure.next != null && unsure.val == unsure.next.val) {
                        unsure = unsure.next;
                    }
                    sure.next = unsure.next;
                    unsure = unsure.next;
                }
                else {
                    sure = sure.next;
                    unsure = unsure.next;
                }
            }
            return newHead.next;
        }
    }
}
