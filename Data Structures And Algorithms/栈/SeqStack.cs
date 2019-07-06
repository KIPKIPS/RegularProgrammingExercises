using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 栈 {
    class SeqStack<T>:IStack<T> { //继承IStack接口

        private T[] data;//存储数据的数组
        private int top;//栈顶指示器,空栈为-1

        public SeqStack():this(10) { //空构造函数默认size为10
        }
        public SeqStack(int size) {
            data=new T[size];
            top = -1;
        }
        public int GetLength() {
            return Count;
        }

        //top栈顶指示器+1就是当前栈所含的元素个数
        public int Count {
            get { return top + 1; }
        }
        public bool IsEmpty() {
            return Count == 0;
        }

        public void Clear() {
            top = -1;
        }

        public void Push(T item) {
            data[top + 1] = item;
            top++;
        }

        public T Pop() {
            T temp = data[top];
            top--;
            return temp;
        }

        public T Peek() {
            return data[top];
        }
    }
}
