using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsolete特性 {
    class Program {
        static void Main(string[] args) {
            //OldMethod();
        }

        //obsolete表示该方法被弃用
        [Obsolete("NewMethod",true)]//表示去使用新的方法代替,若后面标记为true表示不能再正常编译执行
        static void OldMethod() {
            Console.WriteLine("old");
        }

        static void NewMethod() {
            Console.WriteLine("new");
        }
    }
}
