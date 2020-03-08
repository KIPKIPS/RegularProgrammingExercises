using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Problem1 {
    class Program {
        static void Main(string[] args) {
            string s = Console.ReadLine();
            List< int>numIndex=new List<int>();//数字的索引

            List< string>str=new List<string>();
            List< int>num=new List<int>();
            for (int i = 0; i < s.Length; i++) {
                if (48<=s[i]&& s[i] <= 57) {
                    numIndex.Add(i);
                    num.Add(Convert.ToInt32(s[i] + ""));
                }
            }
            for (int i = 0; i < numIndex.Count-1; i++) {
                string temp = s.Substring(numIndex[i]+1, numIndex[i + 1]- numIndex[i]-1);
                str.Add(temp);
            }
            str.Add(s.Substring(numIndex[numIndex.Count - 1] + 1));
            string res = "";
            for (int i = 0; i < num.Count; i++) {
                for (int j = 0; j <num[i]; j++) {
                    res += str[i];
                }
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
