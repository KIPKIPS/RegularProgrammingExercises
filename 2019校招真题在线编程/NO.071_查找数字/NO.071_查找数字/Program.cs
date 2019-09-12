using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._071_查找数字 {
    class Program {
        static void Main(string[] args) {
            List<int> nums = new List<int>();
            while (true) {
                int temp;
                if (int.TryParse(Console.ReadLine(), out temp))
                    nums.Add(temp);
                else
                    break;
            }
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (var VARIABLE in nums) {
                if (dic.ContainsKey(VARIABLE))
                    dic[VARIABLE]++;
                else dic.Add(VARIABLE, 1);
            }
            List<int>res=new List<int>();
            foreach (KeyValuePair<int,int> VARIABLE in dic) {
                if (VARIABLE.Value<=1) {
                    res.Add(VARIABLE.Key);
                }
                if (res.Count==2) {
                    break;
                }
            }
            res.Sort();
            Console.WriteLine(res[0]+" "+res[1]);
            Console.ReadLine();
        }
    }
}
