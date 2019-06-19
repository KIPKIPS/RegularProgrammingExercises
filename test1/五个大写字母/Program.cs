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
            while (true)
            {
                Console.WriteLine("请输入五个大写字母:");
                string str = Console.ReadLine();
                bool isAllUpperChar = true;
                for (int i = 0; i < 5; i++)
                {
                    if (str[i] >= 'A' && str[i] <= 'Z')
                    {

                    }
                    else
                    {
                        isAllUpperChar = false;
                        break;
                    }
                }
                if (isAllUpperChar == false)
                {
                    Console.WriteLine("重新输入");
                }
                if (isAllUpperChar == true)
                {
                    Console.WriteLine("OK");
                }
            }
        } 
    }
}
