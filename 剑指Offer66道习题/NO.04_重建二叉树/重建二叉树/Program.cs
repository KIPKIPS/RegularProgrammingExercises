using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 重建二叉树 {
    //输入某二叉树的前序遍历和中序遍历的结果，请重建出该二叉树。假设输入的前序遍历和中序遍历的结果中都不含重复的数字。
    //例如输入前序遍历序列{1,2,4,7,3,5,6,8}和中序遍历序列{4,7,2,1,5,3,8,6}，则重建二叉树并返回。
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
            Program x = new Program();
            //TreeNode a=new TreeNode(1);
            //TreeNode b = new TreeNode(2);
            //TreeNode c = new TreeNode(3);
            //TreeNode d = new TreeNode(4);
            //TreeNode e = new TreeNode(5);
            //TreeNode f = new TreeNode(6);
            //TreeNode g= new TreeNode(7);
            //a.left = b;
            //a.right = c;
            //b.left = d;
            //d.left = g;
            //c.left = e;
            //c.right = f;
            int[] pre = { 1, 2, 4, 7, 3, 5, 6, 8 };
            int[] tin = { 4, 7, 2, 1, 5, 3, 8, 6 };
            Console.WriteLine("先序遍历的结果为: ");
            PreorderTraversal(x.reConstructBinaryTree(pre, tin));
            Console.WriteLine();
            Console.Read();
        }
        public TreeNode reConstructBinaryTree(int[] pre, int[] tin) {
            // write code here
            if (pre.Length == 0 && tin.Length == 0) {
                return null;
            }
            TreeNode newNode = new TreeNode(pre[0]);
            for (int i = 0; i < tin.Length; i++) {
                if (tin[i] == pre[0]) {
                    int[] newPreL = new int[i];
                    int[] newTinL = new int[i];
                    int[] newPreR = new int[pre.Length - newPreL.Length - 1];
                    int[] newTinR = new int[tin.Length - newTinL.Length - 1];
                    Array.Copy(pre, 1, newPreL, 0, i);
                    Array.Copy(tin, 0, newTinL, 0, i);
                    Array.Copy(pre, i + 1, newPreR, 0, pre.Length - newPreL.Length - 1);
                    Array.Copy(tin, i + 1, newTinR, 0, tin.Length - newTinL.Length - 1);
                    newNode.left = reConstructBinaryTree(newPreL, newTinL);
                    newNode.right = reConstructBinaryTree(newPreR, newTinR);
                }
            }
            return newNode;
        }
        static void PreorderTraversal(TreeNode root) {
            if (root != null) {
                Console.Write(root.val + " ");
                PreorderTraversal(root.left);
                PreorderTraversal(root.right);
            }
        }
    }
}
