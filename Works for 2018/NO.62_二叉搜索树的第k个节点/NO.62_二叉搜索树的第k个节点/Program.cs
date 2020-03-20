using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._62_二叉搜索树的第k个节点 {
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
        List<TreeNode>coll=new List<TreeNode>();
        public TreeNode KthNode(TreeNode pRoot, int k) {
            // write code here
            if (pRoot==null||k==0) {
                return null;
            }
            Ino(pRoot);
            if (k>coll.Count) {
                return null;
            }
            return coll[k - 1];
        }

        public List<TreeNode> Ino(TreeNode root) {
            if (root==null) {
                return null;
            }
            if (root.left!=null) {
                Ino(root.left);
            }
            coll.Add(root);
            if (root.right!=null) {
                Ino(root.right);
            }
            return coll;
        }
    }
}
