using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._044_排队唱歌 {
    class Program {
        static void Main(string[] args) {
            int n= Convert.ToInt32(Console.ReadLine());
            int[]height=new int[n];
            for (int i = 0; i <n ; i++) {
                height[i] = Convert.ToInt32(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < height.Length-1; i++) {
                for (int j = i+1; j < height.Length; j++) {
                    if (height[i]>height[j]) {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
