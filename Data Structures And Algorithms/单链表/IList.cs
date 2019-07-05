namespace 单链表
{
    interface IListDS<T> {
            int GetLength();
            void Clear();
            bool IsEmpty();
            void Add(T item);
            void Insert(T item, int index);
            T Delete(int index);
            T this[int index] { get; }
            T GetEle(int index);
            int Locate(T value);
    }
}