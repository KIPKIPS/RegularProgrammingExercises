using System;
namespace 委托和事件的用法Demo {
    public class Display {
        public static void ShowMsg(int param) { //静态方法
            Console.WriteLine("Display：水快烧开了，当前温度："+ param + "度。");
        }
    }
}