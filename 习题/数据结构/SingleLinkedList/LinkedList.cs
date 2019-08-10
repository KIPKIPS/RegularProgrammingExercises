using System;
using System.CodeDom.Compiler;
using System.Runtime.Remoting.Messaging;

namespace SingleLinkedList {
    public class LinkedList : ILinkedList { //继承LinkedLink接口
        //声明指针变量
        public Node head;

        public LinkedList() { //默认构造方法
            head = null;
        }
        //头插法建链表
        public void AddFromHead(int item) {
            Node newNode = new Node(item);
            if (head == null) {
                head = newNode;
            }
            else {
                newNode.Next = head;
                head = newNode;
            }
        }

        //尾插法建链表
        public void AddFromTail( int item) {
            Node newNode=new Node(item);
            if (head==null) {
                head = newNode;
            }
            else {
                Node temp = head;
                while (temp.Next!=null) {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        //清除链表
        public void Clear() {
            head = null;
        }

        //删除链表index位置的元素
        public int Delete(int index) {
            if (index > 0) {
                int result;
                Node temp = head;
                if (index==1) {
                    result = temp.Data;
                    head = head.Next;
                    return result;
                }
                else {
                    for (int i = 0; i < index - 2; i++) {
                        temp = temp.Next;
                        if (temp.Next == null) {
                            Console.WriteLine("删除位置超出链表长度");
                            return -1;
                        }
                    }
                    result = temp.Next.Data;
                    temp.Next = temp.Next.Next;
                    return result;
                }
                
            }
            else {
                Console.WriteLine("删除位置不合法");
                return -1;
            }
        }

        //获取index位置的元素
        public string GetEle(int index) {
            if (index>=0) {
                if (head!=null) {
                    Node temp = head;
                    for (int i = 0; i < index; i++) {
                        temp = temp.Next;
                        if (temp==null) {
                            return "查询位置超出链表长度";
                        }
                    }
                    return temp.Data.ToString();
                }
                else {
                    return "该链表为空链表";
                }
            }
            else {
                return "查询位置不合法";
            }
        }

        public int GetLength() {
            Node temp = head;
            int count = 0;
            while (temp!=null) {
                temp = temp.Next;
                count++;
            }
            return count;
        }

        public void Insert(int index, int item) {
            if (index>=0) {
                Node newNode=new Node(item);
                Node temp = head;
                if (index==0) {
                    newNode.Next = head;
                    head = newNode;
                }
                else {
                    for (int i = 0; i < index-2; i++) {
                        temp = temp.Next;
                    }
                    newNode.Next = temp.Next;
                    temp.Next = newNode;
                }
            }
            else {
                Console.WriteLine("插入位置不合法");
            }
        }

        public bool IsEmpty() {
            return head == null;
        }

        public int Locate(int item) {
            Node temp = head;
            int count = 1;
            while (temp != null) {
                if (temp.Data==item) {
                    return count;
                }
                temp = temp.Next;
                count++;
            }
            return -1;
        }
        public void Disp() {
            Node temp = head;
            while (temp!=null) {
                Console.Write(temp.Data+" ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public string this[int index] {
            get { return GetEle(index); }
        }
    }
}