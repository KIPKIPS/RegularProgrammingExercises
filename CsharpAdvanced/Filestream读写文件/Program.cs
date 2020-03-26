using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Filestream读写文件 {
    class Program {
        static void Main(string[] args) {
            //创建文件流
            FileStream stream=new FileStream("TextFile.txt",FileMode.Open);
            //FileMode模式
            //Append表示写入时在文件末尾追加内容,若文件不存在则创建一个文件
            //Create表示创建新的文件,若文件存在则覆盖文件
            //CreateNew创建新的文件,若存在则抛出异常
            //Open打开文件,文件必须存在,不存在则抛出异常
            //OpenOrCreate,文件存在则打开,若不存在则创建

            //读取写入数据
            //byte[] data = new Byte [1024];
            //while (true) {
                //int length = stream.Read(data, 0, data.Length);
                //if (length == 0) {
                    //Console.WriteLine("文件读取结束");
                    //break;
                //}
                //for (int i = 0; i < length; i++) {
                    //Console.Write(data[i]+" ");
                //}
            //}

            //文件复制
            FileStream img=new FileStream("Can.jpg",FileMode.Open);
            FileStream newImg = new FileStream("NewCan.jpg", FileMode.Create);
            byte[] imgData = new byte[1024];
            int index = 0;
            while (true) {
                int length = img.Read(imgData, 0, imgData.Length);
                if (length == 0) {
                    Console.WriteLine("文件读取结束");
                    break;
                }
                newImg.Write(imgData,0,length);
                index+=length;
                //Console.Clear();
                Console.WriteLine("复制进度: "+(float)index * 100 / img.Length+"%");
                if (index/length%10==0) {
                    Thread.Sleep(8);
                }
            }
            img.Close();
            newImg.Close();
            Console.ReadLine();
        }
    }
}
