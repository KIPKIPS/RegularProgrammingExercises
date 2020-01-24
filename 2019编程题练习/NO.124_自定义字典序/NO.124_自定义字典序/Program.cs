using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._124_自定义字典序
{
    class Program
    {
        //字典序列
        private static string dic;
        static void Main(string[] args)
        {
            dic = Console.ReadLine();//字典
            int num = int.Parse(Console.ReadLine());//排序字符串个数
            string[] data = new string[num];//存储数组
            for (int i = 0; i < num; i++)
                data[i] = Console.ReadLine();
            Sort(data);//排序
            Console.WriteLine("--------------------");
            for (int i = 0; i < data.Length; i++)
                Console.WriteLine(data[i]);
            Console.ReadLine();
        }
        //冒泡排序
        static string[] Sort(string[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (Compare(array[i], array[j]))
                    {
                        string temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
            return array;
        }
        //比较函数
        //按照字典序比较两个字符串
        static bool Compare(string a, string b)
        {
            int[] numA = Parse(a);
            int[] numB = Parse(b);
            for (int i = 0; i < (a.Length > b.Length ? b.Length : a.Length); i++)
                if (numA[i] != numB[i])
                    return numA[i] > numB[i] ? true : false;
            return a.Length > b.Length ? true : false;
        }
        //转换函数
        //将目标字符串的每一位按照字典序转换成一个int类型的数组(数组对应数据为字典序的下标)
        public static int[] Parse(string target)
        {
            int count = 0;
            int[] temp = new int[target.Length];
            for (int i = 0; i < target.Length; i++)
            {
                for (int j = 0; j < dic.Length; j++)
                    if (target[i] == dic[j])
                        temp[count] = j + 1;
                count++;
            }
            return temp;
        }
    }
}
