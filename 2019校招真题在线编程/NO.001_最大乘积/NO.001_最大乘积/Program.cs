using System;
using System.Collections.Generic;
using System.Linq;


namespace NO._001_最大乘积 {
    class Program {
        static void Main(string[] args) {
            //初始化输入和列表
            int num = Convert.ToInt32(Console.ReadLine());
            List<int>list=new List<int>();
            string temp = Console.ReadLine();
            string[] tempStringArray = temp.Split(' ');
            for (int i = 0; i < tempStringArray.Length; i++) {
                list.Add(Convert.ToInt32(tempStringArray[i]));
            }
            
            //记录列表元素最大项
            int[]res=new int[3];
            
            res[0] = list.Max();
            list.Remove(list.Max());//列表元素移除最大项
            res[1] = list.Max();
            list.Remove(list.Max());
            res[2] = list.Max();
            Console.WriteLine(res[0]*res[1]*res[2]);
            Console.ReadLine();
        }
    }
}
