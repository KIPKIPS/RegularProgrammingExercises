using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace NO._149_变位词排序 {
    class Program {
        static void Main(string[] args) {
            string[] str = new[] { "cba", "abc",  "ab", "ba", "am","acb"};
            foreach (var VARIABLE in sortStrings(str,6)) {
                Console.Write(VARIABLE+" ");
            }

            Console.ReadLine();
        }
        public static List<string> sortStrings(string[] str, int n) {
            // write code here
            List<string>res=new List<string>();
            HashSet<string>map=new HashSet<string>();
            Array.Sort(str);
            for (int i = 0; i < str.Length; i++) {
                //字典序字符串
                char[] arr = str[i].ToCharArray();
                Array.Sort(arr);
                string t = "";
                for (int j = 0; j < arr.Length; j++) {
                    t += arr[j];
                }

                if (!map.Contains(t)) {
                    map.Add(t);
                    res.Add(str[i]);
                }
            }
            return res;
        }
    }
}
