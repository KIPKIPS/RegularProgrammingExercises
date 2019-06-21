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
            Console.WriteLine("请输入一个数字");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] array= ArrayFunction(num);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
        }
        //求因子
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
            int[] array = new int[count];
            int index = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    if (IsPrime(i))
                    {
                        array[index] = i;
                        index++;
                    }
                    else
                    {
                        ArrayFunction(i);
                    }
                    
                }
            }
            return array;
        }

        //判断素数
        static bool IsPrime(int num)
        {
            bool isPrime = true;
                for (int j = 2; j < num; j++)
                {
                    if (num% j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                return isPrime;
        }
    }
}
