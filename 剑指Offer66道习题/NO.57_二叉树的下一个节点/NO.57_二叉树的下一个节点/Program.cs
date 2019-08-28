using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._57_二叉树的下一个节点 {
    class Program {
        public class TreeLinkNode {
            public int val;
            public TreeLinkNode left;
            public TreeLinkNode right;
            public TreeLinkNode next;
            public TreeLinkNode(int x) {
                val = x;
            }
        }
        static void Main(string[] args) {
        }
        public TreeLinkNode GetNext(TreeLinkNode pNode) {
            // write code here
            if (pNode == null)
                return null;
            if (pNode.right != null) {    //如果有右子树，则找右子树的最左节点
                pNode = pNode.right;
                while (pNode.left != null) pNode = pNode.left;
                return pNode;
            }

            while (pNode.next != null) { //没右子树，则找第一个当前节点是父节点左孩子的节点的父节点
                if (pNode.next.left == pNode) return pNode.next;
                pNode = pNode.next;
            }
            return null;   //退到了根节点仍没找到，则返回null
        }
    }
}
