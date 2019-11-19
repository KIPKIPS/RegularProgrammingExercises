using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 线性表
{
    class Program
    {
        static void Main(string[] args)
        {
            //BCL中的线性表
            List < string > myList= new List<string>();
            myList.Add("a");
            myList.Add("a");
            myList.Add("a");
            myList.Add("aa");
            myList.Add("aaa");
            myList.Add("aaaa");
            myList.Add("aaaaa");
            myList.Remove("a");//只移除第一个匹配到的"a"
            myList.RemoveAll(m => m == "a");//移除所有匹配的"a"
            //foreach (var temp in myList)
            //{
            //    Console.Write(temp+" ");
            //}
            //Console.WriteLine("count: "+myList.Count+"  capacity:"+myList.Capacity);//count为mylist的元素个数,capacity为mylist的容量

            SeqList<int> seq=new SeqList<int>();
            seq.Add(0);
            seq.Add(1);
            seq.Add(2);
            seq.Add(3);
            seq.Add(4);
            seq.Add(5);
            seq.Add(6);
            seq.Add(7);
            seq.Add(8);
            seq.Delete(8);
            seq.Insert(0,0);
            
            Console.WriteLine(seq.Locate(1));

            for(int i=0;i<seq.Length;i++)
            {
                Console.Write(seq[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
