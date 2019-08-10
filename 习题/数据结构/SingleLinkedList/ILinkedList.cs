namespace SingleLinkedList {
    public interface ILinkedList {
        void AddFromHead(int item);
        void AddFromTail(int item);
        void Clear();
        bool IsEmpty();
        int GetLength();
        int Locate(int item);
        string GetEle(int index);
        void Insert(int index, int item);
        int Delete(int index);
        void Disp();
    }
}