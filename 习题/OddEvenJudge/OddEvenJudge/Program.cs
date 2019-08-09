using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenJudge {
    class Program {
        static void Main(string[] args) {
            List<int>num=new List<int>(){1,2,5,564,654,613,2,123,48,4156,132,6};
            List<int>oddNumber=new List<int>();//奇数表
            List<int>evenNumber=new List<int>();//偶数表
            for (int i = 0; i < num.Count; i++) {
                if (num[i]%2==0) {
                    evenNumber.Add(num[i]);
                }
                else {
                    oddNumber.Add(num[i]);
                }
            }
            evenNumber.Sort();
            oddNumber.Sort();
            Console.Write("奇数表为: ");
            foreach (var VARIABLE in oddNumber) {
                Console.Write(VARIABLE+" ");
            }
            Console.WriteLine();
            Console.Write("偶数表为: ");
            foreach (var VARIABLE in evenNumber) {
                Console.Write(VARIABLE + " ");
            }

            Console.ReadLine();
        }
    }
}
