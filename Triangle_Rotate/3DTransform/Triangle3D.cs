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
            this.A =this.a= new Vector4(a);
            this.B = this.b = new Vector4(b);
            this.C = this.c = new Vector4(c);
        }
        //三角形利用矩阵的乘法进行变换
        public void Transform(Matrix4x4 m) {
            a= m.Mul(this.A);
            b = m.Mul(this.B);
            c = m.Mul(this.C);
        }
        //绘制三角形
        public void Draw(Graphics g) {
            g.TranslateTransform(300,300);
            g.DrawLines(new Pen(Color.Brown,2), Get2DPointFArr());
        }
        private PointF[] Get2DPointFArr() {
            PointF[] p = new PointF[4];
            p[0] = Get2DPointF(a);
            p[1] = Get2DPointF(b);
            p[2] = Get2DPointF(c);
            p[3] = p[0];
            return p;
        }
        private PointF Get2DPointF(Vector4 v) {
            PointF p=new PointF();
            p.X = (float)(v.x / v.w);
            p.Y = (float)-(v.y / v.w);
            return p;
        }
    }
}