using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02 {
    class Program {
        static void Main(string[] args) {
            int num = Convert.ToInt32(Console.ReadLine());
            int five = 0;
            int four = 0;
            int one = 0;
            while (num>0) {
                if (num % 5 == 0) {
                    five += num / 5;
                    num = 0;
                }else if (num%4==0) {
                    four = num / 4;
                    num = 0;
                }
                else {
                    if (num == 8) {
                        four += 2;
                        num = 0;
                    }
                    else {
                        if (num >= 5) {
                            num -= 5;
                            five++;
                        }
                        else if (num >= 4) {
                            num -= 4;
                            four++;
                        }
                        else {
                            one += num;
                            num = 0;
                        }
                    }
                }
                
            }

            Console.WriteLine(one+","+four+","+five);
            Console.ReadLine();
        }
    }
}
