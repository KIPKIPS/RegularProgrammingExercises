using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文件读写操作 {
    class Program {
        static void Main(string[] args) {
            string[] fileLines=File.ReadAllLines("TextFile.txt");
            foreach (var VARIABLE in fileLines) {
                Console.WriteLine(VARIABLE);
            }

            Console.WriteLine();
            //读取文件的字节信息,转化为字符
            byte[] data = File.ReadAllBytes("TextFile.txt");
            string temp = Encoding.UTF8.GetString(data,3,data.Length-3);
            Console.WriteLine(temp);

            //读取图片
            //byte[] img = File.ReadAllBytes("May.png");
            //foreach (var b in img) {
            //    Console.Write(b);
            //}

            File.WriteAllLines("Write.txt",new []{"??????","hhhhh","什么"});//写入文件文件不存在则创建,多行
            File.WriteAllText("Write_2.txt", "xxxxxxxx");//写入文件,单行
            //写入字节数据
            byte[] img = File.ReadAllBytes("May.png");
            File.WriteAllBytes("Img.txt",img);
            Console.ReadLine();
        }
    }
}
