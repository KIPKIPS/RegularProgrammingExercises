using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._009_基本字符串压缩 {
    class Program {
        static void Main(string[] args) {
        }
        public static string zipString(string iniString) {
            // write code here
            string zipStr = "";
            char tempChar = iniString[0];
            int tempIndex = 0;
            for (int i = 0; i < iniString.Length; i++) {
                if (iniString[i]!=tempChar) {
                    zipStr += tempChar+"" + (i - tempIndex);
                    tempChar = iniString[i];
                    tempIndex = i;
                }
            }
            zipStr += iniString[iniString.Length - 1]+"" + (iniString.Length - tempIndex);
            return zipStr.Length<iniString.Length?zipStr:iniString;
        }
    }
}
