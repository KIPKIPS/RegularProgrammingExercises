using System;

namespace 链栈 {
    public class LinkStack<T>: IStack<T> {
        private Node<T> top;//栈顶节点
        private int count=0;//栈中存储的元素个数

        /// <summary>
        /// 获取栈的长度
        /// </summary>
        /// <returns></returns>
        public int GetLength() {
            return Count;
        }

        /// <summary>
        /// 获取栈的元素个数
        /// </summary>
        public int Count {
            get { return count; }
        }
        /// <summary>
        /// 栈的判空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() {
            return count == 0;
        }

        /// <summary>
        /// 栈的清空操作
        /// </summary>
        public void Clear() {
            count = 0;
            top = null;
        }
        /// <summary>
        /// 入栈操作
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item) {
            Node<T>newNode=new Node<T>(item);
            newNode.Next = top;
            top = newNode;
            count++;
        }

        /// <summary>
        /// 出栈操作
        /// </summary>
        /// <returns></returns>
        public T Pop() {
            T temp = top.Data;
            top = top.Next;
            count--;
            return temp;
        }
        /// <summary>
        /// 取栈顶元素
        /// </summary>
        /// <returns></returns>
        public T Peek() {
            return top.Data;
        }
    }
}