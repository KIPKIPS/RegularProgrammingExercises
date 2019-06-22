using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp合法字符判断
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入变量名：");
                string name = Console.ReadLine();
                if ((name[0] >= 'a' && name[0] <= 'z') || (name[0] >= 'A' && name[0] <= 'Z') || (name[0] == '_') || (name[0] == '@'))
                {
                    for (int i = 1; i < name.Length; i++)
                    {
                        if (name[i] != '@')
                        {
                            if (i == name.Length-1)
                            {
                                Console.WriteLine("变量名合法");
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("变量名命名不合法");
                            Console.WriteLine();
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("变量名命名不合法");
                    Console.WriteLine();
                }
            }
            //Console.ReadLine();
        }
    }
}
