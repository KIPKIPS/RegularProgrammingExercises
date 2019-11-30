using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._013_链表中倒数第K个节点 {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) {
            val = x;
        }
    }
    class Program {
        static void Main(string[] args) {
        }
        public static ListNode FindKthToTail(ListNode head, int k) {
            //计算链表长度
            int count = 0;
            ListNode temp = head;
            while (temp != null) {
                count++;
                temp = temp.next;
            }
            //验证K的合法性,不合法返回null
            if (k <= count) {
                temp = head;
                //向下查找倒数第K个节点
                for (int i = 0; i < count - k; i++) {
                    temp = temp.next;
                }
                return temp;
            }
            else return null;
        }
    }
}
