using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._054_查找第K大的元素 {
    class Program {
        static void Main(string[] args) {
            string[] str = Console.ReadLine().Replace("[", "").Replace("]", "").Split(','); 
            int[]num=new int[str.Length];
            for (int i = 0; i < num.Length; i++) {
                num[i] = Convert.ToInt32(str[i]);
            }
            Array.Sort(num);
            Console.WriteLine(num[num.Length-3]);
        }
    }
}
