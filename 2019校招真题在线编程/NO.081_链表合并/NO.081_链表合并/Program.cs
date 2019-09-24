using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._081_链表合并 {
    class Program {
        static void Main(string[] args) {
            string[] inp1 = Console.ReadLine().Split(' ');
            List<int>res=new List<int>();
            for (int i = 0; i < inp1.Length; i++) {
                res.Add(Convert.ToInt32(inp1[i]));
            }
            string[] inp2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < inp2.Length; i++) {
                res.Add(Convert.ToInt32(inp2[i]));
            }
            res.Sort();
            for (int i = 0; i < res.Count; i++) {
                if (i==res.Count-1) {
                    Console.Write(res[i]);
                }
                else {
                    Console.Write(res[i]+" ");
                }
            }

            Console.ReadLine();

        }
    }
}
