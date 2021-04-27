using System;
using System.Collections.Generic;

namespace 二叉树
{
    public class TreeNode
    {
        public string value;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(string _value)
        {
            value = _value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
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
            PostOrderTraversal(A);
            Console.Read();
        }
        //前序遍历,递归版本
        static void PreorderTraversalRecursion(TreeNode root)
        {
            Console.Write(root.value + " ");
            if(root.left != null)
            {
                PreorderTraversalRecursion(root.left);
            }
            if (root.right != null)
            {
                PreorderTraversalRecursion(root.right);
            }
        }
        //前序遍历,非递归版本,栈实现
        static Stack<TreeNode> preorderTraversalStack = new Stack<TreeNode>();
        static void PreorderTraversal(TreeNode root)
        {
            TreeNode temp = root;
            while (true)
            {
                if(temp != null)
                {
                    Console.Write(temp.value);
                    preorderTraversalStack.Push(temp);
                    temp = temp.left;
                }
                else
                {
                    if(preorderTraversalStack.Count> 0)
                    {
                        temp = preorderTraversalStack.Pop().right;
                    }
                    else

                    {
                        break;
                    }
                }
            }
            
        }
        
        static void InorderTraversalRecursion(TreeNode root)
        {
            
            if (root.left != null)
            {
                InorderTraversalRecursion(root.left);
            }
            Console.Write(root.value + " ");
            if (root.right != null)
            {
                InorderTraversalRecursion(root.right);
            }
            
        }

        //中序遍历,非递归版本,栈实现
        static void InorderTraversal(TreeNode root)
        {
            TreeNode temp = root;
            while (true)
            {
                if (temp != null)
                {
                    preorderTraversalStack.Push(temp);
                    temp = temp.left;
                }
                else
                {
                    if (preorderTraversalStack.Count > 0)
                    {
                        temp = preorderTraversalStack.Pop();
                        Console.Write(temp.value);
                        temp = temp.right;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        //后序遍历,递归版本
        static void PostOrderTraversalRecursion(TreeNode root)
        {
            if (root.left != null)
            {
                PostOrderTraversalRecursion(root.left);
            }
            if (root.right != null)
            {
                PostOrderTraversalRecursion(root.right);
            }
            Console.Write(root.value + " ");
        }

        //后序遍历,非递归版本,栈实现
        static void PostOrderTraversal(TreeNode root) {
            TreeNode temp = root;
            while (true) {
                if (temp != null) {
                    preorderTraversalStack.Push(temp);
                    temp = temp.left;
                } else {
                    if (preorderTraversalStack.Count > 0) {
                        temp = preorderTraversalStack.Pop(); 
                        temp = temp.right;
                        
                    } else {
                        break;
                    }
                }
            }
        }
    }
}
