using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判断树的子结构 {
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
        public bool HasSubtree(TreeNode pRoot1, TreeNode pRoot2) {
            // write code here

            if (pRoot1.val!=pRoot2.val) {
                HasSubtree(pRoot1.left, pRoot2);
                HasSubtree(pRoot1.right, pRoot2);
            }
            else {
                HasSubtree(pRoot2.left, pRoot1.left);
                HasSubtree(pRoot2.right, pRoot1.right);
            }

        }

    }
}
