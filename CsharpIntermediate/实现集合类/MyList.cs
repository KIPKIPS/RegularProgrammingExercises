using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;

namespace 实现集合类
{
    public class MyList<T> {
        private T[] array;
        private int count=0;//表示添加的元素的个数

        public MyList(int size) {
            if (size > 0) {
                array=new T[size];
            }
        }

        public MyList() {
            array=new T[0];
        }

        public int Capacity {
            get { return array.Length; }
        }

        public int Count {
            get { return count; }
        }

        //列表的添加元素功能
        public void Add(T item) {
            if (Count == Capacity) { //数组容量不够用了
            
                if (Capacity == 0) {//如果数组容量等于0,创建一个长度为4的数组
                    array=new T[4];
                }
                else {
                    var newArray = new T[Capacity * 2];//数组容量不为0,创建一个容量为之前两倍的数组
                    Array.Copy(array,newArray,Count);//将旧的数组里面的元素copy到新的扩容的数组里面
                    array = newArray;
                }
            }
            //数组容量够用,直接添加到数组索引count处,并且count自增
            array[Count] = item;
            count++;
        }

        //列表根据索引返回索引处的值
        public T GetItem(int index) {
            if (index >= 0&&index<=Count-1) {
                return array[index];
            }
            else {
                throw new Exception("索引超出范围");
            }
        }

        public T this[int index] {
            get { return GetItem(index); }//通过索引器获取值时会调用get块
            set { //通过索引器设置值时会调用set块
                if (index >= 0 && index <= Count - 1) {
                    array[index]=value;
                }
                else {
                    throw new Exception("索引超出范围");
                }
            }
        }
    }
}