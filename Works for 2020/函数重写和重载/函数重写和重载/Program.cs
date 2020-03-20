using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数重写和重载 {
    class Program {
        static void Main(string[] args) {
        }

        //函数参数不同
        int Function(int a,int b) {
            return a + b;
        }
        int Function(int a) {
            return a;
        }
        //函数参数不同,返回值不同
        double FunctionA(int a, int b) {
            return a + b;
        }
        int FunctionA(int a) {
            return a;
        }
    }
}
