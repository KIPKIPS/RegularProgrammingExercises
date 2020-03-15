using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04 {
    class Program {
        static void Main(string[] args) {
            string[] a = Console.ReadLine().Split(' ');
            int num = Convert.ToInt32(a[0]);
            int attackNum= Convert.ToInt32(a[1]);
            Dictionary<int,List<int>> dic=new Dictionary<int, List<int>>();
            for (int i = 0; i < num; i++) {
                string[] temp = Console.ReadLine().Split(' ');
                int beforeIndex = Convert.ToInt32(temp[0]);
                int money = Convert.ToInt32(temp[1]);
                if (dic.ContainsKey(beforeIndex)) {
                    dic[beforeIndex].Add(money);
                }
                else {
                    List<int>t=new List<int>{ money };
                    dic.Add(beforeIndex,t);
                }
            }
            int res = 0;
            res += dic[0].Max();
            dic[0].Remove(res);
            int curIndex = 0;
            while (attackNum>1) {
                int curMax = 0;
                foreach (KeyValuePair<int,List<int>> kvp in dic) {
                    if (kvp.Key==curIndex||kvp.Key==curIndex+1) {
                        if (kvp.Value.Count>0) {
                            curMax = kvp.Value.Max();
                            kvp.Value.Remove(curMax);
                            curIndex = kvp.Key;
                        }
                    }
                }
                res += curMax;
                attackNum--;
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
