using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace 派生类的构造方法
{
    class BaseClass
    {
        private int x;

        public void SetX(int x)
        {
            this.x = x;
        }

        public int GetX()
        {
            return x;
        }
        public BaseClass()//BaseClass构造函数
        {
            Console.WriteLine("BaseClass的无参构造函数");
        }

        public BaseClass(int x)//BaseClass的有参构造函数
        {
            this.x = x;
            Console.WriteLine("X赋值完成");
        }
    }
}