namespace LinkedStack {
    public interface ILinkedStack {
        void Init();
        bool IsEmpty();
        void Push(int item);//进栈
        int Pop();//出栈
        int Peek();//读栈顶
        int GetLength();
    }
}