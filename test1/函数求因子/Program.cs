using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数求因子
{
    class Program
    {
        //普通方法
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入需要求因子的数:");
                string input = Console.ReadLine();
                int num = Convert.ToInt32(input);
                Console.WriteLine("普通方法:");
                Function(num);
                Console.WriteLine();
                Console.WriteLine("数组方法:");
                int []array=ArrayFunction(num);
                foreach(int temp in array)
                {
                    Console.Write(temp + " ");
                }
                Console.WriteLine();
            }
        }
        static void Function(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        //数组方法
        static int[] ArrayFunction(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            int[] array=new int[count];
            int index = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    array[index] = i;
                    index++;
                }
            }
            return array;
        }
    }
}
