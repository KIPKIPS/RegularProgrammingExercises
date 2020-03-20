using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 反射和特性 {
    class Program {
        static void Main(string[] args) {
            //每一个类对应一个type对象,这个type对象存储了这个类的方法,字段,成员,不存储类的成员的值
            MyClass my = new MyClass();
            Type type = my.GetType();
            Console.WriteLine("类名: " + type.Name);//获取类名
            Console.WriteLine("类的命名空间: " + type.Namespace);//获取类的命名空间

            Console.WriteLine("类的程序集: " + type.Assembly);//获取类的程序集
            Console.WriteLine();
            Assembly assem = type.Assembly;//获取类的程序集
            Type[] types = assem.GetTypes();
            foreach (var temp in types) {
                Console.WriteLine("类有:" + temp);
            }
            Console.WriteLine();
            Console.WriteLine("类的程序集: " + assem);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("类的字段有: ");
            FieldInfo[] array = type.GetFields();//获取类包含的字段
            //只能获取公有的字段
            foreach (FieldInfo temp in array) {
                Console.Write(temp.Name + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("类的属性有: ");
            //只能获取公有的属性
            PropertyInfo[] array1 = type.GetProperties();//获取类的属性成员
            foreach (PropertyInfo temp in array1) {
                Console.Write(temp.Name + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("类的方法有: ");
            //只能获取公有的方法
            MethodInfo[] array3 = type.GetMethods();//获取类的方法成员
            int count = 0;
            foreach (MethodInfo temp in array3) {
                count++;
                Console.Write(temp.Name + "            \t");
                if (count % 5 == 0) {
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
