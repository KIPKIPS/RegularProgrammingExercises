using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉树的右视图 {
    class TreeNode {
        public int data;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) {
            data = x;
        }
    }
    class Program {
        static void Main(string[] args) {

        }
        public static List<int> rightSideView(TreeNode root) {
            bfs(root, 1);
            return list;
        }

        private static int deep = 0;
        static List<int> list = new List<int>();
        static void bfs(TreeNode root, int floor) {
            if (root != null) {
                if (floor > deep) {
                    list.Add(root.data);
                }
                if (root.right == null && root.left == null) {
                    if (floor > deep) {
                        deep = floor;
                        return;
                    }
                }
                bfs(root.right,floor+1);
                bfs(root.left, floor + 1);
            }
        }
    }
}
