using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数
{
    public class StudentInfo
    {

        //有参的构造函数
        public StudentInfo(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string ShowName()
        {
            return Name;
        }

        public int ShowAge()
        {
            return Age;
        }

        public string Name { set; get; }
        public int Age { set; get; }
    }
}