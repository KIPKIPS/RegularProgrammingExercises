using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单链表 {
    class Program {
        static void Main(string[] args) {
            LinkList<int> lin=new LinkList<int>();
            lin.Add(1);
            lin.Add(2);
            lin.Add(3);
            lin.Add(4);
            lin.Add(5);
            lin.Add(6);
            lin.Add(7);
            Console.WriteLine("链表的长度为: "+lin.GetLength());
            Console.WriteLine();
            Console.Write("链表的元素有: ");
            for (int i = 0; i < lin.GetLength(); i++) {
                Console.Write(lin[i]+" ");
            }
            Console.Write("第五个是");
            Console.WriteLine(lin.GetEle(5));
            
            Console.ReadLine();
        }
    }
}
