namespace _3DTransform {
    public class Vector4 {
        public double x, y, z, w;

        public Vector4() {

        }
        //有参构造函数
        public Vector4(double x,double y,double z,double w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        //Copy其他向量的值
        public Vector4(Vector4 v) {
            x = v.x;
            y=v.y;
            z = v.z;
            w = v.w;
        }
    }
}