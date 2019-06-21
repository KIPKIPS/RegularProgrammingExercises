using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 安全密码检测
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool hasNumber = false;
                bool hasUpperWord = false;
                bool hasLowerWord = false;
                bool hasSymbol = false;
                int count = 0;
                Console.WriteLine("请输入密码:");
                string input = Console.ReadLine();
                if (!(input.Length >= 8 && input.Length <= 16))
                {
                    Console.WriteLine("不是安全的密码");
                    Console.WriteLine();
                }
                else
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] >= 'a' && input[i] <= 'z')
                        {
                            hasLowerWord = true;
                        }
                        if (input[i] >= 'A' && input[i] <= 'Z')
                        {
                            hasUpperWord = true;
                        }
                        if (input[i] == '~' || input[i] == '!' || input[i] == '@' || input[i] == '#' || input[i] == '$' || input[i] == '%' || input[i] == '^')
                        {
                            hasSymbol = true;
                        }
                        if (input[i] >= '0' && input[i] <= '9')
                        {
                            hasNumber = true;
                        }
                    }
                }
                if (hasLowerWord == true)
                {
                    count++;
                }
                if (hasUpperWord == true)
                {
                    count++;
                }
                if (hasSymbol == true)
                {
                    count++;
                }
                if (hasNumber == true)
                {
                    count++;
                }
                Console.WriteLine(count);
                if (count >= 3)
                {
                    Console.WriteLine("是安全的密码");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("不是安全的密码");
                    Console.WriteLine();
                }
            }
        }
    }
}
