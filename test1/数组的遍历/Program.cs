using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组的遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1,2,5,4,5,456,6,465,4,6546};
            //for循环遍历
            Console.WriteLine("for循环遍历");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+"  ");
            }
            Console.WriteLine();

            //do while遍历
            int j = 0;
            Console.WriteLine("do while循环遍历");
            do
            {
                Console.Write(array[j] + "  ");
                j++;
            }
            while (j < array.Length);
            Console.WriteLine();
            
            //while遍历
            Console.WriteLine("while循环遍历");
            int k = 0;
            while (k < array.Length)
            {
                Console.Write(array[k] + "  ");
                k++;
            }
            Console.WriteLine();

            //foreach循环遍历
            Console.WriteLine("foreach循环遍历");
            foreach (int m in array)
            {
                Console.Write(m + "  ");
            }

            Console.ReadLine();
        }
    }
}
