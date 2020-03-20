using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02 {
    class Program {
        static void Main(string[] args) {
            string[] t = Console.ReadLine().Split(' ');
            int restDis = Convert.ToInt32(t[0]);
            int maxDis = restDis;
            int restWater = Convert.ToInt32(t[1]);
            string[] dis = Console.ReadLine().Split(' ');
            string[] supply= Console.ReadLine().Split(' ');
            List<int[]> data=new List<int[]>();
            for (int i = 0; i < dis.Length; i++) {
                int[] temp=new int[2];
                temp[0] = Convert.ToInt32(dis[i]);
                temp[1] = Convert.ToInt32(supply[i]);
                data.Add(temp);
            }

            int res = 0;
            int curDis = 0;
            int curIndex = 0;
            int lastIndex = 0;
            while (restDis>restWater) {
                int max = data[curIndex][1];//可到达距离最大水供给量
                for (int i = curIndex+1; i < data.Count; i++) {
                    if (data[i][0]-curDis<=restWater&&data[i][1]>=max) {
                        max = data[i][1];
                        curIndex = i;
                        break;
                    }
                }
                curDis = data[curIndex][0];
                restDis =maxDis-curDis;
                restWater -= data[curIndex][0]-data[lastIndex][0];
                restWater += max;
                lastIndex = curIndex;
                res++;
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
