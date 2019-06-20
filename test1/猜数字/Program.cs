using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猜数字
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 45;
            bool go = true;
            Console.WriteLine("请输入一个0到50的数字");
            while (go)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess < num)
                {
                    Console.WriteLine("你猜的小了,请重新输入");
                }
                if(guess > num)
                {
                    Console.WriteLine("你猜的大了,请重新输入");
                }
                if (guess == num)
                {
                    Console.WriteLine("OK");
                    go = false;
                }
            }
            Console.ReadLine();
        }
    }
}
