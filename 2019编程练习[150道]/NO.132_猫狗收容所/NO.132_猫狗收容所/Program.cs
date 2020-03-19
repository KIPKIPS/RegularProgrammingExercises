using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._132_猫狗收容所 {
    class Program {
        static void Main(string[] args) {
            List<int> num = asylum(new[] {new[] {1, 5}, new[] {1, -6}, new[] { 1, 3 }, new[] { 1, -4 }, new[] {2, 0}, new[] {2, -1}});
            foreach (var VARIABLE in num) {
                Console.WriteLine(VARIABLE+" ");
            }
            Console.ReadLine();
        }
        public static List<int> asylum(int[][] ope) {
            // write code here
            List<int>data=new List<int>();//收容所数据,猫负,狗正
            List<int>res=new List<int>();//领养序列
            for (int i = 0; i < ope.Length; i++) {
                //进所操作
                if (ope[i][0]==1) {
                    data.Add(ope[i][1]);//收容所添加数据
                }
                //领养操作
                if (ope[i][0]==2) {
                    switch (ope[i][1]) {
                        case 0:
                            res.Add(data[0]);
                            data.RemoveAt(0);
                            break;
                        case 1:
                            for (int j = 0; j < data.Count; j++) {
                                if (data[j]>0) {
                                    res.Add(data[j]);
                                    data.RemoveAt(j);
                                    break;
                                }
                            }break;
                        case -1:
                            for (int j = 0; j < data.Count; j++) {
                                if (data[j] < 0) {
                                    res.Add(data[j]);
                                    data.RemoveAt(j);
                                    break;
                                }
                            }
                            break;
                    }
                }
            }
            return res;
        }
    }
}
