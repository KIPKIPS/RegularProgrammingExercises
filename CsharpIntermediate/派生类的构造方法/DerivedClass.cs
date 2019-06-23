using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace 派生类的构造方法
{
    class DerivedClass:BaseClass
    {
        private int y;

        public void SetY(int y)
        {
            this.y = y;
        }

        public int GetY()
        {
            return y;
        }
        public DerivedClass():base()//调用父类中无参的构造函数
        {
            Console.WriteLine("DerivedClass无参的构造函数");
        }

        public DerivedClass(int x, int y):base(x)//DerivedClass的有参构造函数
        {
            this.y = y;
            Console.WriteLine("Y赋值完成");
        }
    }
}