using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _3DTransform {
    public class Triangle3D {
        public Vector4 A, B, C;//原始的顶点坐标
        private Vector4 a, b, c;//变换后的顶点坐标
        public Vector4 normal;//三角形片元的法向量
        public float dot;
        private bool cullBack;//是否剔除背面的渲染,控制模型背面的可见性

        public Triangle3D() {

        }

        public Triangle3D(Vector4 a, Vector4 b, Vector4 c) {
            //this.A = a; this.B = b; this.C = c;//引用赋值,a,b,c的值更改后会导致Triangle3D的A,B,C值改变
            //解决方法
            this.A =this.a= new Vector4(a);
            this.B = this.b = new Vector4(b);
            this.C = this.c = new Vector4(c);
        }
        //三角形片元变换操作
        public void Transform(Matrix4x4 m) {
            a= m.Mul(this.A);
            b = m.Mul(this.B);
            c = m.Mul(this.C);
        }
        //绘制三角形
        public void Draw(Graphics g) {
            g.TranslateTransform(300,300);
            g.DrawLines(new Pen(Color.White,2), Get2DPointFArr());//对线框进行渲染,便于观察相机观察到片元背面的场景

            //如果是背面,就不选择剔除渲染的模型
            if (!cullBack) {
                //填充三角形片元
                GraphicsPath path = new GraphicsPath();
                path.AddLines(this.Get2DPointFArr());//向路径中添加片元顶点
                int r = (int)(200 * dot) + 55;
                Color color = Color.FromArgb(r, r, r);
                Brush br = new SolidBrush(color);
                g.FillPath(br, path);//按照路径填充片元
            }
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
            dot = Math.Max(0, dot);//将dot值限定在0,1之间

            Vector4 E=new Vector4(0,0,-1,0);//Z轴的反向量
            cullBack = normal.Normalized.Dot(E) < 0 ? true : false;

        }
    }
}