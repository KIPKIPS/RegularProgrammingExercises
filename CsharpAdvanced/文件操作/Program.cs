using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文件操作 {
    class Program {
        static void Main(string[] args) {
            FileInfo file=new FileInfo("File.txt");//相对路径
            Console.WriteLine(file.Exists);//是否存在,判断编译后的路径,Debug文件夹下

            //属性
            FileInfo file_1 = new FileInfo(@"E:\Visual_Studio_WorkStation\CsharpAdvanced\文件操作\FileTest.txt");//绝对路径
            Console.WriteLine(file_1.Exists);
            Console.WriteLine(file_1.Directory);//获取路径
            Console.WriteLine(file_1.Length);//取得文件长度,字节数
            Console.WriteLine(file_1.IsReadOnly);//判断文件是否只读
            Console.WriteLine(file_1.Attributes);//获取特性

            //方法
            //file_1.Delete();//删除文件
            file_1.CopyTo("Copy.txt");//将file_1复制一份,存为Copy.txt
            
            FileInfo newFile=new FileInfo("NewFile.txt");
            //若文件不存在 则创建文件
            if (newFile.Exists==false) {
                newFile.Create();
            }
            Console.ReadLine();
        }
    }
}
