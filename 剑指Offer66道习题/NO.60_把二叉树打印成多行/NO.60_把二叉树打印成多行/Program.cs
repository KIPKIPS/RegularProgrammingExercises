using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._60_把二叉树打印成多行 {
    class Program {
        static void Main(string[] args) {
        }
        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) {
                val = x;
            }
        }
        
        List<List<int>>all=new List<List<int>>();
        Queue<TreeNode>treeNode=new Queue<TreeNode>();
        public List<List<int>> Print(TreeNode pRoot) {
            // write code here
            if (pRoot==null) {
                return all;
            }
            List<int> layer = new List<int>();
            layer.Add(pRoot.val);
            if (pRoot.left!=null) {
                treeNode.Enqueue(pRoot.left);
            }

            if (pRoot.right!=null) {
                treeNode.Enqueue(pRoot.right);
            }

            if (treeNode.Count!=0) {
                Print(treeNode.Dequeue());
            }
            return all;
        }
    }
}
