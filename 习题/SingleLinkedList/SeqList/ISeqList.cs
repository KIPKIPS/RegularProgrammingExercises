using System.ComponentModel;

namespace SeqList {
    public interface ISeqList {
        void Init();
        void AddFromHead(params int[] item);
        void AddFromTail(params int[] item);
        void Clear();
        bool IsEmpty();
        int GetLength();
        int Locate(int item);
        int GetEle(int index);
        void Insert(int index, int item);
        int Delete(int index);

    }
}