using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名方法 {
    class Program {
        public delegate void MyDelegate1();
        public delegate int MyDelegate2(int x,int y);
        static void Main(string[] args) {
            //MyDelegate1 method1 = delegate() {Console.WriteLine("Hello world"); };//匿名方法
            //Lambda表达式简化 =>读作goes to,放在参数和方法体之间
            MyDelegate1 method1 =  () =>Console.WriteLine("Hello world");//匿名方法
            method1();
            //MyDelegate2 method2 = delegate(int x, int y) { return x + y; };
            MyDelegate2 method2 =  ( x,  y)=>  x + y; ;

            Console.WriteLine(method2(2, 4));
            Console.ReadLine();
        }
    }
}
