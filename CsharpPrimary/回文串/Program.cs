using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 回文串
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool a = true;
                Console.WriteLine("请输入字符串:");
                string input = Console.ReadLine();
                string[] str = new string[input.Length];
                for(int i = 0; i < str.Length; i++)
                {
                    str[i] = Convert.ToString(input[i]);
                }
                for (int i = 0; i < str.Length / 2; i++)
                {
                    if (str[i] != str[str.Length - 1 - i])
                    {
                        a = false;
                    }
                }
                if (a == true)
                {
                    Console.WriteLine("是回文串");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("不是回文串");
                    Console.WriteLine();
                }
            }
        }
    }
}
