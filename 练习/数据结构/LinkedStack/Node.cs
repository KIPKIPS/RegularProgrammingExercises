namespace LinkedStack {
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

        public Node(int data,Node next) {
             this.data=data;
             this.next = next;
        }
        public Node() {
            this.next = null;
        }
        public Node(int data) {
            this.data = data;
            this.next = null;
        }
    }
}