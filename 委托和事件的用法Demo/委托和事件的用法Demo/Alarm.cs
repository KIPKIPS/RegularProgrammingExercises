using System;

namespace 委托和事件的用法Demo {
    public class Alarm {
        public void MakeAlert(int param) {
            Console.WriteLine("Alarm：嘀嘀嘀，水已经"+ param + "度了：");
        }
    }
}