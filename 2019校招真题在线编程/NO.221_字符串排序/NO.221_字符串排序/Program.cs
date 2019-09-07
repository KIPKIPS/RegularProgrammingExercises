using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._221_字符串排序 {
    class Program {
        static void Main(string[] args) {
            int num = Convert.ToInt32(Console.ReadLine());
            List<char[]>str=new List<char[]>();
            for (int i = 0; i < num; i++) {
                string s = Console.ReadLine();
                char[]t=new char[6];
                s.CopyTo(s.Length-6,t,0,6);
                str.Add(t);
            }
            List<int>res=new List<int>();
            foreach (var VARIABLE in str) {
                string temp = "";
                for (int i = 0; i < 6; i++) {
                    temp += VARIABLE[i];
                }
                res.Add(Convert.ToInt32(temp));
            }
            res.Sort();
            foreach (var VARIABLE in res) {
                Console.WriteLine(VARIABLE);
            }

            Console.ReadLine();
        }
    }
}
