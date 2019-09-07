using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._043_重叠的装饰 {
    class Program {
        static void Main(string[] args) {
            int num = Convert.ToInt32(Console.ReadLine());
            Dictionary<int,int[]>dic=new Dictionary<int, int[]>();
            for (int i = 1; i <= num; i++) {
                string[] inp = Console.ReadLine().Split(' ');
                int[] display = {Convert.ToInt32(inp[0]), Convert.ToInt32(inp[1])};
                dic.Add(i,display);
            }

            for (int i = 0; i < dic.Count-1; i++) {
                for (int j = i+1; j < dic.Count; j++) {
                    
                }
            }
        }

        public static int[] Cover(int[] under,int[]over) {

        }
    }
}
