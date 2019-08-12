using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 链表倒数第K个节点 {

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode (int x)
    {
        val = x;
    }
}
    class Program {
        static void Main(string[] args) {
            ListNode a=new ListNode(1);
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

            
            Console.WriteLine(FindKthToTail(a, 7).val);
            Console.ReadLine();
        }
        public static ListNode FindKthToTail(ListNode head, int k) {
            // write code here
            int count = 0;
            ListNode temp = head;
            while (temp!=null) {
                count++;
                temp = temp.next;
            }

            if (k <= count) {
                temp = head;
                for (int i = 0; i < count - k; i++) {
                    temp = temp.next;
                }

                return temp;
            }
            else return null;

        }
    }
}
