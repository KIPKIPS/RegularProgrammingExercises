using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._036_爱吃猫粮的小招喵 {
    class Program {
        static void Main(string[] args) {
            string[] inp = Console.ReadLine().Split(' ');
            int[]nums=new int[inp.Length];
            for (int i = 0; i < nums.Length; i++) {
                nums[i] = Convert.ToInt32(inp[i]);
            }
            int hourLeave = Convert.ToInt32(Console.ReadLine());

            for (int speed =1 ; ; speed++) {
                int hour = 0;
                for (int j = 0; j < nums.Length; j++) {
                    hour += (int) Math.Ceiling((decimal)nums[j] / speed);
                }
                //Console.WriteLine("shijian"+hour+"speed"+speed);
                if (hour<=hourLeave) {
                    Console.WriteLine(speed);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
