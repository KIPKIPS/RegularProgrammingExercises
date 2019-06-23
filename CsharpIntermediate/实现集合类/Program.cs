using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实现集合类
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList <int>myList= new MyList<int>();
            myList.Add(84);
            myList.Add(35);
            myList.Add(35);
            myList.Add(35);
            myList.Add(35);
            myList.Add(43453);
            myList.Add(453);
            myList.Add(15);
            //myList.Insert(5,65);
            //myList.RemoveAt(5);
            Console.WriteLine("35的index为: "+myList.LastIndexOf(35));
            myList.Sort();
            Console.Write("myList里面的元素分别为: ");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i]+" " );
            }

            Console.ReadLine();
        }
    }
}
