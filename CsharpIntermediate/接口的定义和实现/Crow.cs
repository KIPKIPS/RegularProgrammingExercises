using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 接口的定义和实现
{
    class Crow : IFastFly,IFly
    {
        public void Eat()
        {
            Console.WriteLine("乌鸦在吃东西");
        }

        public void FastFly()
        {
            Console.WriteLine("乌鸦在快速飞行");
        }

        public void Fly()
        {
            Console.WriteLine("乌鸦在飞行");
        }
    }
}
