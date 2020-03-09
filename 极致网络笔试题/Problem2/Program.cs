using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2 {
    class TreeNode {
        public int data;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode(int val) {
            data = val;
        }
    }
    class Program {
        //-134(3(-23)(54))(44(-63))
        //123(32(23)(53))(42(6))
        static void Main(string[] args) {
            string input = Console.ReadLine();
            Stack<TreeNode> stack=new Stack<TreeNode>();
            TreeNode root=new TreeNode(0);
            for (int i = 0;i<input.Length;) {
                //数字
                if (48 <= input[i] && input[i] <= 57||input[i]=='-') {
                    if (input[i] == '-') {
                        int lastIndex = NearestNum(i+1, input);
                        int nodeNum = -Convert.ToInt32(input.Substring(i + 1, lastIndex - i - 1) + "");
                        TreeNode tempNode = new TreeNode(nodeNum);
                        stack.Push(tempNode);
                        if (i == 0) {
                            root = tempNode;
                        }
                        i = lastIndex;
                    }
                    else {
                        int lastIndex = NearestNum(i, input);
                        int nodeNum = Convert.ToInt32(input.Substring(i, lastIndex - i) + "");
                        TreeNode tempNode = new TreeNode(nodeNum);
                        stack.Push(tempNode);
                        if (i == 0) {
                            root = tempNode;
                        }
                        i = lastIndex;
                    }
                    
                }
                else if(input[i]=='(') {
                    if (input[i+1]=='-') {
                        int lastIndex = NearestNum(i + 2, input);
                        int nodeNum = -Convert.ToInt32(input.Substring(i + 2, lastIndex - i - 2) + "");
                        TreeNode tempNode = new TreeNode(nodeNum);
                        if (stack.Peek().Left == null) {
                            stack.Peek().Left = tempNode;
                        }
                        else {
                            stack.Peek().Right = tempNode;
                        }
                        stack.Push(tempNode);
                        i = lastIndex;
                    }
                    else {
                        int lastIndex = NearestNum(i + 1, input);
                        int nodeNum = Convert.ToInt32(input.Substring(i + 1, lastIndex - i - 1) + "");
                        TreeNode tempNode = new TreeNode(nodeNum);
                        if (stack.Peek().Left == null) {
                            stack.Peek().Left = tempNode;
                        }
                        else {
                            stack.Peek().Right = tempNode;
                        }
                        stack.Push(tempNode);
                        i = lastIndex;
                    }
                    
                }
                else if (input[i] == ')') {
                    stack.Pop();
                    i += 1;
                }
                if (i==input.Length-1) {
                    break;
                }
            }
            //Recursion_LRD(root);
            Console.ReadLine();
        }

        //寻找最近的数字的最后一位所在索引
        static int NearestNum(int startIndex,string tar) {
            for (int i = startIndex; i < tar.Length; i++) {
                if (!(48 <= tar[i] && tar[i] <= 57)) {
                    return i;
                }
            }
            return tar.Length - 1;
        }

        //递归后序遍历
        static void Recursion_LRD(TreeNode root) {
            if (root.Left!=null) {
                Recursion_LRD(root.Left);
            }
            if (root.Right!=null) {
                Recursion_LRD(root.Right);
            }
            Console.Write(root.data+" ");
        }
        //非递归后序遍历
        static void Non_Recursion_LRD(TreeNode root) {
            
        }
    }
}
