using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 顺序队列 {
    class Program {
        static void Main(string[] args) {
            Queue<int> queue=new Queue<int>();
            for (int i = 4; i <= 32; i++) {
                Console.WriteLine("case "+i+":audio.src = '../music/"+i+".mp3'; //音乐的路径");
                Console.WriteLine("break;");

            }
            Console.ReadLine();
        }
    }
}



