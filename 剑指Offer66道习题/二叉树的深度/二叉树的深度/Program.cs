using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉树的深度 {
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
            Program x=new Program();
            TreeNode a =new TreeNode(1);
            TreeNode b = new TreeNode(2);
            TreeNode c = new TreeNode(3);
            TreeNode d = new TreeNode(4);
            TreeNode e = new TreeNode(5);
            TreeNode f = new TreeNode(6);
            a.left = b;a.right = c;b.left = d;b.right = e;d.left = f;
            Console.WriteLine(x.TreeDepth(a));
            Console.ReadLine();
        }
        List<int>deep=new List<int>();
        public int TreeDepth(TreeNode pRoot) {
            // write code 
            if (pRoot==null) {
                return 0;
            }
            if (pRoot!=null&&pRoot.left==null&&pRoot.right==null) {
                return 1;
            }
            int count =1;
            if (pRoot!=null) {
                TreeDepth(pRoot.left);
                TreeDepth(pRoot.right);
                count++;
            }
            deep.Add(count);
            return deep.Max();
        }
    }
}
