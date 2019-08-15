using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._18_二叉树的镜像 {
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
        public TreeNode Mirror(TreeNode root) {
            // write code here
            if (root==null) {
                return null;
            }
            if (root.left!=null||root.right!=null) {
                TreeNode temp = root.right;
                root.right = root.left;
                root.left = temp;
                Mirror(root.right);
                Mirror(root.left);
            }
            return root;
        }
    }
}
