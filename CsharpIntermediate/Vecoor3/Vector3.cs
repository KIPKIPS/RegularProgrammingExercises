using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecoor3
{
    class Vector3
    {
        public float x;
        public float y;
        public float z;

        public float Length()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
    }
}
