using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher=new Teacher("王");
            Student stu1=new Student("刘",teacher);
            Student stu2=new Student("张",teacher);

            //teacher.teacherCome += stu1.StopTalking;//将观察者的更新方法注册到被观察者的委托方法里面,注册
            //teacher.teacherCome += stu2.StopTalking;

            teacher.TeacherComing();//被观察者状态发生改变
            Console.ReadLine();
        }
    }
}
