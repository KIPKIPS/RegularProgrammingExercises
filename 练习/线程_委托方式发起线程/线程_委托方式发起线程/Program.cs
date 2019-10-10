using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


//委托方式发起线程的三种方法

namespace 线程_委托方式发起线程 {
    class Program {
        //一般为比较耗时的操作开启一个线程,比如下载文件操作
        static string Test1(int value,string str) {
            Console.WriteLine("Test1方法被执行");
            Thread.Sleep(1000);//让当前线程休眠,相当于暂停
            return "Thread is end";
        }
        static void Main(string[] args) {//在main线程中去执行,一个线程里的语句是由上到下的
            //通过委托开启线程
            //Func<int,string,string> a = Test1;
            //IAsyncResult state=a.BeginInvoke(100,"RECNEPS-KIPS",null, null);//开启一个线程去执行a引用的方法
            //IAsyncResult可以取得当前线程的状态
            Console.WriteLine("Main方法被执行");

            //第一种检测线程结束的方式
            #region Way1
            //while (state.IsCompleted == false) {
            //    Console.Write(".");
            //    Thread.Sleep(25);//控制线程的检测频率
            //}
            //Console.WriteLine();
            //取得异步线程的返回值
            //int res = a.EndInvoke(state);
            //Console.WriteLine(res);
            #endregion

            //第二种检测线程结束的方式
            #region Way2
            //WaitOne方法可以等待当前线程结束再去执行下面的代码,参数为超时时间,超时直接返回状态
            //bool isEnd = state.AsyncWaitHandle.WaitOne(3000);
            //if (isEnd)
            //    Console.WriteLine(a.EndInvoke(state));//返回线程结果
            #endregion

            //第三种检测线程结束的方式,通过回调检测线程
            #region Way3
            Func<int, string, string> a = Test1;
            //IAsyncResult state = a.BeginInvoke(100, "RECNEPS-KIPS", OnCallBack, a);//开启一个线程去执行a引用的方法
            IAsyncResult state = a.BeginInvoke(100, "RECNEPS-KIPS", ar =>
            {
                //Lambada表达式可以直接访问外部变量,所以BeginInvoke的第二个参数为null
                string res = a.EndInvoke(ar);
                Console.WriteLine(res);
            }, null);//开启一个线程去执行a引用的方法
            //第一个null是一个委托方法,线程结束时会调用这个方法
            //第二个null是给回调函数传参数的(OnCallBack)
            #endregion
            Console.ReadLine();
        }

        static void OnCallBack(IAsyncResult ar) {
            Console.WriteLine("子线程结束");
            Func<int, string, string> a = ar.AsyncState as Func<int, string, string>;//获取到委托类型的返回值
            string res = a.EndInvoke(ar);
            Console.WriteLine(res);

        }
    }
}
