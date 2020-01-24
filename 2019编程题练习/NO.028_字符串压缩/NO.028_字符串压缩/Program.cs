using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._028_字符串压缩 {
    class Program {
        static void Main(string[] args) {
            
            string str = Console.ReadLine();
            Dictionary<char,int>dic=new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++) {
                if (dic.ContainsKey(str[i])) {
                    dic[str[i]]++;
                }
                else {
                    dic.Add(str[i],1);
                }
            }

            foreach (KeyValuePair<char,int> temp in dic) {
                Console.Write(temp.Value+""+temp.Key);
            }

            Console.ReadLine();
        }
    }
}
