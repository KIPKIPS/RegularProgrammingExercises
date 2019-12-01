using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._138_寻找下一个节点 {
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
            a.left = b; a.right = c; b.left = d; b.right = e; c.left = f;
            c.right = g; d.left = h; d.right = i;
            //            Console.WriteLine(findSucc(a, 7));
            //            //遍历结果链表
            //            foreach (var temp
            //                in ldrResult) {
            //                Console.Write(temp+" ");
            //            }
            Console.ReadLine();
        }
        //        static List<int> ldrResult = new List<int>();
        //        public static int findSucc(TreeNode root, int p) {
        //            // write code here
        //            LDR(root);
        //            for (int i = 0; i <ldrResult.Count; i++) {
        //                if (ldrResult[i]==p&&i!=ldrResult.Count-1) {
        //                    return ldrResult[i + 1];
        //                }
        //            }
        //            return -1;
        //        }
        //        public static void LDR(TreeNode root) {
        //            if (root != null) {
        //                LDR(root.left);
        //                ldrResult.Add(root.val);
        //                LDR(root.right);
        //            }
        //        }
        public int findSucc(TreeNode root, int p) {
            // write code here
            List<int> list = getList(root);
            for (int i = 0; i < list.Count; i++) {
                if (list[i] == p && i < list.Count - 1) {
                    return list[i + 1];
                }
            }
            return -1;
        }
        private List<int> getList(TreeNode root) {
            List<int> result = new List<int>();
            if (root == null)
                return result;
            result.AddRange(getList(root.left));
            result.Add(root.val);
            result.AddRange(getList(root.right));
            return result;
        }

    }
}
