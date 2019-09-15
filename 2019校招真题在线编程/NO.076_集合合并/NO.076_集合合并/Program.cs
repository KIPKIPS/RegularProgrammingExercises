using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._076_集合合并 {
    class Program {
        static void Main(string[] args) {
            int num = Convert.ToInt32(Console.ReadLine());
           Dictionary<int,int>[] input=new Dictionary<int, int>[num];//存取list的数组
            for (int i = 0; i < num; i++) {
                string[] inp = Console.ReadLine().Split(' ');
                input[i]=new Dictionary<int, int>();
                for (int j = 0; j < inp.Length; j++) {
                    input[i].Add(Convert.ToInt32(inp[j]),1);
                }
            }

            for (int i = 0; i < input.Length-1; i++) {
                int j = i+1;
                for (; j < input.Length;) {
                    if (input[j] != null) {

                    }
                    else {
                        j++;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
