using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gather {
    class Program{
        struct Gather {
            public int[] data;
            public int Length;
        };
        static void Main(string[] args) {
            int[] g1Data={0};
            Gather gather1= CreateGather(g1Data, g1Data.Length);

            int[] g2Data = { 1,2};
            Gather gather2 = CreateGather(g2Data, g2Data.Length);
            Console.Write("集合一和集合二的交集为: ");
            if (IntGather(gather1, gather2).Length!=0) {
                DispGather(IntGather(gather1, gather2));
            }

            Console.WriteLine();
            Console.ReadLine();
        }

        //创建集合
        static Gather CreateGather( int[] a, int n) {
            Gather s=new Gather();
            s.data=new int[a.Length];
            for (int i = 0; i < n; i++) {
                s.data[i] = a[i];
            }
            s.Length = n;
            return s;
        }

        //输出集合
        static void DispGather(Gather s) {
            for (int i = 0; i < s.Length; i++) {
                Console.Write(s.data[i]+" ");
            }
        }
        //判断元素是否在集合中
        static bool InGather(int num, Gather s) {
            for (int i = 0; i < s.Length; i++) {
                if (num==s.data[i]) {
                    return true;
                }
            }
            return false;
        }
        //求两个集合的并集
        static Gather SumGather(Gather g1, Gather g2) {
            List<int>sum=new List<int>();
            if (g1.Length>g2.Length) {
                for (int i = 0; i < g1.Length; i++) {
                    sum.Add(g1.data[i]);
                }
                for (int i = 0; i < g2.Length; i++) {
                    if (!InGather(g2.data[i], g1)) {
                        sum.Add(g2.data[i]);
                    }
                }
            }
            else {
                for (int i = 0; i < g2.Length; i++) {
                    sum.Add(g2.data[i]);
                }
                for (int i = 0; i < g1.Length; i++) {
                    if (!InGather(g1.data[i], g2)) {
                        sum.Add(g1.data[i]);
                    }
                }
            }
            sum.Sort();
            Gather s=new Gather();
            s.Length = sum.Count;
            s.data=new int[s.Length];
            for (int i = 0; i < sum.Count; i++) {
                s.data[i] = sum[i];
            }
            return s;
        }

        //求两个集合的差集,g1有,g2没有
        static Gather DiffGather(Gather g1, Gather g2) {
            List<int>diff=new List<int>();
            for (int i = 0; i < g1.Length; i++) {
                diff.Add(g1.data[i]);
            }
            for (int i = 0; i < g1.Length; i++) {
                if (InGather(g1.data[i],g2)) {
                    diff.Remove(g1.data[i]);
                }
            }
            Gather s=new Gather();
            s.Length = diff.Count;
            s.data=new int[diff.Count];
            for (int i = 0; i < diff.Count; i++) {
                s.data[i] = diff[i];
            }
            return s;
        }
        //求交集
        static Gather IntGather(Gather g1, Gather g2) {
            List<int> intersection = new List<int>();
            if (g1.Length < g2.Length) {
                for (int i = 0; i < g1.Length; i++) {
                    intersection.Add(g1.data[i]);
                }
                for (int i = 0; i < g1.Length; i++) {
                    if (!InGather(g1.data[i],g2)) {
                        intersection.Remove(g1.data[i]);
                    }
                }
            }
            else {
                for (int i = 0; i < g2.Length; i++) {
                    intersection.Add(g2.data[i]);
                }
                for (int i = 0; i < g2.Length; i++) {
                    if (!InGather(g2.data[i], g1)) {
                        intersection.Remove(g2.data[i]);
                    }
                }
            }
            Gather s = new Gather();
            s.Length = intersection.Count;
            s.data = new int[intersection.Count];
            for (int i = 0; i < intersection.Count; i++) {
                s.data[i] = intersection[i];
            }
            return s;
        }

    }
}
