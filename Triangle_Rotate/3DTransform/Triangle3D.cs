using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _3DTransform {
    public class Triangle3D {
        public Vector4 A, B, C;//原始的顶点坐标
        private Vector4 a, b, c;//变换后的顶点坐标
        public Vector4 normal;//三角形片元的法向量
        public float dot;

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
            //g.DrawLines(new Pen(Color.Black,2), Get2DPointFArr());
            //填充三角形片元
            GraphicsPath path =new GraphicsPath();
            path.AddLines(this.Get2DPointFArr());//向路径中添加片元顶点
            int r = (int) (255 * dot);
            Color color = Color.FromArgb(r,r,r,1);
            Brush br=new SolidBrush(color);
            g.FillPath(br,path);//按照路径填充片元
        }
        //获取需要绘制的三角形的顶点列表
        private PointF[] Get2DPointFArr() {
            PointF[] p = new PointF[4];
            p[0] = Get2DPointF(a);
            p[1] = Get2DPointF(b);
            p[2] = Get2DPointF(c);
            p[3] = p[0];
            return p;
        }
        //获取顶点
        private PointF Get2DPointF(Vector4 v) {
            PointF p=new PointF();
            p.X = (float)(v.x / v.w);
            p.Y = -(float)(v.y / v.w);
            return p;
        }
        /// <summary>
        /// 计算三角形片元的光照
        /// </summary>
        /// <param name="_Object2World">模型到世界矩阵</param>
        /// <param name="L">光照向量</param>
        public void CalculateLighting(Matrix4x4 _Object2World,Vector4 L) {
            Transform(_Object2World);
            Vector4 U = this.b - this.a;
            Vector4 V = this.c - this.a;
            Vector4 normal = U.Cross(V);
            dot = normal.Normalized.Dot(L.Normalized);
            dot = Math.Max(0, dot);
        }
        

    }
}