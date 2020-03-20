using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01 {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> res = new List<string>();
            for (int i = 0; i < n; i++) {
                string t = Console.ReadLine();
                string ans = t[0]+"";
                int state = 0;
                char cur;
                char last= t[0];
                for (int j = 1; j <t.Length; j++) {
                    cur = t[j];
                    switch (state) {
                        case 0:
                            if (cur==last) 
                                state = 1;
                            else 
                                state = 0;
                            break;
                        case 1:
                            if (cur==last) 
                                continue;
                            else 
                                state = 2;
                            break;
                        case 2:
                            if (cur==last) 
                                continue;
                            else 
                                state = 0;
                            break;
                    }
                    last = cur;
                    ans += cur;
                }
                res.Add(ans);
            }
            int index = 0;
            foreach (var r in res) {
                Console.WriteLine(r);
                index++;
            }
            Console.ReadLine();
        }
    }
}
