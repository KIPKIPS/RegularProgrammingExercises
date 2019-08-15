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
            if(pRoot1 == null || pRoot2 == null){
                return false;
            }
            return IsSub(pRoot1, pRoot2) || HasSubtree(pRoot1.left, pRoot2) || HasSubtree(pRoot1.right, pRoot2);
        }
        public bool IsSub(TreeNode p1, TreeNode p2) {
            if (p2 == null) {
                return true;
            }
            if (p1 == null) {
                return false;
            }
            return (p1.val == p2.val) && IsSub(p1.left, p2.left) && IsSub(p1.right, p2.right);
        }

    }
}
