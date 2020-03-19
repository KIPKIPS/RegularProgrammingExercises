using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._060_最长对称子字符串 {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine(IsSymmetry("a"));
            string inp = Console.ReadLine();
            Dictionary<string,int>dic=new Dictionary<string, int>();
            List< int>length=new List<int>();
            if (inp.Length!=0) {
                for (int i = 0; i < inp.Length; i++) {
                    for (int j = i; j < inp.Length; j++) {
                        string temp = "";
                        for (int k = i; k <= j; k++) {
                            temp += inp[k] + "";
                        }
                        //Console.WriteLine(temp);
                        if (IsSymmetry(temp)) {
                            if (!dic.ContainsKey(temp)) {
                                dic.Add(temp,1);
                            }
                            length.Add(temp.Length);
                        }
                    }
                }

                foreach (KeyValuePair<string,int> VARIABLE in dic) {
                    if (VARIABLE.Key.Length==length.Max()) {
                        Console.WriteLine(VARIABLE.Key);
                    }
                }
            }
            else {
                Console.WriteLine(0);
            }
            Console.ReadLine();
        }
        public static bool IsSymmetry(string str) {
            for (int i = 0; i < str.Length/2; i++) {
                if (str[i]!=str[str.Length-i-1]) {
                    return false;
                }
            }
            return true;
        }
    }
}
