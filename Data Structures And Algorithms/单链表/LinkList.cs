using System;

namespace 单链表 {
    class LinkList<T> : IListDS<T> {

        private Node<T> head; //存储一个头结点

        public LinkList() {
            head = null;
        }

        /// <summary>
        /// 获取单链表的长度
        /// </summary>
        /// <returns></returns>
        public int GetLength() {
            if (head == null) {
                return 0;
            }
            else {
                Node<T> temp = head;
                int count = 1;
                while (true) {
                    if (temp.Next != null) {
                        count++;
                        temp = temp.Next;
                    }
                    else {
                        break;
                    }
                }
                return count;
            }
        }

        /// <summary>
        /// 清除单链表操作
        /// </summary>
        public void Clear() {
            head = null;
        }

        /// <summary>
        /// 单链表判空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() {
            return head == null;
        }

        /// <summary>
        /// 添加操作
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item) {
            Node<T> newNode = new Node<T>(item);//为新数据创建一个新的节点
            if (head == null) {//如果头结点为空,这个新节点就是头结点
                head = newNode;
            }
            //头结点不为空,把这个新节点放到链表的尾部
            else {
                Node<T> temp = head;
                while (true) {
                    if (temp.Next != null) {
                        temp = temp.Next;
                    }
                    else {
                        break;
                    }
                }
                temp.Next = newNode;
            }
        }
        /// <summary>
        /// 插入操作
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        public void Insert(T item, int index) {
            Node<T> newNode = new Node<T>();
            if (index == 0) { //插入头结点
                newNode.Next = head;
                head = newNode;
            }
            else {
                Node<T> temp = head;
                for (int i = 1; i < index - 1; i++) {
                    temp = temp.Next;
                }
                newNode.Next = temp.Next;
                temp.Next = newNode;
            }
        }

        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Delete(int index) {
            T data = default(T);
            if (index == 0) {
                data = head.Data;
                head = head.Next;
            }
            else {
                Node<T> temp = head;
                for (int i = 1; i <= index - 1; i++) {
                    temp = temp.Next;
                }
                data = temp.Next.Data;
                Node<T> preNode = temp;
                Node<T> nextNode = temp.Next.Next;
                preNode.Next = nextNode;
            }
            return data;
        }
        /// <summary>
        /// 查找index处的值
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index] {
            get {
                Node<T> temp = head;
                for (int i = 1; i <= index; i++) {
                    temp = temp.Next;
                }
                return temp.Data;
            }
        }

        public T GetEle(int index) {
            return this[index];
        }

        /// <summary>
        /// 查找对应值的index
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Locate(T value) {
            Node<T> temp = head;
            if (temp == null) {
                return -1;
            }
            else {
                int index = 0;
                while (true) {
                    if (temp.Data.Equals(value)) {
                        return index;
                    }
                    else {
                        if (temp.Next != null)
                            temp = temp.Next;
                        else {
                            break;
                        }
                    }
                }
                return -1;
            }
        }
    }
}