using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型与泛型类
{
    class Program
    {
        //泛型方法
        public static string Sum<T,T1,T2>(T a, T b)
        {
            return a + "" + b;
        }
        static void Main(string[] args)
        {
            var obj1=new Genericity<int,string>(32,85,"adsf");
            Console.WriteLine(Convert.ToString(obj1.Sum()));
            Console.ReadLine();
        }
    }
}
