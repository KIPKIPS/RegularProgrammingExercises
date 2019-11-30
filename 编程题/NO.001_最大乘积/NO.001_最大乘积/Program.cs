using System;
using System.Collections.Generic;
using System.Linq;


namespace NO._001_最大乘积 {
    class Program {
        static void Main(string[] args) {

            //初始化输入和列表
            int num = Convert.ToInt32(Console.ReadLine());
            List<int> positive= new List<int>();
            List<int> negative=new List<int>();
            string temp = Console.ReadLine();
            string[] tempStringArray = temp.Split(' ');//将字符串以空格符分割开来
            //将单个字符转变为int类型并存入list中
            for (int i = 0; i < tempStringArray.Length; i++) {
                if (Convert.ToInt32(tempStringArray[i])<0) {
                    negative.Add(Convert.ToInt32(tempStringArray[i]));//负数列表
                }
                else {
                    positive.Add(Convert.ToInt32(tempStringArray[i]));//正数列表
                }
            }
            negative.Sort();positive.Sort();
            int res = 0;
            switch (negative.Count) {
                case 0: case 1:
                    res = positive[2] * positive[3] * positive[4];
                    break;
                case 2:
                    if (negative[0]*negative[1]>positive[0]*positive[1]) {
                        res = negative[0] * negative[1] * positive.Max();
                    }
                    else {
                        res = positive[0] * positive[1] * positive[2];
                    }
                    break;
                case 3: res = negative[1] * negative[0] * positive.Max();break;
                case 4:res= negative[1] * negative[0] * positive[0]; break;
                case 5:
                    res = negative[1] * negative[0] * negative[2];break;
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
