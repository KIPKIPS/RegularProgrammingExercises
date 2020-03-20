using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._140_二进制小数 {
    class Program {
        static void Main(string[] args) {
        }
        public string printBin(double num) {
            // write code here
            string res = "";
            while (num != 0) {
                num *= 2;
                if (num >= 1) {
                    num -= 1;
                    res += "1";
                }
                else
                    res += "0";
                if (num == 0)
                    break;
                if (res.Length > 30) {
                    return "Error";
                }
            }
            return "0."+res;
        }
    }
}
