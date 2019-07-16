using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 顺序队列 {
    class SeqQueue<T>:IQueue<T> {
        private T[] data;
        private int count;
        private int front;//队首指示器
        private int rear;//队尾指示器

        public SeqQueue():this(size:10) {//空构造函数默认size为10

        }
        public SeqQueue(int size) {
            data = new T[size];
            count = 0;
        }

        public int Count {
            get { return count; }
        }

        public int GetLength() {
            return count;
        }

        public bool IsEmpty() {
            return count == 0;
        }

        public void Clear() {
            throw new NotImplementedException();
        }

        public void Enqueue(T item) {
            throw new NotImplementedException();
        }

        public T Dequeue() {
            throw new NotImplementedException();
        }

        public T Peek() {
            throw new NotImplementedException();
        }
    }
}
