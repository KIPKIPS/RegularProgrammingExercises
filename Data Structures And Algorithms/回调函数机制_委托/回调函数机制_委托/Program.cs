using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 回调函数机制_委托 {
    class Program {
        internal delegate void MyDelegate(int num);
        private static MyDelegate myDelegate;

        static void Main(string[] args) {
            //委托类型MyDelegate的实例myDelegate引用的方法是PrintNum
            myDelegate = PrintNum;
            myDelegate(50);
        }

        static void PrintNum(int num) {
            Console.Write("PrintNum:" + num);
        }
        static void DoubleNum(int num) {
            Console.Write("DoubleNum:" + num * 2);
        }
    }
}
