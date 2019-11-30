using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模式串匹配问题 {
    class Program {
        static void Main(string[] args) {
            string main = "ccccccinin";
            string target = "in";
            foreach (var VARIABLE in PatternStringMatching(main,1,target)) {
                Console.Write("字符串 "+main+" 的第 "+VARIABLE+" 处存在模式串 "+target);
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static List<int> PatternStringMatching(string main, int pos, string target) {
            List<int>result=new List<int>();
            for (int i = pos-1; i < main.Length; i++) {
                if (main[i]==target[0]&&i+target.Length<=main.Length) {
                    for (int j = i; j < target.Length+i; j++) {
                        if (main[j]==target[j-i]) {
                            if ((j-i+1)==target.Length) {
                                result.Add(i + 1);
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
