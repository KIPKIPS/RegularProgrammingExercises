using System;
using System.Collections.Generic;
using System.Drawing;

namespace _3DTransform {
    public class Cube {
        public Vector4 a=new Vector4(-0.5,0.5,0.5,1);
        public Vector4 b =new Vector4(0.5,0.5,0.5,1);
        public Vector4 c =new Vector4(0.5,0.5,-0.5,1);
        public Vector4 d =new Vector4(-0.5,0.5,-0.5,1);

        public Vector4 e =new Vector4(-0.5,-0.5,0.5,1);
        public Vector4 f =new Vector4(0.5,-0.5,0.5,1);
        public Vector4 g =new Vector4(0.5,-0.5,-0.5,1);
        public Vector4 h =new Vector4(-0.5,-0.5,-0.5,1);
        private Triangle3D[] triangles=new Triangle3D[12];//包含的三角形片元

        public float dot;
        private bool cullBack;//是否剔除背面的渲染,控制模型背面的可见性

        public Cube() {
            //top
            triangles[0]=new Triangle3D(a,b,c);
            triangles[1]=new Triangle3D(a,c,d);
            //bottom
            triangles[2]=new Triangle3D(e,h,f);
            triangles[3]=new Triangle3D(f,h,g);
            //front
            triangles[4]=new Triangle3D(d,c,g);
            triangles[5]=new Triangle3D(d,g,h);
            //back
            triangles[6]=new Triangle3D(a,e,b);
            triangles[7]=new Triangle3D(b,e,f);
            //right
            triangles[8] = new Triangle3D(b,f,c);
            triangles[9] = new Triangle3D(c,f,g);
            //left
            triangles[10] = new Triangle3D(a,d,h);
            triangles[11] = new Triangle3D(a,h,e);

        }
        //变换函数
        public void Transform(Matrix4x4 m) {
            foreach (Triangle3D t in triangles) {
                t.Transform(m);
            }
        }

        public void CalculateLighting(Matrix4x4 _Object2World, Vector4 L) {
            foreach (Triangle3D t in triangles) {
                t.CalculateLighting(_Object2World,L);
            }
        }

        public void Draw(Graphics g,bool isLine) {
            g.TranslateTransform(300, 300);
            foreach (Triangle3D t in triangles) {
                t.Draw(g,isLine);
            }
        }
    }
}