using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生信息结构体
{
    struct StudentInfo
    {
        public string ID;
        public string Name;
        public string Sex;
        public int ProgramSocre;

        public string Output()
        {
            return "学生的学号为: " + ID + ",名字为: " + Name + ",性别为: " + Sex + ",程序设计的分数为: " + ProgramSocre;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo student;
            student.ID = "2016118117";
            student.Name="王琨鹏";
            student.Sex="男";
            student.ProgramSocre=70;
            Console.WriteLine(student.Output());
            Console.ReadLine();
        }
    }
}
