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
        //-1(3(2)(5))(4(6))
        static void Main(string[] args) {
            string input = Console.ReadLine();
            Stack<TreeNode> stack=new Stack<TreeNode>();
            for (int i = 0; ; i++) {
                if (input[i]=='-'||48 <= input[i] && input[i] <= 57) {
                    int index = 0;
                    for (int j = i; j < input.Length; j++) {
                        if (!(48<=input[j]&&input[j]<=57)) {
                            index = j;
                            break;
                        }
                    }
                    string t = "";
                    for (int j = i+1; j < index; j++) {
                        t += input[j];
                    }
                    Console.WriteLine(t);
                    //int nodeNum = -Convert.ToInt32(t);
                    //TreeNode tempNode=new TreeNode(nodeNum);
                    //stack.Push(tempNode);
                    i += index;
                }
                else if(input[i]=='(') {
                    int index = 0;
                    for (int j = i; j < input.Length; j++) {
                        if (!(48 <= input[j] && input[j] <= 57)) {
                            index = j;
                            break;
                        }
                    }
                    string t = "";
                    for (int j = i+1; j < index; j++) {
                        t += input[j];
                    }
                    int nodeNum = Convert.ToInt32(t);
                    TreeNode tempNode = new TreeNode(nodeNum);
                    if (stack.Peek().Left ==null) {
                        stack.Peek().Left = tempNode;
                    }
                    else {
                        stack.Peek().Right = tempNode;
                    }
                    stack.Push(tempNode);
                    i += index;
                }
                else if (input[i] == ')') {
                    stack.Pop();
                    i += 1;
                }
                if (i==input.Length-1) {
                    break;
                }
            }
            Console.WriteLine(stack.Peek().data);
            Console.WriteLine(stack.Peek().Left.data);
            Console.WriteLine(stack.Peek().Right.data);
            Console.WriteLine(stack.Peek().Left.Left.data);
            Console.WriteLine(stack.Peek().Left.Right.data);
            Console.WriteLine(stack.Peek().Right.data);
            Console.WriteLine(stack.Peek().Right.Left.data);
            Console.ReadLine();
        }
    }
}
