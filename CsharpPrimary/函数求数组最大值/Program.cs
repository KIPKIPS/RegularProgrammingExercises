using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数求数组最大值
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一串数字(以空格间隔):");
            string input = Console.ReadLine();
            string[] strTemp = input.Split(' ');
            int[] num = new int[strTemp.Length];
            for(int i = 0; i < strTemp.Length; i++)
            {
                num[i] = Convert.ToInt32(strTemp[i]);
            }
            int max = Max(num);
            Console.WriteLine("数组中的最大值为: "+max);
            Console.WriteLine();

            //参数数组求最大值,将我们输入的参数由编译器构造成一个数组,不需要我们手动'创建'一个数组
            int a=ParamsMax(5645, 4, 56, 465, 4, 654, 65, 465, 4, 654, 6, 5, 45, 4, 654, 65, 56, 4, 65, 4, 65, 456);
            Console.WriteLine(a);
            Console.ReadLine();
        }

        //数组参数函数求最大值
        static int Max(int[] array)
        {
            int max=array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        //参数数组函数求最大值
        static int ParamsMax(params int[] array)
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
    }
}
