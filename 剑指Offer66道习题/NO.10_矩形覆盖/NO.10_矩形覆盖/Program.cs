using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._10_矩形覆盖 {
    class Program {
        static void Main(string[] args) {
        }
        public int rectCover(int number) {
            // write code here
            if (number == 0) {
                return 0;
            }
            else if (number == 1) {
                return 1;
            }

            else if (number == 2) {
                return 2;
            }
            else {
                return rectCover(number - 1) + rectCover(number - 2);
            }
        }
    }
}
