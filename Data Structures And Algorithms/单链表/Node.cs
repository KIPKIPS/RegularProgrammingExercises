using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单链表 {
    class Node<T> {
        private T data;//用来存储数据
        private Node<T> next;//指向下一个元素

        public Node(T value) { //构造方法
            data = value;
            next = null;
        }

        public Node(T value, Node<T> next) {
            this.data = value;
            this.next = next;
        }
        public Node(Node<T> next) {
            this.next = next;
        }

        public Node() {
            this.data = default(T);
            this.next = null;
        }

        public T Data {
            get { return data;}
            set { data = value; }
        }

        public Node<T> Next {
            get { return next; }
            set { next = value; }
        }
    }
}
