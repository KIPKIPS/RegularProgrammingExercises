#define IsTest //定义一个宏,控制Test1的调用
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contional特性 {
    class Program {
        static void Main(string[] args) {
            Test1();
            Test2();
            Test3();
            Test1();
            Console.ReadLine();
        }
        [Conditional("IsTest")]//使用Conditional特性控制Test1方法的调用,若IsTest被定义,则调用Test1,否则不去调用
        static void Test1() {
            Console.WriteLine("Test1()");
        }
        static void Test2() {
            Console.WriteLine("Test2()");
        }
        static void Test3() {
            Console.WriteLine("Test3()");
        }
    }
}
