namespace 链栈 {
    public class Node<T> {


        private T data;//存储数据
        private Node<T> next;//指向下一节点的指针
        //外界需要读取和设置data,next的值,所以要提供data和next的get,set属性
        public T Data {
            get { return data; }
            set { data = value; }
        }
        public Node<T> Next {
            get { return next; }
            set { next = value; }
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        public Node() { //默认构造方法
            this.data = default(T);
            this.next = null;
        }
        public Node(T data) {
            this.data = data;
            next = null;
        }

        public Node(T data, Node<T> next) {
            this.data = data;
            this.next = next;
        }
        public Node(Node<T> next) {
            this.next = next;
        }

        
        
    }
}