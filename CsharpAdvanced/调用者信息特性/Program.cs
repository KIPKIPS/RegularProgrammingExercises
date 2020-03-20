using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace 调用者信息特性 {
    class Program {
        static void Main(string[] args) {
            Print("wkp");
            Console.ReadLine();
        }

        static void Print(string str,[CallerFilePath]string fileName="",[CallerLineNumber] int lineNumber=0,[CallerMemberName]string methodNmae="") {
            Console.WriteLine(str);
            Console.WriteLine("路径:"+fileName);
            Console.WriteLine("调用行数:" + lineNumber );
            Console.WriteLine("调用函数:" + methodNmae);
        }
    }
}
