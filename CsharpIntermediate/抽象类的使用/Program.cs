using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird=new Crow();//可以用抽象类声明一个对象,但不能构造
            bird.Fly();//子类的Fly方法被调用
        }
    }
}
