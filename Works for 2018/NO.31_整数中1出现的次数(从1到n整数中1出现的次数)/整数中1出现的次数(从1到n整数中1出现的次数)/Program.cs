using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 整数中1出现的次数_从1到n整数中1出现的次数_ {
    class Program {
        static void Main(string[] args) {
            Program x=new Program();
            
            Console.WriteLine(x.NumberOf1Between1AndN_Solution(13));
            Console.ReadLine();
        }
        public int NumberOf1Between1AndN_Solution(int n) {
            // write code here
            int sum = 0;
            for (int i = 1; i <= n; i++) {
                string temp=i.ToString();
                for (int j = 0; j < temp.Length; j++) {
                    if (temp[j]=='1') {
                        sum++;
                    }
                }
            }

            return sum;
        }
    }
}
