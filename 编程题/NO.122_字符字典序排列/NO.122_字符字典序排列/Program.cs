using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NO._122_字符字典序排列 {
    class Program {
        static void Main(string[] args) {
            string[] array = new[] {"a", "bbb", "zzz", "abc", "bbb", "c","ab"};
            Sort<string>(array);
            int[]a=new []{1,2,5,8,3};
            Sort<int>(a);
            foreach (var VARIABLE in a) {
                Console.Write(VARIABLE + " ");
            }
            Console.WriteLine();
            foreach (var VARIABLE in array) {
                Console.WriteLine(VARIABLE);
            }
            Console.ReadLine();
        }
        //排序
        static string[] Sort<T>(string[] array) {
            for (int i = 0; i < array.Length-1; i++) {
                for (int j = i+1; j <array.Length ; j++) {
                    if (Greater(array[i],array[j])) {
                        //swap
                        string temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        //比较函数
        public static bool Greater(string a, string b) {
            int i = 0;
            while (true) {
                if (a[i] == b[i]) {
                    i++;
                    if (i == a.Length && i < b.Length)
                        return false;
                    if (i == b.Length && i < a.Length)
                        return true;
                    if (i==a.Length&&i==b.Length)
                        return false;
                    }
                if (a[i] > b[i])
                    return true;
                if (a[i] < b[i])
                    return false;
            }
        }

        static int[] Sort<T>(int[] array) {
            for (int i = 0; i < array.Length - 1; i++) {
                for (int j = i + 1; j < array.Length; j++) {
                    if ((array[i]>array[j])) {
                        //swap
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}
