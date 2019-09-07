using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._051_有序矩阵中第K小的元素 {
    class Program {
        static void Main(string[] args) {
            string[] str = Console.ReadLine().Split(' ');
            int index = Convert.ToInt32(str[0]);
            int n = Convert.ToInt32(str[1]);
            int[,]sqrt=new int[n,n];
            for (int i = 0; i < n; i++) {
                string[] temp = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    sqrt[i, j] = Convert.ToInt32(temp[j]);
                }
            }
            int[]sort=new int[n*n];
            int count = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    sort[count] = sqrt[i, j];
                    count++;
                }
            }
            Array.Sort(sort);
            Console.WriteLine(sort[index-1]);
            Console.ReadLine();
        }
    }
}
