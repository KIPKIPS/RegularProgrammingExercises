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
            myList.Add(43453);
            myList.Add(453);
            myList.Add(15);
            myList[2] = 15552;
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i]+" " );
            }

            Console.ReadLine();
        }
    }
}
