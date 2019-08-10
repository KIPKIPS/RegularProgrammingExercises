using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//输入一个链表，按链表值从尾到头的顺序返回一个ArrayList。
namespace 链表倒序返回 {
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
        public List<int> printListFromTailToHead(ListNode listNode) {
            // write code here
            List<int> a=new List<int>();
            while (listNode!=null) {
                a.Add(listNode.val);
                listNode = listNode.next;
            }
            List<int> b = new List<int>();
            for (int i = a.Count-1; i >=0; i--) {
                b.Add(a[i]);
            }

            return b;
        }
    }
}
