using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类的使用
{
    class Crow:Bird
    {
        public override void Fly()
        {
            Console.WriteLine("乌鸦在飞行");
        }
    }
}
