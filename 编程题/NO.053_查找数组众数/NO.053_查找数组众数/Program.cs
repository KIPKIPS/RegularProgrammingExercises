using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._053_查找数组众数 {
    class Program {
        static void Main(string[] args) {
            string[] str = Console.ReadLine().Replace("[", "").Replace("]", "").Split(',');
            Dictionary<string,int>dic=new Dictionary<string, int>();
            for (int i = 0; i < str.Length; i++) {
                if (dic.ContainsKey(str[i])) {
                    dic[str[i]]++;
                }
                else {
                    dic.Add(str[i],1);
                }
            }

            foreach (KeyValuePair<string,int> kvp in dic) {
                if (kvp.Value>str.Length/2) {
                    Console.WriteLine(kvp.Key);
                }
            }
        }
    }
}
