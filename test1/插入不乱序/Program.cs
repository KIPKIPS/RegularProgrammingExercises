using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 插入不乱序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数字串(以空格分隔,须升序排列)：");
            string str = Console.ReadLine();
            string[] strTemp = str.Split(' ');
            int[] array = new int[strTemp.Length];
            for (int i = 0; i < strTemp.Length; i++)
            {
                array[i] = Convert.ToInt32(strTemp[i]);
            }
            Console.WriteLine("请输入你想要插入的数字：");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            int[] array2 = new int[array.Length+1];
            for(int i = 0; i < array.Length; i++)
            {
                if (num >= array[i] && num <= array[i + 1])
                {
                    
                    for (int j=0;j< i+1; j++)
                    {
                        array2[j] = array[j];
                    }
                    for(int j = i+2; j < array2.Length; j++)
                    {
                        array2[j] = array[j - 1];
                    }
                    array2[i + 1] = num;
                    break;
                }
            }
            Console.WriteLine("插入后的数字串为：");
            for(int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
