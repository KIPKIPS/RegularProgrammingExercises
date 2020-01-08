using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnityShader_Matrix {
    public partial class Form1 : Form {
        private Triangle t;
        public Form1() {
            InitializeComponent();
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e) {
            e.Graphics.TranslateTransform(300,300);
            t.Draw(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e) {
            PointF A = new PointF(0, -200);
            PointF B = new PointF(200, 200);
            PointF C = new PointF(-200, 200);
            
            t = new Triangle(A, B, C);
            
        }
        static int s = 1;
        private void Timer1_Trick(object sender, EventArgs e) {
            t.Rotate(10);
            t.Scale(0.95f);
            Invalidate();
        }
    }
}
