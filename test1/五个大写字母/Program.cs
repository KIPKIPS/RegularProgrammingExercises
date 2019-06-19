using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 五个大写字母
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("请输入五个大写字母：");
            while (true)
            {
                for (int i = 0; i < 5; i++)
                {
                    char word = Convert.ToChar(Console.ReadLine());
                    if (word >= 'a' && word <= 'z')
                    {
                        Console.WriteLine("请输入大写字母");
                    }
                    if (count < 5)
                    {
                        if (word >= 'A' && word <= 'Z')
                        {
                            count++;
                            Console.WriteLine("OK,请继续输入大写字母");
                            continue;
                        }
                    }

                    if (count == 5)
                    {
                        break;
                    }
                }
            }
            Console.ReadLine();
         }
    }
}
