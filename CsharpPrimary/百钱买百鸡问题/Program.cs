using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 百钱买百鸡问题
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            for (int cock = 0; cock <= 100; cock++)
            {
                for (int hen = 0; hen <= 100; hen++)
                {
                    for (int chick = 0; chick <= 100; chick++)
                    {
                        if ((15 * cock + 9 * hen + chick) == 300 && cock + hen + chick == 100)
                        {
                            Console.WriteLine("方案"+index+" : 公鸡"+cock+"只,母鸡"+hen+"只,小鸡"+chick+"只。");
                            index++;
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
