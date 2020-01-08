using System.Drawing;
using System;
namespace UnityShader_Matrix {
    public class Triangle {
        private PointF A, B, C;
        public Triangle(PointF A, PointF B, PointF C) {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        //绘制一个三角形
        public void Draw(Graphics g) {
            Pen pen = new Pen(Color.Red, 2);
            g.DrawLine(pen, A, B);
            g.DrawLine(pen, B, C);
            g.DrawLine(pen, C, A);
        }
        public void Rotate(int degree) {
            float angle = (float)(degree / 360f * Math.PI);
            A = NewPosition(A, angle);
            B = NewPosition(B, angle);
            C = NewPosition(C, angle);
        }
        //将点按照angle进行旋转
        public PointF NewPosition(PointF p,float angle) {
            float newX = (float)(p.X * Math.Cos(angle)) - (float)(p.Y * Math.Sin(angle));
            float newY = (float)(p.X * Math.Sin(angle)) + (float)(p.Y * Math.Cos(angle));
            p.X = newX;
            p.Y = newY;
            return  p;
        }
    }
}