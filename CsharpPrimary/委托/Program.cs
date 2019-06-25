using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    //委托的定义
    //委托的定义需要delegate关键字,委托的定义不需要函数体
    //与函数的定义差不多,都在命名空间下定义
    public delegate double MyDelegate(double num1, double num2);

    class Program
    {
        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
        static void Main(string[] args)
        {
            //给委托的变量赋值的时候,返回值和参数列表必须一致
            //MyDelegate de = Multiply;
            //Console.WriteLine(de(564.5, 54));
            //de = Divide;
            //Console.WriteLine(de(6546,54));



            //MyDelegate de=new MyDelegate(Multiply);
            //Console.WriteLine(de(2,4));
            //de = Divide;
            //Console.WriteLine(de(4,2));

            //委托类型当做参数传递,间接调用方法
            Print mf;
            mf = fun1;
            MidFunction(mf);//MidFunction是间接方法,中介者
            mf = fun2;
            MidFunction(mf);

            Console.ReadLine();
        }

        public delegate void Print();

        public static void MidFunction(Print p)//委托类型当做参数,此时p也可以看做是一个函数方法
        {
            p();
        }

        static void fun1()
        {
            Console.WriteLine("fun1");
        }
        static void fun2()
        {
            Console.WriteLine("fun2");
        }
    }
}
