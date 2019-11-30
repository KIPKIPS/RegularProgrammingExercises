using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._014_访问单个节点的删除 {
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
        public static bool removeNode(ListNode pNode) {
            // write code here
            if (pNode == null || pNode.next == null)
                return false;
            else
                pNode = pNode.next;
            return true;
        }
    }
}
