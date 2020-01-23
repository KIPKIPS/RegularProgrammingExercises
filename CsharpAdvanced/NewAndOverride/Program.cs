using System;


//new和override的区别
namespace NewAndOverride {
    class Program {
        static void Main(string[] args) {
            //override之后,子类还是子类方法,父类还是父类方法
            //Father f=new Father();
            //f.Func();
            //Children c=new Children();
            //c.Func();

            //和上面输出一致,因为父类发已经被重写
            //Father f=new Father();
            //f.Func();
            //Father c=new Children();
            //c.Func();

            //new的方法,子类父类不变化(前提是不用子类的构造方法去声明父类对象)
            //Father f=new Father();
            //f.Func();
            //Children c=new Children();
            //c.Func();

            //用子类的构造方法去声明父类的对象,结果会导致调用子类的方法结果却调用父类的方法
            //原因,父类的方法不会被覆盖,没有被重写,对象由谁的构造方法构造就会去调用谁的方法
            Father f=new Father();
            f.Func();
            Father c=new Children();
            c.Func();
            Console.ReadLine();
        }
    }
}
