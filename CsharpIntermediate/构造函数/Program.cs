using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo me=new StudentInfo("王琨鹏",21);
            Console.WriteLine("我的名字是"+me.ShowName()+",我今年"+me.ShowAge()+"岁了");
            Console.WriteLine();

            //通过属性访问类的字段值
            me.Name = "aisohd";
            me.Age = 85;
            Console.WriteLine("我的名字是" + me.Name + ",我今年" + me.Age + "岁了");

            Boss boss=new Boss();
            boss.Attack();
            Console.WriteLine("boss血量: "+boss.HP+"boss速度: "+boss.Speed);
            boss.AI();
            boss.Move();
            

            Enemy enemy=new Boss();//用父类声明的对象,使用了子类的构造方法,但是子类不可以使用父类的构造方法
            Boss boss1 = (Boss) enemy;//使用子类构造方法的父类声明,本质上还是一个子类的对象,我们可以使用子类强制类型转换将这个对象转换成子类类型的

            Enemy enemy1=new Enemy();//父类类型的不能强制转换成子类类型的,因为用父类构造器生成的对象本质上是父类
            //Boss boss2 = (Boss) enemy1; //无法转换,会报错

            Enemy boss3=new Boss();//用父类声明一个对象,用子类的构造方法构造
            boss3.Move();//该对象可以访问父类的隐藏方法
            Boss boss4=new Boss();//用子类声明一个对象,用子类的构造方法构造
            boss4.Move();//该对象只能访问到子类构造的同签名方法,不可以访问父类的隐藏方法


            Console.ReadLine();
        }
    }
}
