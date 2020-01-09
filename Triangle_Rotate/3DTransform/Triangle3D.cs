using System.Drawing;

namespace _3DTransform {
    public class Triangle3D {
        public Vector4 A, B, C;//原始的顶点坐标
        private Vector4 a, b, c;//变换后的顶点坐标

        public Triangle3D() {

        }

        public Triangle3D(Vector4 a, Vector4 b, Vector4 c) {
            //this.A = a; this.B = b; this.C = c;//引用赋值,a,b,c的值更改后会导致Triangle3D的A,B,C值改变
            //解决方法
            this.A = new Vector4(a);
            this.B = new Vector4(b);
            this.C = new Vector4(c);
        }
        //三角形利用矩阵的乘法进行变换
        public void Transform(Matrix4x4 m) {
            a= m.Mul(this.A);
            b = m.Mul(this.B);
            c = m.Mul(this.C);
        }
        //绘制三角形
        public void Draw(Graphics g) {
            Pen pen=new Pen(Color.Brown);
            g.DrawLines(pen,Get2DPointFArr());
        }
        private PointF[] Get2DPointFArr() {
            PointF[] p = new PointF[4];
            p[0] = Get2DPointF(A);
            p[1] = Get2DPointF(B);
            p[2] = Get2DPointF(C);
            p[3] = Get2DPointF(A);
            return p;
        }
        private PointF Get2DPointF(Vector4 v) {
            PointF p=new PointF();
            p.X = (float)(v.x / v.w);
            p.Y = (float)(v.y / v.w);
            return p;
        }
    }
}