using System;

namespace LinkedStack {
    public class LinkedStack : ILinkedStack {
        private Node top;

        public LinkedStack() {
            top = null;
        }
        public int GetLength() {
            int count = 0;
            if (top == null) {
                return 0;
            }
            else {
                Node temp = top;
                while (temp != null) {
                    temp = temp.Next;
                    count++;
                }
                return count;
            }
        }

        public void Init() {
            top = null;
        }

        public bool IsEmpty() {
            return top == null;
        }


        public int Peek() {
            if (IsEmpty()) {
                Console.WriteLine("空栈,栈顶元素为空");
                return -1;
            }
            else {
                return top.Data;
            }
        }

        public int Pop() {
            if (IsEmpty()) {
                Console.WriteLine("空栈,没有可以出栈的元素");
                return -1;
            }
            else {
                int result= top.Data;
                if (top.Next==null) {
                    top = null;
                }
                else {
                    top = top.Next;
                }
                return result;
            }
        }

        public void Push(int item) {
            if (IsEmpty()) {
                Node newNode = new Node();
                newNode.Data = item;
                top = newNode;
            }
            else {
                Node newNode = new Node();
                newNode.Data = item;
                newNode.Next = top;
                top = newNode;

            }


        }
    }
}