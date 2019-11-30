using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._090_六一儿童节 {
    class Program {
        static void Main(string[] args) {
            Console.ReadLine();
            string[] inp = Console.ReadLine().Split(' ');
            List<int> gi = new List<int>();//孩子的胃口值
            for (int i = 0; i < inp.Length; i++) {
                gi.Add(Convert.ToInt32(inp[i]));
            }
            Console.ReadLine();
            string[] inp2 = Console.ReadLine().Split(' ');
            List<int> sj = new List<int>();//糖果的size值
            for (int i = 0; i < inp2.Length; i++) {
                sj.Add(Convert.ToInt32(inp2[i]));
            }

            //贪心算法搜索符合要求的最大匹配项
            int count = 0;
            for (int i = 0; i < sj.Count; i++) {//糖果尺寸
                List<int> kids = new List<int>();
                for (int j = 0; j < gi.Count; j++) {
                    if (gi[j] <= sj[i] && gi[j] != -1) {
                        kids.Add(gi[j]);
                    }
                }
                if (kids.Count != 0) {
                    gi[gi.FindIndex(t => t == kids.Max())] = -1;//将gi中符合kids.max的值置为-1
                    count++;
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}