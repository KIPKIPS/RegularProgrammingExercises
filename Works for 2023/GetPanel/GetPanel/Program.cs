using System;
using System.Numerics;

namespace GetPanel {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(getNormal(new Vector3(-1.7f,9.7f,9.55f),new Vector3(1.35f,12.55f,8.95f),new Vector3(1.75f,9.7f,9.55f)));
            Console.ReadKey();
        }
        static string getNormal(Vector3 p1, Vector3 p2, Vector3 p3) {
            float a = ((p2.Y - p1.Y) * (p3.Z - p1.Z) - (p2.Z - p1.Z) * (p3.Y - p1.Y));
            float b = ((p2.Z - p1.Z) * (p3.X - p1.X) - (p2.X - p1.X) * (p3.Z - p1.Z));
            float c = ((p2.X - p1.X) * (p3.Y - p1.Y) - (p2.Y - p1.Y) * (p3.X - p1.X));
            float d = (0 - (a * p1.X + b * p1.Y + c * p1.Z));
            return $"{a}x + {b}y + {c}z + {d} = 0";
        }
    }
}