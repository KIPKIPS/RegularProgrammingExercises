using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构体
{
    class Program
    {
        //声明向量的结构体类型
        struct Vector3
        {
            public float x;
            public float y;
            public float z;
        }
        //声明方向的枚举类型
        enum Direction
        {
            West,
            East,
            South,
            North
        }
        //声明路径的结构体类型
        struct Path
        {
            public float distance;
            public Direction dir;
        }
        static void Main(string[] args)
        {
            //结构体使程序变得清晰，可读性提高
            Vector3 position;
            position.x = 64.5f;

            //结构体和枚举类型的混合使用
            Path path1;
            path1.dir = Direction.East;
            path1.distance = 1000;
        }
    }
}
