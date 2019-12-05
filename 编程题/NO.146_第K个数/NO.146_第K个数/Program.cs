using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._146_第K个数 {
    class Program {
        static void Main(string[] args) {
            Console.ReadLine();
        }
        //查找素数因子只包含3 5 7的第K个数字
        public static int findKth(int k) {
            // write code here
            int count = 0;
            for (int i = 0; ; i++) {
                List<int> factor = GetPrimeFactor(i);//素数因子
                if (Judge(factor)) {
                    if (count==k+1) 
                        return i;
                    count++;
                }
            }
        }
        //判断因子集合是否只包含3 5 7
        public static bool Judge(List<int>factor) {
            for (int i = 0; i <factor.Count ; i++) 
                if (factor[i]!=3&&factor[i]!=5&&factor[i]!=7) 
                    return false;
            return true;
        }
        //获取目标所有素数因子
        public static List<int> GetPrimeFactor(int num) {
            List<int>res=new List<int>();
            for (int i = 1; i <=num; i++) 
                if (num%i==0&&IsPrime(i)) 
                    res.Add(i);
            return res;
        }
        //素数判别
        public static bool IsPrime(int num) {
            if (num==1) 
                return false;
            if (num==2) 
                return true;
            for (int i = 2; i < num; i++) 
                if (num%i==0) 
                    return false;
            return true;
        }
    }
}
