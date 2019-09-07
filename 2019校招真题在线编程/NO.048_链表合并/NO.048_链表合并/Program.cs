using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._048_链表合并 {
    class Program {
        //定义链表节点的数据结构
        public class ListNode {
            public int val;
            public ListNode(int val) {
                this.val = val;
            }
            public ListNode next;
        }
        static void Main(string[] args) {
            //读取第一个有序数组并转换成int类型的数组
            string[] inp = Console.ReadLine().Split(' ');
            int[] num=new int[inp.Length];
            for (int i = 0; i < inp.Length; i++) {
                num[i] = Convert.ToInt32(inp[i]);
            }
            //读取第二个有序数组并转换成int类型的数组
            string[] inp2 = Console.ReadLine().Split(' ');
            int[] num2 = new int[inp2.Length];
            for (int i = 0; i < inp2.Length; i++) {
                num2[i] = Convert.ToInt32(inp2[i]);
            }
            //申请存取两个数组和的有序数组
            int[]sum=new int[inp.Length+inp2.Length];
            for (int i = 0; i < sum.Length; i++) {
                if (i<num.Length) {
                    sum[i] = num[i];
                }
                else {
                    sum[i] = num2[i - num.Length];
                }
            }
            //排序
            Array.Sort(sum);
            //申请链表的头节点
            ListNode head=new ListNode(sum[0]);
            ListNode temp = head;
            for (int i = 1; i < sum.Length; i++) {
                ListNode newListNode=new ListNode(sum[i]);
                temp.next = newListNode;
                temp = temp.next;
            }
            //将链表输出
            ListNode te = head;
            while (te!=null) {
                if (te.next==null) {
                    Console.Write(te.val);
                }
                else {
                    Console.Write(te.val + " ");
                }
                te = te.next;
            }
            Console.ReadLine();
        }
    }
}
