using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 可乐瓶
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 364;
            int empty = sum;
            while (empty >= 3)
            {
                sum += empty/3;//三个空瓶子换一个，把空瓶子加到总数上
                int newCount = empty / 3;//新的喝完的空瓶子
                int newEmpty = empty % 3;//新的剩余的空瓶子
                empty = newCount + newEmpty;//空瓶子等于喝完的加上剩余的空瓶子
            }
            Console.WriteLine("喝了：" + sum + "瓶可乐");
            Console.WriteLine("剩余空瓶子个数为" + empty + "个");
            Console.ReadLine();
        }
    }
}
