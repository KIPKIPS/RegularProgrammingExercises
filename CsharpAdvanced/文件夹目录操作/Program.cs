using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文件夹目录操作 {
    class Program {
        static void Main(string[] args) {
            DirectoryInfo directory=new DirectoryInfo(@"E:\Visual_Studio_WorkStation\CsharpAdvanced\文件夹目录操作\bin\Debug");
            Console.WriteLine(directory.Exists);
            Console.WriteLine(directory.Name);
            Console.WriteLine(directory.FullName);
            Console.WriteLine(directory.Parent);
            Console.WriteLine(directory.Root);
            Console.WriteLine(directory.Extension);
            Console.ReadLine();
        }
    }
}
