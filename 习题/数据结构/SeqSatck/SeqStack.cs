using System;

namespace SeqSatck {
    public class SeqStack : ISeqStack {
        private int[] data;
        private int count;
        private int top;

        public SeqStack(int size) {
            data=new int[size];
            top = 0;
            count = 0;
        }
        public SeqStack():this(10) {
        }
        public int GetLength() {
            return count;
        }

        public void Init() {
            top = 0;
            count = 0;
        }

        public bool IsEmpty() {
            return count == 0;
        }

        public bool IsFull() {
            return count == data.Length;
        }

        public int Peek() {
            int result;
            if (!IsEmpty()) {
                result = data[top];
            }
            else {
                Console.WriteLine("空栈,栈顶元素为空");
                return -1;
            }
            return result;
        }

        public int Pop() {
            int result;
            if (!IsEmpty()) {
                result = data[top];
                top--;
                count--;
            }
            else {
                Console.WriteLine("空栈,没有可出栈的元素");
                return - 1;
            }
            return result;
        }

        public void Push(int item) {
            if (IsFull()) {
                Console.WriteLine("栈已满,无法入栈");
            }
            else {
                if (IsEmpty()) {
                    data[top] = item;
                }
                else {
                    top++;
                    data[top] = item;
                }
                count++;
            }
        }
    }
}