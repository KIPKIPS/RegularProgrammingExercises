using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo me=new StudentInfo("王琨鹏",21);
            Console.WriteLine("我的名字是"+me.ShowName()+",我今年"+me.ShowAge()+"岁了");
            Console.WriteLine();

            //通过属性访问类的字段值
            me.Name = "aisohd";
            me.Age = 85;
            Console.WriteLine("我的名字是" + me.Name + ",我今年" + me.Age + "岁了");
            Console.ReadLine();
        }
    }
}
