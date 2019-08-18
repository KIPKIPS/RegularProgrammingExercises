using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉搜索树与双向链表 {
    //输入一棵二叉搜索树，将该二叉搜索树转换成一个排序的双向链表。要求不能创建任何新的结点，只能调整树中结点指针的指向。
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
        public TreeNode Convert(TreeNode pRootOfTree) {
            // write code here
            if (pRootOfTree==null) {
                return null;
            }
            TreeNode temp = pRootOfTree;
            while (temp!=null) {
                Convert(temp.left);

            }
        }
    }
}
