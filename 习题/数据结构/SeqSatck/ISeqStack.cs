namespace SeqSatck {
    public interface ISeqStack {
        void Init();
        bool IsEmpty();
        bool IsFull();
        void Push(int item);//进栈
        int Pop();//出栈
        int Peek();//读栈顶
        int GetLength();
    }
}