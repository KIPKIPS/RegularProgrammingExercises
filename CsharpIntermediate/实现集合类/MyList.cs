using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;

namespace 实现集合类
{
    public class MyList<T> where T:IComparable {
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

        public void Insert(int index,T item) {
            if (index >= 0 && index < Count ) {
                var newArray = new T[Capacity * 2];//申请一个容量*2的新数组来存取插入后的数组
                for (int i = 0; i < index; i++) {
                    newArray[i] = array[i];//将旧数组在需要插入的index之前的值全部复制到新的数组
                }
                for (int i = index+1; i <Count; i++) {//将就数组在需要插入的index之后的值全部复制到新数组,并且复制的值index统一向后挪动一位,为插入的index留出位置
                    newArray[i] = array[i];
                }
                newArray[index] = item;//插入的index赋值
                array = newArray;//将插入后的新数组赋值给旧数组
            }
            else if (index==Count) {//插入的位置是就数组的最后一位
                var newArray = new T[Capacity * 2];//数组容量不为0,创建一个容量为之前两倍的数组
                Array.Copy(array, newArray, Count);//将旧的数组里面的元素copy到新的扩容的数组里面
                array = newArray;
                array[Count] = item;
                count++;
            }
            else {//抛出异常
                throw new Exception("索引超出范围");
            }
        }

        //删除index处的元素
        public void RemoveAt(int index) {
            if (index > 0 && index < count-1) {
                var newArray = new T [count - 1];
                for (int i = 0; i < index; i++) {
                    newArray[i] = array[i];
                }
                for (int i = index; i < count-1; i++) {
                    newArray[i] = array[i + 1];
                }
                array = newArray;
                count--;
            }
            else if (index == 0) {
                var newArray = new T[count - 1];
                for (int i = 0; i < count - 1; i++) {
                    newArray[i] = array[i + 1];
                }
                array = newArray;
                count--;
            }
            else if (index == count-1) {
                var newArray = new T[count - 1];
                Array.Copy(array,newArray,Count-1);
                array = newArray;
                count--;
            }
            else {
                throw  new Exception("索引超出范围");
            }
        }

        public int IndexOf(T item)
        {
            int res=-1;
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    res = i;
                    break;
                }
            }
            return res;
        }
        public int LastIndexOf(T item)
        {
            int res = -1;
            for (int i = count-1; i >=0; i--)
            {
                if (array[i].Equals(item))
                {
                    res = i;
                    break;
                }
            }
            return res;
        }

        public void Sort()
        {
            //冒泡排序
            for (int j = 0; j < Count-1; j++)
            {
                for (int i = 0; i < Count - j-1; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        T temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
        }
    }
}