using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._034_a除以b的小数形式 {
    class Program {
        static void Main(string[] args) {
            string[] str = Console.ReadLine().Split(' ');
            double dividend = Convert.ToInt32(str[0]);//被除数
            double divisor = Convert.ToInt32(str[1]);//除数
            string res = (dividend / divisor).ToString();
            string integer = "";
            string decimals = "";
            for (int i = 0; i < res.Length; i++) {
                if (res[i]=='.') {
                    for (int j = 0; j < i; j++) {
                        integer += res[j] + "";
                    }
                    for (int j = i+1; j < res.Length; j++) {
                        decimals += res[j]+"";
                    }
                }
            }

            if (decimals.Length!=0) {
                for (int i = 0; i < decimals.Length; i++) {

                }
            }
            
            //Console.WriteLine(res);
            Console.ReadLine();

        }
    }
}
