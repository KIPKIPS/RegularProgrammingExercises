using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口的定义和实现
{
    class Bird:IFly
    {
        public void Eat()
        {
            Console.WriteLine("小鸟在吃东西");
        }

        public void Fly()
        {
            Console.WriteLine("小鸟在飞行");
        }
    }
}
