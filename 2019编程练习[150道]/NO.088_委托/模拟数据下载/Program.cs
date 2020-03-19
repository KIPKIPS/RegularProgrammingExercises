using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 模拟数据下载 {
    class Program {
        public static void Main(string[] args) {
            Person user=new Person();
            user.DownloadData("hello world");
            Console.ReadLine();
        }
    }

    //委托回调
    public delegate void DownloadComplete(string result);
    /// <summary>
    /// 下载器类
    /// </summary>
    class DownloadTool {
        public DownloadComplete complete;
        //数据下载
        public void DownloadData(string url) {
            for (int i = 0; i <= 100; i+=5) {
                Thread.Sleep(20);
                Console.Clear();
                Console.WriteLine("数据下载中"+i+"%");
            }
            Console.WriteLine("下载完成...");
            complete(url);
        }
    }

    /// <summary>
    /// 用户类
    /// </summary>
    class Person {
        //下载数据
        public void DownloadData(string url) {
            DownloadTool tool=new DownloadTool();
            tool.complete = DealWithData;
            tool.DownloadData(url);
        }
        //处理下载完成的数据
        public void DealWithData(string result) {
            Console.WriteLine(result);
        }
    }
}
