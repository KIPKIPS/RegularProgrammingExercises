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
            Console.ReadLine();
        }
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
    }
}
