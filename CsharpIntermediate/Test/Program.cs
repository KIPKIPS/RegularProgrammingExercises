using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived de=new Derived();//子类声明子类构造对象
            Base ba=new Derived();//父类声明子类构造对象

            de.MethodA();//子类声明的对象会调用子类的MethodA方法
            ba.MethodA();//父类声明的对象会调用父类的MethodA方法
         
            Console.ReadLine();
        }
    }
}
