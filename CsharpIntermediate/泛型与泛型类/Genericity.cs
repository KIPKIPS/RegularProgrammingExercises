using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace 泛型与泛型类
{
    class Genericity<T,T1>//T代表一个数据类型,当用Genericity进行构造时,需要指定T的类型
    {
        private T num1;
        private T num2;
        private T1 num3;

        public Genericity(T a,T b,T1 c)
        {
            num1 = a;
            num2 = b;
            num3 = c;
        }

        public string Sum()
        {
            return num1 + "" + num2 + num3;
        }
    }
}