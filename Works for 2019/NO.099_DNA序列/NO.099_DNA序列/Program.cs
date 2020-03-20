using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._099_DNA序列 {
    class Program {
        static void Main(string[] args) {
            //每种长度n都会有2^n种可能。例如长度为1时就有（A，C，G，T）这四种。
            //n=2，时就16种。接下来，寻找输入串中，长度为n的子串有多少种
            //如果数量不足2^n个，则输出n即可。
            string input = Console.ReadLine();
            for (int i = 1; i <= input.Length; i++) {
                HashSet<string> map = new HashSet<string>();
                for (int j = 0; j <= input.Length - i; j++) {
                    map.Add(input.Substring(j, i));
                }
                if (map.Count < Math.Pow(4, i)) {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
