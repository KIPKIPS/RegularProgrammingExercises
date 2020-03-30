
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 连续任务 {
    
    class Program {
        static void FirstTask() {
            Console.WriteLine("Task"+ Task.CurrentId + " is running");
            Thread.Sleep(5000);
            Console.WriteLine("Task"+ Task.CurrentId + " is finished");
        }
        static void SecondTask(object state) {
            Console.WriteLine("Task" + Task.CurrentId + " is running");
            Thread.Sleep(5000);
            Console.WriteLine("Task" + Task.CurrentId + " is finished");
        }

        static void DoError(object state) {
            Console.WriteLine("Error");
        }
        static void Main(string[] args) {
            Task t1=new Task(FirstTask);
            t1.Start();
            Task t2 = t1.ContinueWith(SecondTask);
            Task t3 = t1.ContinueWith(SecondTask);
            Task t4 = t2.ContinueWith(SecondTask);
            Task t5 = t1.ContinueWith(DoError,TaskContinuationOptions.OnlyOnFaulted);
            Console.ReadLine();
        }
    }
}
