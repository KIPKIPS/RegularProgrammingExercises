using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 密封类和密封方法
{
    class FinalClass:BaseClass//密封类无法被继承
    {
        public  sealed override void eat()//密封方法只能声明重写的方法,表示这个重写方法不能再被重写了
        {

        }
    }
}
