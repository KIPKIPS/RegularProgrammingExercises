using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._127_原串翻转
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(reverseString("This is nowcoder"));
            Console.ReadLine();
        }
        public static string reverseString(string iniString) {
            string s = "";
            // write code here
            for (int i = iniString.Length-1; i >=0; i--) {
                s += iniString[i];
            }

            return s;
        }
    }
}
