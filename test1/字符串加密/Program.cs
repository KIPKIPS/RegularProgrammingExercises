using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串加密
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入字符串：");
            string str = Console.ReadLine();
            Console.WriteLine("加密后的字符串为：");
            for (int i = 0; i < str.Length; i++)
            {
                if((str[i]>='a'&&str[i]<='z'))
                {
                    int num = str[i];
                    num = num + 3;
                    char ch = (char)num;
                    if (ch > 'z')
                    {
                        ch=(char)(ch - 'z' + 'a' - 1);
                    }
                    Console.Write(ch);
                }
                else if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    int num = str[i];
                    num = num + 3;
                    char ch = (char)num;
                    if (ch > 'Z')
                    {
                        ch = (char)(ch - 'Z' + 'A' - 1);
                    }
                    Console.Write(ch);
                }
                else
                {
                    Console.Write(str[i]);
                }
                
            }
            Console.ReadLine();
        }
    }
}
