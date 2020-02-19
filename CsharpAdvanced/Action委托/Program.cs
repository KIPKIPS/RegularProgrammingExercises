using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action委托 {
    class Program {
        public static void StrFun_0() {
            Console.WriteLine("str");
        }
        public static void StrFun_1(string str) {
            Console.WriteLine(str);
        }
        public static void StrFun_2(string str1,string str2) {
            Console.WriteLine(str1+str2);
        }
        static int DontHavePara() {
            return 1;
        }
        static int HavePara(int a,int b) {
            return a+b;
        }
        static void Main(string[] args) {
            //act_0封装一个方法,无返回值,无参
            Action act_0 = StrFun_0;
            act_0();
            //act_1封装一个方法,无返回值,参数为一个
            Action<string> act_1 = StrFun_1;
            act_1("a");
            Action<string,string> act_2 = StrFun_2;
            act_2("a","b");

            Func<int> b = DontHavePara;
            Console.WriteLine(b());

            Func<int, int, int> c = HavePara;//前两个int为参数,后面的int为返回值类型
            Console.WriteLine(c(5,8));
            Console.ReadLine();
        }
    }
}
