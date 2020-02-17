using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Derived:Base
    {
        public override void MethodA()//与父类相同签名的方法不使用关键字,默认为new,即隐藏而不是重写
        {
            Console.WriteLine("子类的MethodA方法");
        }

        public new void MethodB() {
            Console.WriteLine("子类的MethodB方法");
        }
    }
}
