using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件
{
    class Program
    {
        public delegate void MyDelegate();

        //private MyDelegate myDelegate;//申请一个委托变量做为类的成员
        private event MyDelegate myDelegate;//申请一个事件做为类的成员,用法和委托一样,事件只能在类里面声明
        static void Main(string[] args)
        {
            Program p=new Program();
            p.myDelegate = Test1;
            p.myDelegate();
            Console.ReadLine();

        }

        static void Test1()
        {
            Console.WriteLine("test1");
        }
    }
}
