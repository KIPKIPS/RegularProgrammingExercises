using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 升序输出数字
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("请输入数字串(以空格分隔)：");
            string input = Console.ReadLine();
            string[] strTemp = input.Split(' ');
            int[] num = new int[strTemp.Length];
            for(int i = 0; i < strTemp.Length; i++)
            {
                num[i] = Convert.ToInt32(strTemp[i]);
            }

            //冒泡排序
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length - 1 - i; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
                Console.Write(num[i] + " ");
            }
            //Array.Sort(num);//使用了快速排序算法
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.Write(num[i] + " ");
            //}
            Console.ReadLine();

        }
    }
}
