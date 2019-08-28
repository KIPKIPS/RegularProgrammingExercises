using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 按之字形顺序打印二叉树 {
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
        public List<List<int>> Print(TreeNode pRoot) {
            // write code here
            List<List<int>> ret = new List<List<int>>();
            if (pRoot == null)
                return ret;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(pRoot);
            int lineCount = 1;
            int dir = 1;
            int i = 0;
            int[] lst = new int[q.Count];   //一行的内容
            while (q.Count != 0) {
                TreeNode node = q.Dequeue();
                lst[i] = node.val;
                i += dir;
                if (node.left != null)
                    q.Enqueue(node.left);
                if (node.right != null)
                    q.Enqueue(node.right);
                lineCount--;
                if (lineCount == 0) {
                    ret.Add(new List<int>(lst));
                    lineCount = q.Count;
                    lst = new int[q.Count];
                    dir *= -1;
                    if (dir == -1)
                        i = q.Count - 1;
                    else
                        i = 0;
                }
            }
            return ret;
        }
    }
}
