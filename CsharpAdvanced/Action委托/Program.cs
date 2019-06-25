using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action委托
{
    class Program
    {
        public static void strfun(string str)
        {
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            Action<string> a = strfun;
            a("ss");
            Console.ReadLine();
        }
    }
}
