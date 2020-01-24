using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._007_确定两串乱序同构 {
    class Program {
        static void Main(string[] args) {
            string[] s = Console.ReadLine().Split(',');
            Console.WriteLine(checkSam(s[0], s[1]));
            Console.ReadLine();
        }
        //第二种方法(目前时间复杂度较低)
        public static bool fun(string stringA, string stringB) {
            if (stringA.Length != stringB.Length) {
                return false;
            }
            char[] A = stringA.ToCharArray();
            char[] B = stringB.ToCharArray();
            Array.Sort(A);
            Array.Sort(B);
            for (int i = 0; i < A.Length; i++) {
                if (A[i]!=B[i]) {
                    return false;
                }
            }
            return true;
        }
        //第一种方法(弃用的)
        public static bool checkSam(string stringA, string stringB) {
            // write code here
            if (stringA.Length != stringB.Length) {
                return false;
            }

            List<char>charA=new List<char>();
            List<char> charB = new List<char>();
            for (int i = 0; i < stringA.Length; i++) {
                if (stringA[i] != ' ') {
                    charA.Add(stringA[i]);
                }
                if (stringB[i] != ' ') {
                    charB.Add(stringB[i]);
                }
            }
            for (int i = 0; i < charA.Count; i++) {
                for (int j = 0; j < charB.Count; j++) {
                    if (charA[i] == charB[j]) {
                        charA[i] = ' ';
                        charB[j] = ' ';
                    }
                }
            }
            for (int i = 0; i < charA.Count; i++) {
                if (charA[i]!=' '||charB[i]!=' ') {
                    return false;
                }
            }
            return true;
        }
    }
}
