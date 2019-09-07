using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NO._017_将满二叉树转换为求和树 {
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public int sum;
        public TreeNode(int data) {
            val = data;
        }
    }
    class Program {
        static void Main(string[] args) {
            Program x=new Program();
            string inp = Console.ReadLine();
            string[] temp = inp.Split(' ');
            int[] num = new int[temp.Length];
            for(int i = 0; i < temp.Length; i++) {
                num[i] = Convert.ToInt32(temp[i]);
            }
            string inp2 = Console.ReadLine();
            string[] temp2 = inp2.Split(' ');
            int[] num2 = new int[temp2.Length];
            for (int i = 0; i < temp2.Length; i++) {
                num2[i] = Convert.ToInt32(temp2[i]);
            }
            TreeNode root = x.ConstructBinaryTree(num, num2);
            x.SumBinaryTree(root);//更新sum的值
            x.inOrderGo(root);
            foreach(var te in x.res) {
                Console.Write(te + " ");
            }
            Console.ReadLine();

        }
        List<int> res = new List<int>();
        public void inOrderGo(TreeNode node) {
            if (node == null) return;
            inOrderGo(node.left);
            res.Add(node.sum);
            inOrderGo(node.right);
        }
        //后序遍历更新sum的值
        public void SumBinaryTree(TreeNode node) {
            if (node.left == null && node.right == null) {
                node.sum = 0;
            }
            else if (node.left == null) {
                SumBinaryTree(node.right);
                node.sum = node.right.sum + node.right.val;
            }
            else if (node.right == null) {
                SumBinaryTree(node.left);
                node.sum = node.left.sum + node.left.val;
            }
            else {
                SumBinaryTree(node.left);
                SumBinaryTree(node.right);
                node.sum = node.left.sum + node.left.val + node.right.sum + node.right.val;
            }
        }

        //根据先序遍历和中序遍历建立二叉树
        public TreeNode ConstructBinaryTree(int[] pre, int[] tin) {
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
                    Array.ConstrainedCopy(pre, 1, newPreL, 0, i);
                    Array.ConstrainedCopy(tin, 0, newTinL, 0, i);
                    Array.ConstrainedCopy(pre, i + 1, newPreR, 0, pre.Length - newPreL.Length - 1);
                    Array.ConstrainedCopy(tin, i + 1, newTinR, 0, tin.Length - newTinL.Length - 1);
                    newNode.left = ConstructBinaryTree(newPreL, newTinL);
                    newNode.right = ConstructBinaryTree(newPreR, newTinR);
                }
            }
            return newNode;
        }
    }
}
