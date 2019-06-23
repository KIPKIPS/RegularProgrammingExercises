using System;
using System.Security.Cryptography.X509Certificates;

namespace 构造函数
{
    public class Boss : Enemy
    {
        public void Attack()
        {
            AI();
            Move();
            HP = 100;
            Speed = 100;
            Console.WriteLine("Boss正在进行攻击!");
        }
        public override void  AI()//对父类的虚方法进行重写,函数类型必须和父类一致,这时通过子类构造的对象就不能调用父类的AI方法了,因为父类的方法已经被重写
        {
            this.HP=100;
            Console.WriteLine("子类重写的AI方法");
        }

        public new void Move()//对父类的方法进行隐藏,函数类型不需要和父类一致,仍然可以调用父类的Move方法,父类的方法只是被隐藏
        {
            Console.WriteLine("子类的Move方法");
        }
    }
}