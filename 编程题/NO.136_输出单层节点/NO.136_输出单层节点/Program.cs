using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._136_输出单层节点 {

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) {
            val = x;
        }
    }
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
        public ListNode getTreeLevel(TreeNode root, int dep) {
            if (root == null || dep <= 0)
                return null;
            ListNode listNode = null;
            ListNode headNode = null;
            TreeNode treeNode = null;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int layer = 0;
            int index = 0;
            int size = queue.Count;
            while (queue.Count > 0) {
                index++;
                if (index > size - 1) {
                    layer++;
                    size = queue.Count;
                    index = 0;
                }

                treeNode = queue.Dequeue();
                if (layer == dep) {
                    if (headNode == null) {
                        headNode = new ListNode(treeNode.val);
                        listNode = headNode;
                    }
                    else {
                        listNode.next = new ListNode(treeNode.val);
                        listNode = listNode.next;
                    }

                }
                if (treeNode.left != null)
                    queue.Enqueue(treeNode.left);
                if (treeNode.right != null)
                    queue.Enqueue(treeNode.right);
            }

            return headNode;
        }

    }
}
