using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 线性表 {
    class SeqList<T>:IListDS<T>{
        /// <summary>
        /// 顺序表实现
        /// </summary>
        /// <returns></returns>
        private T[] data;//用来存储数据

        private int count = 0;
        public int Length {
            get { return count; }
        }
        public SeqList(int size){
            data=new T[size];
            count = 0;
        }

        public SeqList():this(10) {//默认构造函数,顺序表的容量为10

        }
        public int GetLength() {
            return count;
        }

        public void Clear() {
            count = 0;
        }

        public bool IsEmpty() {
            //if (count == 0) return true;
            //return false;
            return count == 0;
        }

        /// <summary>
        /// 顺序表添加元素
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            if (count == data.Length) {
                Console.WriteLine("顺序表已经存满");
            }
            else {
                data[count] = item;
                count++;
            }
        }
        /// <summary>
        /// 顺序表插入元素
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        public void Insert(T item, int index)
        {
            if (index >= 0 && index <= count) {
                for (int i = count - 1; i >= index; i--) {
                    data[i + 1] = data[i];
                }
                data[index] = item;
                count++;
            }
            else {
                Console.WriteLine("插入的位置超出范围");
            }
        }

        public T Delete(int index) {
            T del = data[index];
            if (index >= 0 && index <= count - 1) {
                for (int i = index; i < count - 1; i++) {
                    data[i] = data[i+1];
                }
                count--;
            }
            else {
                Console.WriteLine("顺序表中不存在这个索引");
            }
            return del;
        }

        public T this[int index] {
            get { return GetEle(index); }

        }

        public T GetEle(int index) {
            if (index >= 0 && index <= count - 1) {
                return data[index];
            }
            else {
                Console.WriteLine("顺序表不存在这个位置");
                return default(T);
            }
        }

        public int Locate(T value) {
            for (int i = 0; i < count; i++) {
                if (data[i].Equals(value)) {
                    return i;
                }
            }
            return -1;
        }
    }
}
