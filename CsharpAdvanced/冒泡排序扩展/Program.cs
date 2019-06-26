using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序扩展
{
    class Program
    {
        static void Sort(int[] array)
        {
            //冒泡排序
            bool change = true;
            do
            {
                change = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        change = true;
                    }
                }
            } while (change);


        }

        static void CommonSort<T>(T[] array, Func<T, T, bool> compareMethod)
        {
            bool change = true;
            do
            {
                change = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if(compareMethod(array[i],array[i+1]))
                    {
                        T temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        change = true;
                    }
                }
            } while (change);
        }

        static void Main(string[] args)
        {
            //int[] arr = {45, 655, 465, 13, 2156, 48, 946, 515, 321, 654, 86, 1563, 1};
            //Sort(arr);
            //foreach (var VARIABLE in arr)
            //{
            //    Console.Write(VARIABLE+" ");
            //}


            //创建employee类型数组
            Employee[] em = new Employee[]
            {
                new Employee("wkp",15000),
                new Employee("asd",1560),
                new Employee("sdfg",252),
                new Employee("asdf",15254),
                new Employee("sgb",15535),
                new Employee("weqr",154500),
                new Employee("wsdb",150400),
                new Employee("mjgm",1700)
            };
            CommonSort<Employee>(em,Employee.Compare);
            foreach (Employee VARIABLE in em)
            {
                Console.WriteLine(VARIABLE+" ");
            }

            Console.ReadLine();
        }
    }
}
