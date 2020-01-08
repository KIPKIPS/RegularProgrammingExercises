using System.Drawing;
using System;
namespace UnityShader_Matrix {
    public class Triangle {
        public PointF A, B, C;
        public Triangle(PointF A, PointF B, PointF C) {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        //绘制一个三角形
        public void Draw(Graphics g) {
            Pen pen = new Pen(Color.Red, 1);
            g.DrawLine(pen, A, B);
            g.DrawLine(pen, B, C);
            g.DrawLine(pen, C, A);
        }
        public void Rotate(int degree) {
            float angle = (float)(degree / 360f * Math.PI);
            A = RotatePosition(A, angle);
            B = RotatePosition(B, angle);
            C = RotatePosition(C, angle);
        }
        //将点按照angle进行旋转
        //原理:坐标矩阵×| cos(a)   sin(a)  | ,计算矩阵为旋转之后的坐标
        //                        | -sin(a)  cos(a) |
        public PointF RotatePosition(PointF p,float angle) {
            float newX = (float)(p.X * Math.Cos(angle)) - (float)(p.Y * Math.Sin(angle));
            float newY = (float)(p.X * Math.Sin(angle)) + (float)(p.Y * Math.Cos(angle));
            p.X = newX;
            p.Y = newY;
            return  p;
        }
        //TODO按照缩放比例进行缩放
        public void Scale(float scale) {
            A = ScalePosition(A,scale);
            B = ScalePosition(B, scale);
            C = ScalePosition(C, scale);
        }
        //计算缩放点的坐标函数,scale为每次缩放的比例
        public PointF ScalePosition(PointF p, float scale) {
            float newX = scale * p.X ;
            float newY = scale * p.Y;
            p.X = newX;
            p.Y = newY;
            return p;
        }
    }
}