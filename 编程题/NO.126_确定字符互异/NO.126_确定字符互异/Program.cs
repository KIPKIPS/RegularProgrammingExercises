using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._126_确定字符互异
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckDifferent(Console.ReadLine())?"True":"Fales");
            Console.ReadLine();
        }
        public static bool CheckDifferent(string iniString)
        {
            // write code here
            for (int i = 0; i < iniString.Length-1; i++) {
                for (int j = i+1; j < iniString.Length; j++) {
                    if (iniString[i]==iniString[j]) {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
