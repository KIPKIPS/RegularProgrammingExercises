using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeqList {
    class Program {
        static void Main(string[] args) {
            SeqList list=new SeqList(8);
            list.AddFromTail(1,2,3,4,5);
            //Console.WriteLine(list.data.Length);
            //Console.WriteLine("list.Length:" + list.Length);
            list.Insert(0,6);
            //Console.WriteLine("list.GetLength():" + list.GetLength());
            //Console.WriteLine("list.GetEle(1):" + list.GetEle(1));
            //list.Delete(3);
            //Console.WriteLine("list.count:" + list.count);
            //Console.WriteLine("删除后的列表为:");
            for (int i = 0; i < list.Length; i++) {
                Console.Write(list[i]+" ");
            }
            //Console.WriteLine("元素6的index为: "+list.Locate(2));
            Console.ReadLine();

        }
    }
}
