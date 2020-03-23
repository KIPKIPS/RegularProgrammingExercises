using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 最长子序列 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(GLS("ad","bc"));
            Console.ReadLine();
        }

        static int GLS(string a, string b) {
            int[,]data=new int[a.Length,b.Length];
            int max = 0;
            for (int i = 0; i < a.Length; i++) {
                for (int j = 0; j < b.Length; j++) {
                    if (a[i]==b[j]) {
                        if (i==0||j==0) {
                            data[i, j] = 1;
                        }
                        else {
                            data[i, j] = data[i - 1, j - 1] + 1;
                            if (data[i,j]>=max) {
                                max = data[i, j];
                            }
                        }
                    }
                    else {
                        data[i, j] = 0;
                    }
                }
            }
            return max;
        }
    }
}
