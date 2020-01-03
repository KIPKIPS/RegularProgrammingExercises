using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action委托
{
    class Program
    {
        public static void StrFun(string str)
        {
            Console.WriteLine(str);
        }

        static int DontHavePara()
        {
            return 1;
        }

        static int HavePara(int a,int b)
        {
            return a+b;
        }
        static void Main(string[] args)
        {
            Action<string> a = StrFun;
            a("ss");
            Func<int> b = DontHavePara;
            Console.WriteLine(b());

            Func<int, int, int> c = HavePara;//前两个int为参数,后面的int为返回值类型
            Console.WriteLine(c(5,8));


            Console.ReadLine();
        }
    }
}
