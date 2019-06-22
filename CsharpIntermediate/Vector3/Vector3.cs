using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector3
{
    class Vector3
    {
        private float x;
        private float y;
        private float z;

        public float Length()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }

        public float SetX(float x)
        {
            this.x = x;
            return this.x;
        }

        public float SetY(float y)
        {
            this.y = y;
            return this.y;
        }

        public float SetZ(float z)
        {
            this.z = z;
            return this.z;
        }
    }
}
