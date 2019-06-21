using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数重载
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("整数数组的最大值为: "+Max(5, 465, 4, 56, 7, 456, 465, 132));
            Console.WriteLine("小数数组的最大值为: "+Max(42.4524, 564.56, 87.56, 564.54, 564.8));
            Console.ReadLine();
        }

        static int Max(params int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        static double Max(params double[] array)
        {
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}
