using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DTransform {
    public partial class Form1 : Form {
        private Triangle3D t;
        private Matrix4x4 m_scale;
        private Matrix4x4 m_rotate;
        private int degree;
        public Form1() {
            InitializeComponent();
            m_scale=new Matrix4x4();
            m_scale[1, 1] = 200;
            m_scale[2, 2] = 200;
            m_scale[3,3] = 200;
            m_scale[4,4] = 1;

            m_rotate=new Matrix4x4();
            ;
        }

        private void Form1_Load(object sender, EventArgs e) {
            Vector4 a=new Vector4(0,-0.5,0,1);
            Vector4 b = new Vector4(0.5, 0.5, 0, 1);
            Vector4 c = new Vector4(-0.5, 0.5, 0, 1);
            t =new Triangle3D(a,b,c);

        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            t.Draw(e.Graphics);
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            degree += 2;
            double angle = degree / 360.0 * Math.PI;
            //绕Y轴旋转矩阵
            //m_rotate[1, 1] = Math.Cos(angle);
            //m_rotate[1, 3] = Math.Sin(angle);
            //m_rotate[2, 2] = 1;
            //m_rotate[3, 1] = -Math.Sin(angle);
            //m_rotate[3, 3] = Math.Cos(angle);
            //m_rotate[4, 4] = 1;

            //绕X轴旋转矩阵
            //m_rotate[1, 1] = 1;
            //m_rotate[2,2] = Math.Cos(angle);
            //m_rotate[2,3] = Math.Sin(angle);
            //m_rotate[3,2] = -Math.Sin(angle);
            //m_rotate[3,3] = Math.Cos(angle);
            //m_rotate[4,4] = 1;

            //绕Z轴旋转矩阵
            m_rotate[1, 1] = Math.Cos(angle);
            m_rotate[1,2] = Math.Sin(angle);
            m_rotate[2,1] = -Math.Sin(angle);
            m_rotate[2,2] = Math.Cos(angle);
            m_rotate[3,3] = 1;
            m_rotate[4,4] = 1;

            Matrix4x4 m = m_scale.Mul(m_rotate);
            t.Transform(m);//传入缩放+旋转矩阵
            this.Invalidate();
        }
    }
}
