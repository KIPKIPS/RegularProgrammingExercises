using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数
{
    public class Enemy
    {
        public float HP { get; set; }

        public float Speed { get; set; }

        public virtual void AI()
        {
            Console.WriteLine("父类的的公有AI方法");
        }

        public  void Move()
        {
            Console.WriteLine("父类的Move方法");
        }
    }
}
