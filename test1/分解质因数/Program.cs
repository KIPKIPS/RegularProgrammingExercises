using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 分解质因数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write(num+"可以分解成: ");
            for (int i = 2; i <= num; i++)
                while (num != i)
                {
                    if (num % i == 0)
                    {
                        Console.Write(i+"*");
                        num = num / i;
                    }
                    else
                        break;
                }
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
