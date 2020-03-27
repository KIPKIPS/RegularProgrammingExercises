using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream读写文件 {
    class Program {
        static void Main(string[] args) {
            //读取模块
            //StreamReader reader=new StreamReader("TextFile.txt");
            //读取方法一
            //string str = reader.ReadLine();//读取文件的第一行
            //string res = reader.ReadToEnd();//读取当前位置到文件尾部
            //Console.WriteLine(str);
            //Console.WriteLine(res);

            //读取方法二
            //while (true) {
             //   string curLine = reader.ReadLine();
             //   Console.WriteLine(curLine);
            //    if (curLine==null) {
             //       break;
             //   }
           // }
            //读取方法三
            //while (true) {
               // int c=reader.Read();
               // if (c==-1) {
               //     break;
              //  }
             //   Console.Write((char)c);
            //}
            //reader.Close();

            //写入流
            StreamWriter writer=new StreamWriter("Write.txt");//若文件路径不存在,则创建
            //若存在,则源文件被覆盖
            while (true) {
                string message = Console.ReadLine();
                if (message == "q") {
                    Console.WriteLine("退出写入");
                    break;
                }
                writer.Write(message);
                writer.WriteLine();//换行
            }
            writer.Close();//必须关闭,否则无法写入成功
            Console.ReadLine();
        }
    }
}
