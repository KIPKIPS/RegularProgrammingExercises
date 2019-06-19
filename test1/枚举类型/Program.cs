using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举类型
{
    enum GameState:int//以int存储
    {
        pause,
        success,
        failed,
        start
    }
    enum Num : byte//以byte存储较好i，可以节约空间
    {
        pause=1,
        success = 10,
        failed = 12,
        start = 17
    }
    class Program
    {
        static void Main(string[] args)
        {
            GameState now = GameState.failed;
            Num number = Num.pause;
            Console.WriteLine(number);
            if (now == GameState.failed)
            {
                Console.WriteLine("游戏失败");
                int num = (int)now;
                Console.WriteLine(now+"的值为"+num);
            }
            
            Console.ReadLine();
        }
    }
}
