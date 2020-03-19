using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2 {
    public class Program {
        public static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int[]> arrList = new List<int[]>();
            //得到数组列表
            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                int[] temp = new int[s.Length];
                for (int j = 0; j < temp.Length; j++) {
                    temp[j] = Convert.ToInt32(s[j]);
                }
                arrList.Add(temp);
            }
            List<List<int>> list = new List<List<int>>();
            for (int i = 0; i < arrList.Count; i++) {
                int sum = arrList[i].Sum();//数组的和
                HashSet<int> sumDic = new HashSet<int>();
                int[] sumArr = new int[arrList[i].Length + 1];
                for (int j = 0; j < arrList[i].Length; j++) {
                    sumArr[j] = sum - arrList[i][j];
                }
                List<int> temp = new List<int>();
                sumArr[sumArr.Length - 1] = sum;
                for (int j = 0; j < sumArr.Length; j++) {
                    if (!sumDic.Contains(sumArr[j])) {
                        sumDic.Add(sumArr[j]);
                        temp.Add(sumArr[j]);
                    }
                }
                list.Add(temp);
            }
            Dictionary<int, int> res = new Dictionary<int, int>();//1 存储sum 2 次数
            for (int i = 0; i < list.Count; i++) {
                for (int j = 0; j < list[i].Count; j++) {
                    if (res.ContainsKey(list[i][j])) {
                        res[list[i][j]]++;
                    }
                    else {
                        res.Add(list[i][j], 1);
                    }
                }
            }

            int max = -1;
            foreach (KeyValuePair<int, int> kvp in res) {
                if (kvp.Value > max) {
                    max = kvp.Value;
                }
            }

            Console.WriteLine(max);


            Console.ReadLine();
        }
    }
}
