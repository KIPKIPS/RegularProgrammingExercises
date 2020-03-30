using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 任务 {
    class Program {
        static void MyFun() {
            int id = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("线程"+id+"开始执行");
            Thread.Sleep(3000);
            Console.WriteLine("线程"+id+"执行结束");
        }
        static void Main(string[] args) {
            //任务开启的方法一
            Task task=new Task(MyFun);//传递需要执行的方法
            task.Start();

            //开启任务方法二
            TaskFactory tf=new TaskFactory();
            Task t = tf.StartNew(MyFun);

            Console.ReadLine();
        }
    }
}
