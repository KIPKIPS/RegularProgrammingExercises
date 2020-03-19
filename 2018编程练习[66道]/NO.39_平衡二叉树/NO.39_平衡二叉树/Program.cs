using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._39_平衡二叉树 {
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

        public bool isBalanced = true;
        public bool IsBalanced_Solution(TreeNode pRoot) {
            // write code here
            TreeDepth(pRoot);
            return isBalanced;

        }

        public int TreeDepth(TreeNode root) {
            if (root == null)
                return 0;
            if (Math.Abs(TreeDepth(root.left) - TreeDepth(root.right)) > 1)
                isBalanced = false;
            return Math.Max(TreeDepth(root.left), TreeDepth(root.right)) + 1;
        }
    }
}
