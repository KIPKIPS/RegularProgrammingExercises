using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._139_最近公共祖先 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(getLCA(10, 20));
            Console.ReadLine();
        }
        public static int getLCA(int a, int b) {
            // write code here
            List<int>fatherA=new List<int>();//a的所有祖先
            List<int> fatherB = new List<int>();//b的所有祖先
            while (a>=1) {
                fatherA.Add(a);
                a /=2;
            }
            while (b >= 1) {
                fatherB.Add(b);
                b /=   2;
            }
            //遍历两条链,第一个相等的就是最近公共祖先
            for (int i = 0; i < fatherA.Count; i++) 
                for (int j = 0; j <fatherB.Count; j++) 
                    if (fatherA[i]==fatherB[j]) 
                        return fatherA[i];
            return 1;
        }
    }
}
