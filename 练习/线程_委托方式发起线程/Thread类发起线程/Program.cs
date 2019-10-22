using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread类发起线程 {
    class Program {
        static void DownloadFile(object fileName) {
            Console.WriteLine("Downloading...");
            int i = 0;
            while (i<=100) {
                Thread.Sleep(100);
                Console.Write(i+"%");
                Console.Clear();
                i += 10;
                
            }
            Console.WriteLine(fileName+"is Finished");
        }
        static void Main(string[] args) {
            //带参数的线程
            //Thread thread=new Thread(DownloadFile);//传递参数必须为Object类型
            //thread.Start("RECNEPS-KIPS's file ");


            //Lambada表达式
            #region Lambada表达式
//            Thread thread = new Thread(() => {
//
//                Console.WriteLine("Downloading...");
//                int i = 0;
//                while (i <= 100) {
//                    Thread.Sleep(100);
//                    Console.Write(i + "%");
//                    Console.Clear();
//                    i += 10;
//                }
//                Console.WriteLine("Finished");
//                Console.WriteLine("ThreadID is " + Thread.CurrentThread.ManagedThreadId);
//            });
//            thread.Start();//线程开始
            #endregion

            //构造自定义Thread类
            MyThread mythread=new MyThread("RECNEPS-KIPS.jpeg", "https://ww.download.com");
            Thread t=new Thread(mythread.DownloadFile);
            t.Start();

            Thread t2 = new Thread(DownloadFile);
            //通过更改线程的IsBackground属性来修改它是否是前台线程,前台线程结束后,应用程序才会被结束,后台线程则会被终止
            t2.IsBackground = true;
            t2.Start("download.png");//默认创建的线程为前台线程
            //Thread类中通过修改priority属性来设置线程的优先级,Highest,AboveNormal,BelowNormal,Lowest
            Console.ReadLine();
        }
    }
}
