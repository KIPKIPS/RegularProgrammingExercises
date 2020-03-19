using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._041_漂流船问题 {
    class Program {
        static void Main(string[] args) {
            string[] inp = Console.ReadLine().Split(' ');
            int[] weight = new int[inp.Length];
            for (int i = 0; i < weight.Length; i++) {
                weight[i] = Convert.ToInt32(inp[i]);
            }

            int count = 0;
            int limit = Convert.ToInt32(Console.ReadLine());//船只最大承载重量
            for (int i = 0; i < weight.Length; i++) {
                for (int j = 0; j < weight.Length; j++) {
                    if (limit - weight[i] >= weight[j] && weight[j] != -1 && weight[i] != -1&&i!=j) {
                        //Console.WriteLine(weight[i]+" "+weight[j]);
                        weight[i] = -1;
                        weight[j] = -1;
                        count++;
                    }
                    else {
                        continue;
                    }
                }
                if (weight[i] != -1) {
                    weight[i] = -1;
                    count++;
                }
            }

//            foreach (var VARIABLE in weight) {
//                Console.Write(VARIABLE+" ");
//            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
