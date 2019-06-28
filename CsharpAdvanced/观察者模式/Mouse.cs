using System;

namespace 观察者模式
{
    public class Mouse//观察者类
    {
        private string name { get; set; }
        private string color { get; set; }

        public Mouse(string name, string color,Cat cat)
        {
            this.name = name;
            this.color = color;
            cat.catCome+=this.Run;//订阅消息
        }

        public void Run()
        {
            Console.WriteLine(color+"的"+name+"说:猫来了,快跑!");
        }
    }
}