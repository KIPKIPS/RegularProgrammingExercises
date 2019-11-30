using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._118_访友 {
    class Program {
        static void Main(string[] args) {
            int dis = int.Parse(Console.ReadLine());
            if (dis<=5) 
                Console.WriteLine("1");
            else 
                Console.WriteLine(Math.Ceiling(dis / 5f));
        }
    }
}
