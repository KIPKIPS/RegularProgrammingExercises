using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._18_搭积木 {
    class Program {
        public struct Brick {
            public int Length;
            public int Width;
        }
        static void Main(string[] args) {
            List<Brick>bricks=new List<Brick>();
            int brickCount=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < brickCount; i++) {
                string temp=Console.ReadLine();
                Brick brick=new Brick();
                brick.Length = Convert.ToInt32(temp.Split(' ')[0]);
                brick.Width = Convert.ToInt32(temp.Split(' ')[1]);
                bricks.Add(brick);
            }

            //积木堆按照长度排序
            for (int i = 0; i < bricks.Count-1; i++) {
                for (int j = i+1; j < bricks.Count; j++) {
                    if (bricks[i].Length<bricks[j].Length) {
                        Brick temp = bricks[i];
                        bricks[i] = bricks[j];
                        bricks[j] = temp;
                    }
                }
            }
            //将宽度单独存取出来
            int[]width=new int[bricks.Count];
            for (int i = 0; i < bricks.Count; i++) {
                width[i] = bricks[i].Width;
            }

            

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
