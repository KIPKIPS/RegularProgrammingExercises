using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 线程_线程池 {
    class Program {
        static void MyFun(object id) {
            id = Thread.CurrentThread.ManagedThreadId;//获取当前线程的ID
            Console.WriteLine("线程"+ id +"开始");
            Thread.Sleep(3000);
            Console.WriteLine("线程"+id+"结束");
        }
        static void Main(string[] args) {
            //线程池开启的线程默认为后台线程,后台线程在应用程序结束后直接关闭
            //开启三个线程去执行MyFun方法
            ThreadPool.QueueUserWorkItem(MyFun);
            ThreadPool.QueueUserWorkItem(MyFun);
            ThreadPool.QueueUserWorkItem(MyFun);
            Console.ReadLine();

        }
    }
}
