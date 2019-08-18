using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._25_二叉树中和为某一值的路径 {
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
        List<List<int>> pathList = new List<List<int>>();
        List<int> path = new List<int>();
        public List<List<int>> FindPath(TreeNode root, int expectNumber) {
            //write code here
            if (root == null)
                return pathList;
            path.Add(root.val);
            expectNumber -= root.val;
            if (expectNumber == 0 && root.left == null && root.right == null) {
                pathList.Add(new List<int>(path));
            }
            FindPath(root.left, expectNumber);
            FindPath(root.right, expectNumber);
            path.RemoveAt(path.Count - 1);
            return pathList;

        }
    }
}
