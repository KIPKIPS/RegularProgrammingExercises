using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._067_找出单向链表中的一个节点_该节点到尾指针的距离为K {
    class Program {
        public class ListNode {
            public int val;
            public ListNode(int val) {
                this.val = val;
            }
            public ListNode next;
        }
//        public class ListNode {
//            public  int val;
//            public ListNode next;
//        }
        static void Main(string[] args) {
            int index = Convert.ToInt32(Console.ReadLine());
            if (index<=7) {
                ListNode head = new ListNode(1);
                ListNode temp = head;
                for (int i = 2; i <= 7; i++) {
                    ListNode newNode = new ListNode(i);
                    temp.next = newNode;
                    temp = temp.next;
                }

                temp.next = head;
                ListNode newTemp = head;
                int count = 0;
                while (newTemp != null) {
                    if (count == 7-index) {
                        break;
                    }
                    newTemp = newTemp.next;
                    count++;
                }
                Console.WriteLine(newTemp.val);
            }
            Console.ReadLine();
        }
    }
}
