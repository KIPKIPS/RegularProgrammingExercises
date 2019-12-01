using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._015_链表分割 {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) {
            val = x;
        }
    }
    class Program {
        static void Main(string[] args) {
            ListNode a=new ListNode(7);
            ListNode b = new ListNode(3);
            ListNode c = new ListNode(4);
            ListNode d = new ListNode(5);
            ListNode e = new ListNode(8);
            ListNode f = new ListNode(1);
            a.next = b;b.next = c;c.next = d;d.next = e;
            e.next = f;
            ListNode newHead=partition(a, 5);
            ListNode temp = newHead;
            while (temp!=null) {
                Console.WriteLine(temp.val);
                temp = temp.next;
            }
            Console.ReadLine();

        }
        public static ListNode partition(ListNode pHead, int x) {
            // write code here
            ListNode less=new ListNode(0);
            ListNode tempL = less;
            ListNode more=new ListNode(0);
            ListNode tempM = more;
            ListNode temp = pHead;
            while (temp!=null) {
                if (temp.val<x) {
                    ListNode newT=new ListNode(temp.val);
                    tempL.next = newT;
                    tempL = tempL.next;
                }
                else {
                    ListNode newT = new ListNode(temp.val);
                    tempM.next = newT;
                    tempM = tempM.next;
                }
                temp = temp.next;
            }
            tempL.next = more.next;
            return less.next;
        }
    }
}
