using System;
using System.Diagnostics;

namespace NO._079_小明的字符串 {
    class Program {
        static void Main(string[] args) {
            string[] op = Console.ReadLine().Split(' ');
            string obj = Console.ReadLine();//操作对象
            string[] OpeCol = new string[Convert.ToInt32(op[1])];//操作集合
            for (int i = 0; i < Convert.ToInt32(op[1]); i++) {
                string temp = Console.ReadLine();
                OpeCol[i] = temp;
            }
            Operation(obj, OpeCol);
            Console.ReadLine();
        }

        public static void Operation(string obj, string[] OpeCol) {
            for (int i = 0; i < OpeCol.Length; i++) {
                string[] temp = OpeCol[i].Split(' ');
                int index = Convert.ToInt32(temp[1] + "");
                if (Convert.ToInt32(temp[0] + "") == 1)
                    obj = obj.Substring(obj.Length - index) + obj.Substring(0, obj.Length - index);//操作1,旋转字符串
                else
                    Console.WriteLine(obj[index]);//操作2,输出索引处的字符
                
            }
        }
    }
}
