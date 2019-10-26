using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._116_回合制游戏 {
    class Program {
        static void Main(string[] args) {
            int hp = int.Parse(Console.ReadLine());
            int normalAttack= int.Parse(Console.ReadLine());
            int bufferAttack= int.Parse(Console.ReadLine());
            if (bufferAttack<normalAttack*2) {
                Console.WriteLine(Math.Ceiling((float)hp / normalAttack));
            }
            else {
                int temp = ((hp - hp % bufferAttack) / bufferAttack) * 2;
                if (hp%bufferAttack ==0) 
                    Console.WriteLine(hp*2/bufferAttack);
                else {
                    if (hp % bufferAttack<= normalAttack) 
                        Console.WriteLine(temp + 1);
                    else 
                        Console.WriteLine(temp + 2);
                }
                
            }
        }
    }
}
