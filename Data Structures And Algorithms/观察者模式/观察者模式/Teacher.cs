using System;

namespace 观察者模式
{
    public class Teacher
    {
        private string name;
        public Teacher(string name)
        {
            this.name = name;
        }
        //被观察者状态发生改变
        //public void TeacherComing(Student stu1,Student stu2) {
        public void TeacherComing()
        {
            Console.WriteLine(name + "老师来了");
            //stu1.StopTalking();
            //stu2.StopTalking();
            if (teacherCome!=null) {
                teacherCome();
            }
        }
        public event Action teacherCome;//event事件声明,表示这是一个事件,声明之后在类的外部无法调用,发布消息
    }
}