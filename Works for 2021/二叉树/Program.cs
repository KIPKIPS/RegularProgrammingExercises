using System;
using System.Collections.Generic;

namespace 二叉树 {
    public class TreeNode {
        public string value;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(string _value) {
            value = _value;
        }
    }
    class Program {
        static void Main(string[] args) {
            TreeNode A = new TreeNode("A");
            TreeNode B = new TreeNode("B");
            TreeNode C = new TreeNode("C");
            TreeNode D = new TreeNode("D");
            TreeNode E = new TreeNode("E");
            TreeNode F = new TreeNode("F");

            A.left = B;
            A.right = C;
            B.left = D;
            B.right = E;
            C.left = F;
            PostOrderTraversalSingleStack(A);
            Console.Read();
        }
        //前序遍历,递归版本
        static void PreorderTraversalRecursion(TreeNode root) {
            Console.Write(root.value + " ");
            if (root.left != null) {
                PreorderTraversalRecursion(root.left);
            }
            if (root.right != null) {
                PreorderTraversalRecursion(root.right);
            }
        }
        //前序遍历,非递归版本,栈实现
        static Stack<TreeNode> traversalStack = new Stack<TreeNode>();
        static void PreorderTraversal(TreeNode root) {
            TreeNode temp = root;
            while (true) {
                if (temp != null) {
                    Console.Write(temp.value);
                    traversalStack.Push(temp);
                    temp = temp.left;
                } else {
                    if (traversalStack.Count > 0) {
                        temp = traversalStack.Pop().right;
                    } else {
                        break;
                    }
                }
            }

        }

        static void InorderTraversalRecursion(TreeNode root) {

            if (root.left != null) {
                InorderTraversalRecursion(root.left);
            }
            Console.Write(root.value + " ");
            if (root.right != null) {
                InorderTraversalRecursion(root.right);
            }

        }

        //中序遍历,非递归版本,栈实现
        static void InorderTraversal(TreeNode root) {
            TreeNode temp = root;
            while (true) {
                if (temp != null) {
                    traversalStack.Push(temp);
                    temp = temp.left;
                } else {
                    if (traversalStack.Count > 0) {
                        temp = traversalStack.Pop();
                        Console.Write(temp.value);
                        temp = temp.right;
                    } else {
                        break;
                    }
                }
            }
        }

        //后序遍历,递归版本
        static void PostOrderTraversalRecursion(TreeNode root) {
            if (root.left != null) {
                PostOrderTraversalRecursion(root.left);
            }
            if (root.right != null) {
                PostOrderTraversalRecursion(root.right);
            }
            Console.Write(root.value + " ");
        }

        //后序遍历,非递归版本,双栈实现
        static void PostOrderTraversalDoubleStack(TreeNode root) {
            TreeNode temp = root;
            Stack<string> reverseStack = new Stack<string>();
            while (true) {
                if (temp != null) {
                    reverseStack.Push(temp.value);
                    //Console.Write(temp.value + " ");
                    traversalStack.Push(temp);
                    temp = temp.right;
                } else {
                    if (traversalStack.Count > 0) {
                        temp = traversalStack.Pop().left;
                    } else {
                        break;
                    }
                }
            }
            while(reverseStack.Count > 0) {
                Console.Write(reverseStack.Pop() + " ");
            }
        }

        //后序遍历,非递归版本,单栈实现
        static void PostOrderTraversalSingleStack(TreeNode root) {
            TreeNode temp = root;
            TreeNode lastAccess = null;//上一次访问的节点
            while (true) {
                if (temp != null) {
                    //Console.Write(temp.value + " ");
                    traversalStack.Push(temp);
                    temp = temp.left;
                } else {
                    if (traversalStack.Count > 0) {
                        temp = traversalStack.Pop();
                        if (temp.right == null || lastAccess == temp.right) { //访问节点的时机,(1)叶节点 (2)上次访问的节点是当前访问节点的右节点
                            Console.Write(temp.value + " ");//Access
                            lastAccess = temp;
                            temp = null;
                        } else {
                            traversalStack.Push(temp);
                            temp = temp.right;
                        }
                    } else {
                        break;
                    }
                }
            }
        }
    }
}
