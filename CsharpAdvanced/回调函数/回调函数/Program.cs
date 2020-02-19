using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 回调函数 {
    public delegate string ProcessDelegate(string s1, string s2);
    class Program {
        static void Main(string[] args) {
            //调用方法
            string r1 = Worker.Function("Text1", "Text2", Worker.Process1);
            string r2 = Worker.Function("Text1", "Text2", Worker.Process2);
            string r3 = Worker.Function("Text1", "Text2", Worker.Process3);

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.ReadLine();
        }
    }
    public class Worker {
        //该方法将任务交给Worker的注册方法去执行,至于需要哪个注册方法,则在调用时由用户去设定
        public static string Function(string s1, string s2, ProcessDelegate process) {
            return process(s1, s2);
        }
        //Worker的注册方法列表
        public static string Process1(string s1, string s2) {
            return s1 + s2+ " Process1";
        }
        public static string Process2(string s1, string s2) {
            return s1 + s2+ " Process2";
        }
        public static string Process3(string s1, string s2) {
            return s1 + s2+ " Process3";
        }
    }
}
