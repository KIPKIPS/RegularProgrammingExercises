namespace _3DTransform {
    public class Triangle3D {
        public Vector4 A, B, C;

        public Triangle3D() {

        }

        public Triangle3D(Vector4 a, Vector4 b, Vector4 c) {
            //this.A = a; this.B = b; this.C = c;//引用赋值,a,b,c的值更改后会导致Triangle3D的A,B,C值改变
            //解决方法
            this.A = new Vector4(a);
            this.B = new Vector4(b);
            this.C = new Vector4(c);
        }
    }
}