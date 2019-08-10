namespace SingleLinkedList {
    public class Node {
        private int data;
        private Node next;

        public int Data {
            get { return data; }
            set { data = value; }
        }

        public Node Next {
            get { return next; }
            set { next = value; }
        }
        public Node() {//无数据,无next域
        }
        public Node(Node next) {//头结点,无数据,有next域
            this.next = next;
        }

        public Node(int data, Node next) { //普通节点,有数据,有next域
            this.data = data;
            this.next = next;
        }

        public Node(int data) { //尾结点,有数据,无next域
            this.data = data;
            this.next = null;
        }
    }
}