using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类的使用
{
    abstract class Bird
    {
        public int speed { get; set; }
        public string name { get; set; }

        public void Eat()
        {

        }

        public abstract void Fly();
    }
}
