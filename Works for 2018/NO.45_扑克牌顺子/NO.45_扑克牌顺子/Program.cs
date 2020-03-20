using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._45_扑克牌顺子 {
    class Program {
        static void Main(string[] args) {
            Program x=new Program();
            
                Console.WriteLine(x.IsContinuous(new[] {0,2, 3, 4, 6 }));
                Console.ReadLine();
        }
        public bool IsContinuous(int[] numbers) {
            if (numbers.Length==0) {
                return false;
            }
            Dictionary<int, int> poke = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++) {
                if (poke.ContainsKey(numbers[i])&&numbers[i]!=0) {
                    return false;
                }
                else {
                    if (numbers[i]!=0) {
                        poke.Add(numbers[i], 1);
                    }
                }
            }
            if (numbers[0] != 0 && numbers[1] != 0 && numbers[2] != 0 && numbers[3] != 0 && numbers[4] != 0) {
                if (numbers.Max() - numbers.Min() >= 5) {
                    return false;
                }
                return true;
            }
            else {
                List<int> temp = new List<int>();
                for (int i = 0; i < numbers.Length; i++) {
                    if (numbers[i] != 0) {
                        temp.Add(numbers[i]);
                    }
                }

                if (temp.Max() - temp.Min() >= 5) {
                    return false;
                }
                return true;
            }


        }
    }
}
