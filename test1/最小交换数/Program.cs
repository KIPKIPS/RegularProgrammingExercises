using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 最小交换数
{
    class Program
    {
        static void Main(string[] args)
        {
            int min,index=0,temp;
            Console.WriteLine("请输入数字串(以空格分隔)：");
            string input = Console.ReadLine();
            string[] strTemp = input.Split(' ');
            int[] num = new int[strTemp.Length];
            Console.WriteLine("你输入的数字串为：");
            for (int i = 0; i < strTemp.Length; i++)
            {
                num[i] = Convert.ToInt32(strTemp[i]);
                Console.Write(num[i] + " ");
            }
            min = num[0];
            for(int i = 1; i < num.Length; i++)
            {  
                if (min > num[i])
                {
                    index = i;
                    min = num[i];
                }
            }
            temp = num[0];
            num[0] = num[index];
            num[index] = temp;
            Console.WriteLine();
            Console.WriteLine("更新后的的数字串为：");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
