using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder使用
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s=new StringBuilder("123",10);
            s.Append("456");//Append方法将一串字符添加到之前的字符串的后面
            s.Replace("123", "456");
            s.Replace('5', ' ');

            Console.WriteLine(s);
            Console.Read();
        }
    }
}
