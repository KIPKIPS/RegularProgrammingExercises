using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._047_输出指定长度子串 {
    class Program {
        static void Main(string[] args) {
            string inp= Console.ReadLine();
            int num = Convert.ToInt32(Console.ReadLine());
            if (num>inp.Length||num<0||inp.Length==0) {
                Console.WriteLine(-1);
            }
            else {
                List<string> res = new List<string>();
                for (int i = 0; i <= inp.Length - num; i++) {
                    string temp = "";
                    for (int j = i; j < i + num; j++) {
                        temp += inp[j] + "";
                    }
                    res.Add(temp);
                }

                for (int i = 0; i < res.Count; i++) {
                    if (i == res.Count - 1) {
                        Console.Write(res[i]);
                    }
                    else {
                        Console.Write(res[i] + " ");
                    }
                }
                Console.ReadLine();
            }
            
        }
    }
}
