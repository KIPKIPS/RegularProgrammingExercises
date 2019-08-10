using System;

namespace SeqList {
    public class SeqList : ISeqList {
        public int[] data;
        public int count;
        private int size;

        public int Length {
            get { return count; }
        }

        public SeqList(int size) {
            data=new int[size];
            this.size = size;
            count = 0;
        }

        public SeqList() : this(10) {
        }
        //头插法
        public void AddFromHead(params int[] item) {
            if (size < item.Length) {
                Console.WriteLine("链表容量不足,当前链表长度为:" + size);
            }
            else {
                for (int i = item.Length-1; i >=0; i--) {
                    AddFromTail(item[i]);
                }
            }
        }
        //尾插法
        public void AddFromTail(params int[] item) {
            if (size < item.Length) {
                Console.WriteLine("链表容量不足,当前链表长度为:" + size);
            }
            else {
                for (int i = 0; i < item.Length; i++) {
                    data[count] = item[i];
                    count++;
                }
            }
        }
        public void Clear() {
            count = 0;
        }

        //删除index位置的元素
        public int Delete(int index) {
            if (index>=0&&index<=count-1) {
                
                int el = data[index];
                for (int i = index; i < data.Length - 1; i++) {
                    data[i] = data[i + 1];
                }
                count--;
                return el;
            }
            else {
                Console.WriteLine("删除的位置不合法");
                return -1;
            }
        }

        //get index位置的元素
        public int GetEle(int index) {
            return data[index];
        }

        //get 列表长度
        public int GetLength() {
            return count;
        }

        //初始化
        public void Init() {
            count = 0;
        }

        
        //插入元素
        public void Insert(int index, int item) {
            //if (index >= 0 && index <= count) {
            //    for (int i = count - 1; i >= index; i--) {
            //        data[i + 1] = data[i];
            //    }
            //    data[index] = item;
            //    count++;
            //}
            //else {
            //    Console.WriteLine("插入的位置超出范围");
            //}
            if (index >= 0 && index <= count) {
                for (int i = count+1; i >index; i--) {
                    data[i] = data[i - 1];
                }
                data[index] = item;
                count++;
            }
            else {
                Console.WriteLine("插入位置不合法");
            }
        }
        //判空
        public bool IsEmpty() {
            return count == 0;
        }

        public int Locate(int item) {
            for (int i = 0; i < count; i++) {
                if (data[i]==item) {
                    return i;
                }
            }

            return -1;
        }
        public int this[int index] { //通过[]索引器访问元素
            get { return GetEle(index); }
        }
    }
}