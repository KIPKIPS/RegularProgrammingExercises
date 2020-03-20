using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._145_穿点最多的直线 {
    public class Point {
        public int x;
        public int y;
        public Point() {
            x = 0;
            y = 0;
        }
        public Point(int a, int b) {
            x = a;
            y = b;
        }
    }
    class Program {
        static void Main(string[] args) {
        }
        public static double[] getLine(Point[] p, int n) {
            // write code here
            List<Point[]>lineSet=new List<Point[]>();//可以组成的直线的集合
            //遍历所有点,存储所有的直线
            for (int i = 0; i < p.Length-1; i++) {
                for (int j = i+1; j < p.Length; j++) {
                    Point[] line = new Point[2];//两点构成的直线
                    line[0] = p[i];
                    line[1] = p[j];
                    lineSet.Add(line);
                }
            }
            Dictionary<double[], int> dic = new Dictionary<double[], int>();//字典
            for (int i = 0; i < lineSet.Count; i++) {
                double k = (lineSet[i][0].y - lineSet[i][1].y) / (lineSet[i][0].x - lineSet[i][1].x);
                double b = lineSet[i][0].y - k * lineSet[i][0].x;
                double[] kbPairs = new[] {k, b};
                if (dic.ContainsKey(kbPairs)) {
                    dic[kbPairs]++;
                }
                else {
                    dic.Add(kbPairs,1);
                }
            }
            int max = 0;
            double[]res=new double[2];
            foreach (KeyValuePair<double[],int> kvp in dic) {
                if (kvp.Value>max) {
                    max = kvp.Value;
                    res = kvp.Key;
                }
            }
            return res;
        }
    }
}
