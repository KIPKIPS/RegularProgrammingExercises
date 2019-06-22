using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数
{
    class StudentInfo
    {
        private string name;
        private int age;

        //有参的构造函数
        public StudentInfo(string name,int age)
        {
            this.name = name;
            this.age = age;
        }  

        public string ShowName()
        {
            return name;
        }
        public int ShowAge()
        {
            return age;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }public int Age
        {
            set { age = value; }
            get { return age; }
        }
    }
}
