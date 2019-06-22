using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构体函数
{
    struct Name{
        public string FirstName;
        public string LastName;

        public string GetName()
        {
            return FirstName + LastName;
        }
}
    struct Vector3
    {
        public double X;
        public double Y;
        public double Z;

        public double Distance()
        {
            double distance=Math.Sqrt(X * X + Y * Y + Z * Z);
            return distance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Name myName;
            myName.FirstName = "王";
            myName.LastName = "琨鹏";
            Console.WriteLine(myName.GetName());

            Vector3 v;
            Console.WriteLine("请输入向量的x值");
            v.X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入向量的y值");
            v.Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入向量的z值");
            v.Z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(v.Distance());
            Console.ReadLine();

        }
    }
}
