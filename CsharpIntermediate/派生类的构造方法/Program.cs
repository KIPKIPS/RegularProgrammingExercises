using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 派生类的构造方法
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass de=new DerivedClass();//会先调用父类的无参构造函数,然后再调用子类的无参构造函数
            DerivedClass de1=new DerivedClass(10,10);
            de1.SetX(10);
            de1.SetY(20);
            Console.WriteLine("X:"+de1.GetX()+"Y:"+de1.GetY());

            Console.ReadLine();
        }
    }
}
