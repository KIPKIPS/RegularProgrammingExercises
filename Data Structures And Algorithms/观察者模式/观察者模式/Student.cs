using System;

namespace 观察者模式 {
    //观察者类
    public class Student {
        private string name;

        public Student(string name,Teacher teacher) {
            this.name = name;
            teacher.teacherCome += StopTalking;//注册操作,订阅消息,将自身的方法注册到订阅事件
        }

        public void StopTalking() {
            Console.WriteLine(name+ "同学停止了讨论");
        }
    }
}