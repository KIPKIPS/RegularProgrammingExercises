using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._016_链式A_B {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) {
            val = x;
        }
    }
    class Program {
        static void Main(string[] args) {
            ListNode a=new ListNode(1); ListNode b = new ListNode(8); ListNode c = new ListNode(3);
            ListNode d = new ListNode(6); ListNode e = new ListNode(8); ListNode f = new ListNode(7); ListNode g = new ListNode(1);
            a.next = b;b.next = c;
            d.next = e;e.next = f;f.next = g;
            ListNode x = plusAB(a, d);
            ListNode temp = x;
            while (temp!=null) {
                Console.Write(temp.val+" ");
                temp = temp.next;
            }

            Console.ReadLine();
        }
        public static ListNode plusAB(ListNode a, ListNode b) {
            // write code here
            ListNode tA = a;
            ListNode tB = b;
            int numA = 0;
            int numB = 0;
            int powA = 0;
            int powB = 0;
            while (tA!=null) {
                numA += tA.val * (int)Math.Pow(10, powA);
                tA = tA.next;
                powA++;
            }
            while (tB != null) {
                numB += tB.val * (int)Math.Pow(10, powB);
                tB = tB.next;
                powB++;
            }

            int n = numA + numB;
            string sum = ""+n;
            ListNode newHead=new ListNode(0);
            ListNode t = newHead;
            for (int i = sum.Length-1; i >=0 ; i--) {
                ListNode temp=new ListNode(int.Parse(sum[i]+""));
                t.next = temp;
                t = t.next;
            }
            return newHead.next;
        }
    }
}
