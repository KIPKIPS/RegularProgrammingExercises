using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._144_平分的直线 {
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
            Point a=new Point();
        }
        public double[] getBipartition(Point[] A, Point[] B) {
            // write code here
            double centerAx= 0;
            double centerAy = 0;
            double centerBx = 0;
            double centerBy = 0;
            //获取A的中心点坐标
            for (int i = 0; i < A.Length; i++) {
                for (int j = 0; j < A.Length; j++) {
                    if (A[i].x==A[j].x&&A[i].y!=A[j].y) {
                        centerAy = (A[i].y + A[j].y) / 2;
                    }
                    if (A[i].x != A[j].x && A[i].y == A[j].y) {
                        centerAx = (A[i].x + A[j].x) / 2;
                    }
                }
            }
            //获取B的中心点坐标
            for (int i = 0; i < B.Length; i++) {
                for (int j = 0; j < B.Length; j++) {
                    if (B[i].x == B[j].x && B[i].y != B[j].y) {
                        centerBy = (B[i].y + B[j].y) / 2;
                    }
                    if (B[i].x != B[j].x && B[i].y == B[j].y) {
                        centerBx = (B[i].x + B[j].x) / 2;
                    }
                }
            }

            return new[]
            {
                (centerAy - centerBy) / (centerAx - centerBx),
                centerAy - (centerAy - centerBy) / (centerAx - centerBx) * centerAx
            };
        }
    }
}
