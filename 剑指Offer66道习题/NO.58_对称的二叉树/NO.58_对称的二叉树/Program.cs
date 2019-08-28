using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._58_对称的二叉树 {
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x) {
            val = x;
        }
    }

    class Program {
        static void Main(string[] args) {
        }

        public bool isSymmetrical(TreeNode pRoot) {
            if (pRoot == null) {
                return true;
            }

            return isCom(pRoot.left, pRoot.right);
        }

        private bool isCom(TreeNode left, TreeNode right) {
            if (left == null) {
                return right == null;
            }

            if (right == null) {
                return false;
            }

            if (left.val != right.val) {
                return false;
            }

            return isCom(left.left, right.right) && isCom(left.right, right.left);
        }

    }
}
