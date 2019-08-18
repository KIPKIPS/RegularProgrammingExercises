using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 从上往下打印二叉树 {
    class Program {
        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) {
                val = x;
            }
        }
        static void Main(string[] args) {
        }
        List<int> res=new List<int>();
        Queue<TreeNode> opa=new Queue<TreeNode>();
        public List<int> PrintFromTopToBottom(TreeNode root) {
            // write code here
            if (root==null) {
                return res;
            }
            res.Add(root.val);
            if (root.left!=null) {
                opa.Enqueue(root.left);
            }
            if (root.right != null) {
                opa.Enqueue(root.right);
            }

            if (opa.Count!=0) {
                PrintFromTopToBottom(opa.Dequeue());
            }
            return res;
        }


    }
}
