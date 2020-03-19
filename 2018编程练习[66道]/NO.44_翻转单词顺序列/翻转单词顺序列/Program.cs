using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 翻转单词顺序列 {
    class Program {
        static void Main(string[] args) {
            Program x=new Program();
            Console.WriteLine(x.ReverseSentence("student. a am I"));
            Console.ReadLine();
        }
        public string ReverseSentence(string str) {
            // write code here
            string[] temp = str.Split(' ');
            string res = "";
            for (int i = temp.Length-1; i >=0; i--) {
                if (i==0) {
                    res += temp[i];
                }
                else {
                    res += temp[i] + " ";
                }
                
            }
            return res;
        }
    }
}
