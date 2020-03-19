using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._021_回文链表 {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) {
            val = x;
        }
    }
    class Program {
        static void Main(string[] args) {
            Console.ReadLine();
        }
        public static bool isPalindrome(ListNode pHead) {
            // write code here
            ListNode temp = pHead;
            string inf = "";
            while (temp!=null) {
                inf += temp.val.ToString();
                temp = temp.next;
            }

            for (int i = 0; i < inf.Length/2; i++) {
                if (inf[i]!=inf[inf.Length-1-i]) {
                    return false;
                }
            }

            return true;
        }
    }
}
