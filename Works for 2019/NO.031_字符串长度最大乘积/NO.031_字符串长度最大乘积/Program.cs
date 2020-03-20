using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._031_字符串长度最大乘积 {
    class Program {
        static void Main(string[] args) {
            int max = 0;
            string inp = Console.ReadLine().Replace("[", "").Replace("]", "").Replace("\"", "");
            string[] strs = inp.Split(',');
            for (int i = 0; i < strs.Length-1; i++) {
                for (int j = i+1; j < strs.Length; j++) {
                    if (HasntSameStr(strs[i], strs[j])) {
                        if (strs[i].Length*strs[j].Length>max) {
                            max = strs[i].Length * strs[j].Length;
                        }
                    }
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }

        //是否包含重复字符,不包含返回true,包含则返回false
        public static bool HasntSameStr(string a, string b) {
            if (a.Length==0&&b.Length==0) {
                return false;
            }
            for (int i = 0; i < a.Length; i++) {
                for (int j = 0; j < b.Length; j++) {
                    if (a[i]==b[j]) {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
