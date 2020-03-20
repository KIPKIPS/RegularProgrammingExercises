using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._137_检查是否为BST {
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
            TreeNode a=new TreeNode(5);
            TreeNode b = new TreeNode(3);
            TreeNode c = new TreeNode(8);
            TreeNode d = new TreeNode(1);
            TreeNode e = new TreeNode(4);
            TreeNode f = new TreeNode(6);
            a.left = b;b.left = d;a.right = c;c.left = f;
            b.right = e;
            Console.WriteLine(checkBST(a));
            Console.ReadLine();
        }
        public static bool checkBST(TreeNode root) {
            return checkBST(root, Int32.MinValue, Int32.MaxValue);
        }

        static bool checkBST(TreeNode root, int min, int max) {
            if (root == null)
                return true;
            if (root.val < min || root.val > max)
                return false;
            return checkBST(root.left, min, root.val - 1) && checkBST(root.right, root.val + 1, max);
            //根节点
        }
    }
}
