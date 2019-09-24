using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._104_排序 {
    class Program {
        static void Main(string[] args) {
            Console.ReadLine();
            string[] str = Console.ReadLine().Split(' ');
            int[] num=new int[str.Length];
            int[] origin = new int[str.Length];
            for (int i = 0; i < str.Length; i++) {
                num[i] = int.Parse(str[i]);
                origin[i] = num[i];
            }
            int times = 0;
            Array.Sort(num);
            for (int i = 0; i < num.Length; i++) {
                if (origin[i]!=num[i]) {
                    times++;
                }
            }
            Console.WriteLine(times);
            Console.ReadLine();
        }
    }
}
