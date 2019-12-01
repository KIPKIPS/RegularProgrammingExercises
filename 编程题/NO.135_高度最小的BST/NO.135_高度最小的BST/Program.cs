using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._135_高度最小的BST {
    class Program {
        static void Main(string[] args) {
        }
        public static int buildMinimalBST(int[] vals) {
            return (int) (Math.Log(vals.Length + 1) / Math.Log(2)) + 1;
        }
    }
}
