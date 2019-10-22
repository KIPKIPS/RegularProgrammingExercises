using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 线程争用资源问题 {
    class Program {
        static void ChangeState(object o) {
            Test test = (Test) o;//将object类型的参数转换成Test类型,并赋给test
            while (true) {
                lock (test) { //申请test对象锁定,如果该对象被锁定,就暂停直到获取到该对象,然后将其锁定,锁定之后该对象不能被访问
                                   //直到持有该对象的线程使用完将该对象释放
                                   //lock只能锁定引用类型,不能锁定值类型
                    test.ChangeState();
                }

            }
        }
        static void Main(string[] args) {
            Test test=new Test();//创建一个Test对象
            Thread t=new Thread(ChangeState);//线程调用ChangeState方法
            t.Start(test);//将Test对象作为ChangeState函数的参数传递给线程
            //再开启一个线程
            new Thread(ChangeState).Start();
            Console.ReadLine();
        }
    }
}
