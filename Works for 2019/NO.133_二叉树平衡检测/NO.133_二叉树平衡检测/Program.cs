using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._133_二叉树平衡检测 {
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
            TreeNode a = new TreeNode(1);
            TreeNode b = new TreeNode(2);
            TreeNode c = new TreeNode(3);
            TreeNode d = new TreeNode(4);
            TreeNode e = new TreeNode(5);
            TreeNode f = new TreeNode(6);
            TreeNode g = new TreeNode(7);
            TreeNode h = new TreeNode(8);
            TreeNode i = new TreeNode(9);
            a.left = b; a.right = c;
            b.left = d; b.right = e;
            c.left = f; c.right = g;
            d.left = h;
            h.left = i;
            Console.WriteLine(NodeHeight(a));
            Console.ReadLine();
        }

        public static bool isBalance(TreeNode root) {
            if (root.left == null && root.right == null) 
                return true;
            if (root.left != null && root.right != null) {
                return Math.Abs(Deep(root.left) - Deep(root.right)) > 1?false: isBalance(root.left) && isBalance(root.right);
            }
            if (root.left == null && root.right != null) {
                return Math.Abs(0 - Deep(root.right)) > 1?false: isBalance(root.right);
            }
            if (root.left != null && root.right == null) {
                return Math.Abs(Deep(root.right) - 0) > 1 ? false : isBalance(root.left);
            }
            return false;
        }

        //节点最大深度
        public static int Deep(TreeNode root) {
            // write code here
            int deepL = 1;
            int deepR = 1;
            if (root == null) 
                return 0;
            if (root.left != null) 
                deepL = 1 + Deep(root.left);
            if (root.right != null) 
                deepR = 1 + Deep(root.right);
            return deepL > deepR ? deepL : deepR;
        }
        //节点最大深度
        static int NodeHeight(TreeNode node) {
            if (node == null)
                return 0;
            if (node.left == null && node.right == null)
                return 1;
            return Math.Max(NodeHeight(node.left), NodeHeight(node.right)) + 1;
        }
    }
}
