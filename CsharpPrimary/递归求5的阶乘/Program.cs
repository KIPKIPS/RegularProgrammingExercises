using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 递归求5的阶乘
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5!= "+fun(5));
            Console.WriteLine();
            //扩展
            bool stop = true;
            while (stop)
            {
                Console.WriteLine("请输入需要求阶乘的数字(输入$停止): ");
                string input = Console.ReadLine();
                int num = Convert.ToInt32(input);
                if (input == "$")
                {
                    stop = false;
                }
                Console.WriteLine(num+"!= " + fun(num));
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static int fun(int num)
        {
            if (num == 1) return 1;
            if (num == 0) return 0;
            return num * fun(num - 1);
        }
    }
}
