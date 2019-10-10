using System;
using System.Diagnostics.Eventing.Reader;

namespace 循环队列 {
    public class LoopQueue {
        public int front;//队头指针
        public  int rear;//队尾指针
        public int count;
        public int[] data;

        //构造函数
        public LoopQueue(int size) {
            data=new int[size];
            front = 0;
            rear = 0;
            count = 0;
        }

        //无参构造函数
        public LoopQueue() : this(10) {
            data = new int[10];
            front = 0;
            rear = 0;
            count = 0;
        }
        //判空函数
        public bool IsEmpty() {
            return front == rear;//队头指针和队尾指针一致说明队列为空
        }

        //判满函数
        public bool IsFull() {
            return ((rear+1) % data.Length) == front;//暂时存在问题,待解决
        }
        //入队操作
        public void EnQueue(int value) {
            if (IsFull() == false) {
                data[rear] =value;
                rear = (rear + 1) % data.Length;
            }
            else {
                Console.WriteLine("ERROR::Queue is Full");
            }
        }
        //出队操作
        public void DeQueue() {
            if (IsEmpty() == false) {
                this.front = (this.front + 1) % data.Length;
            }
            else Console.WriteLine("ERROR::Queue is empty");
        }
        public int QueueLength() {
            return (rear - front + data.Length) % data.Length;
        }
    }
}