using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 链表中环的入口节点 {
    class Program {
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int x) {
                val = x;
            }
        }
        static void Main(string[] args) {
        }
        public ListNode EntryNodeOfLoop(ListNode pHead) {
            // write code here
            ListNode temp = pHead;
            if (pHead==null) {
                return temp;
            }
            if (pHead.next==pHead) {
                return pHead;
            }
            if (pHead.next==null) {
                return null;
            }
            Dictionary<ListNode,int> dic=new Dictionary<ListNode, int>();
            dic.Add(pHead,1);
            while (temp.next!=null) {
                
                if (dic.ContainsKey(temp.next)) {
                    return temp.next;
                }
                else {
                    temp = temp.next;
                    dic.Add(temp, 1);
                }
            }
            return null;

        }
    }
}
