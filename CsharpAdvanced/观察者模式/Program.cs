using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat=new Cat("汤姆猫","灰色");
            Mouse mouse1=new Mouse("米老鼠","黑色",cat);
            Mouse mouse2 = new Mouse("皮皮鼠", "黄色", cat);
            Mouse mouse3=new Mouse("神奇小老鼠","白色", cat);
            //cat.CatComing(mouse1,mouse1);//新的观察者申请后,被观察者的类以及参数都要修改,很麻烦也很容易出现问题,通过消息机制,被观察者发出消息,观察者接收消息做出改变

            //将mouse的run方法注册到catcome里面
            cat.catCome += mouse1.Run;
            cat.catCome += mouse2.Run;
            cat.catCome += mouse3.Run;

            cat.CatComing();
            //cat.catCome();//事件只能在类的内部调用,不能再类的外部触发
            Console.ReadLine();
        }
    }
}
