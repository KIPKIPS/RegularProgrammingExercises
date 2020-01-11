namespace _3DTransform {
    public class Matrix4x4 {
        private double[,] pts;

        public Matrix4x4() {
            pts = new double[4, 4];
        }
        //索引器
        public double this[int i, int j] {
            get { return pts[i - 1, j - 1]; }
            set { pts[i - 1, j - 1] = value; }
        }
        //矩阵相乘,矩阵自身×矩阵m
        public Matrix4x4 Mul(Matrix4x4 m) {
            Matrix4x4 newM = new Matrix4x4();
            //矩阵相乘函数
            for (int w = 1; w <= 4; w++) {
                for (int h = 1; h <= 4; h++) {
                    for (int n = 1; n <= 4; n++) {
                        newM[w, h] += this[w, n] * m[n, h];
                    }
                }
            }
            return newM;
        }
        //向量×矩阵
        public Vector4 Mul(Vector4 v) {
            Vector4 newV = new Vector4();
            newV.x = v.x * this[1, 1] + v.y * this[2,1] + v.z * this[3,1] + v.w * this[4,1];
            newV.y = v.x * this[1,2] + v.y * this[2,2] + v.z * this[3,2] + v.w * this[4,2];
            newV.z = v.x * this[1, 3] + v.y * this[2, 3] + v.z * this[3, 3] + v.w * this[4, 3];
            newV.w = v.x * this[1, 4] + v.y * this[2, 4] + v.z * this[3, 4] + v.w * this[4, 4];
            return newV;
        }
        //求转置矩阵
        public Matrix4x4 Transpose(Matrix4x4 m) {
            Matrix4x4 m_transpose=m;
            for (int row = 1; row <=4; row++) {
                for (int col = 1; col <=4; col++) {
                    if (row<col) {
                        double  temp = m_transpose[row, col];
                        m_transpose[row, col] = m_transpose[col, row];
                        m_transpose[col, row] = temp;
                    }
                }
            }
            return m_transpose;
        }
    }
}