using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._088_委托 {
    class Program {
        public delegate void TestDelegate();
        static void Main(string[] args) {
            TestDelegate a = Test1;
            a += Test2;
            a -= Test1;
            a();
            Console.ReadLine();
        }

        public static void Test1() {
            Console.WriteLine("test1方法被执行");
        }
        public static void Test2() {
            Console.WriteLine("test2方法被执行");
        }
    }
}
