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
            MyDelegate de = Multiply;
            Console.WriteLine(de(564.5, 54));
            de = Divide;
            Console.WriteLine(de(6546,54));
            Console.ReadLine();
        }
    }
}
