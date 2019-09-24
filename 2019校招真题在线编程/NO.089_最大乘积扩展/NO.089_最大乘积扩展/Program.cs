using System;
using System.Collections.Generic;
using System.Linq;


namespace NO._089_最大乘积扩展 {
    class Program {
        static void Main(string[] args) {
            //初始化输入和列表
            int num = Convert.ToInt32(Console.ReadLine());
            List<int> positive = new List<int>();
            List<int> negative = new List<int>();
            string[] temp = Console.ReadLine().Split(' ');//将字符串以空格符分割开来
            //将单个字符转变为int类型并存入list中
            if (temp.Length >= 3) {
                for (int i = 0; i < temp.Length; i++) {
                    if (Convert.ToInt32(temp[i]) < 0) {
                        negative.Add(Convert.ToInt32(temp[i]));//负数列表
                    }
                    else {
                        positive.Add(Convert.ToInt32(temp[i]));//正数列表
                    }
                }
                long max = 0;
                //负数 0,1 正数大于3
                if (negative.Count <=1&&positive.Count>=3) {
                    int n1 = positive.Max();
                    positive.Remove(n1);
                    int n2 = positive.Max();
                    positive.Remove(n2);
                    max = n1 * n2 * positive.Max();
                }
                //负数 1,正数 2
                if (negative.Count == 1 && positive.Count == 2) {
                    max = negative[0] * positive[0] * positive[1];
                }
                //负数 2,正数小于3
                if ((negative.Count == 2 && positive.Count <=2)||(negative.Count>=3&&positive.Count==1)) {
                    max = negative[0] * negative[1] * positive.Max();
                }
                //负数大于2,正数 0
                if (negative.Count >2 && positive.Count ==0) {
                    int n1 = negative.Min();
                    negative.Remove(n1);
                    int n2 = negative.Min();
                    negative.Remove(n2);
                    max = n1 * n2 * negative.Min();
                }
                //负数大于等于3,正数等于2
                if (negative.Count >= 3 && positive.Count ==2) {
                    int n1 = negative.Min();
                    negative.Remove(n1);
                    int n2 = negative.Min();
                    negative.Remove(n2);
                    max = n1 * n2 * positive.Max();
                }
                //负数大于等于2,正数大于2
                if (negative.Count >= 2 && positive.Count > 2) {
                    int n1 = negative.Min();
                    negative.Remove(n1);
                    int n2 = negative.Min();
                    int m1 = positive.Max();
                    positive.Remove(m1);
                    int m2 = positive.Max();
                    positive.Remove(m2);
                    max = (long)n1 * n2 * m1 > (long)m1 * m2 * positive.Max() ? (long)n1 * n2 * m1 : (long)m1 * m2 * positive.Max();
                }
                Console.WriteLine(max);
            }
            
            Console.ReadLine();
        }
    }
}