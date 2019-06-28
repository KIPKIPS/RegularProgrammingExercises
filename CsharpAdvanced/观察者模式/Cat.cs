using System;

namespace 观察者模式//被观察者类
{
    public class Cat
    {
        private string name { get; set; }
        private string color { get; set; }

        public Cat(string name,string color)
        {
            this.name = name;
            this.color=color;
        }

        //public void CatComing(Mouse mousse1,Mouse mouse2)//被观察者的状态发生改变
        public void CatComing()
        {
            Console.WriteLine(color+"的"+name+"来了,喵喵喵...");
            if(catCome!=null)
            catCome();
        }

        public event Action catCome;//声明一个事件,发布消息
    }
}