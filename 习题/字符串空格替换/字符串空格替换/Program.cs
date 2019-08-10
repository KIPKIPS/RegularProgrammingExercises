using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//请实现一个函数，将一个字符串中的每个空格替换成“%20”。例如，当字符串为We Are Happy.则经过替换之后的字符串为We%20Are%20Happy。
namespace 字符串空格替换 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(replaceSpace(" we are happy"));
            Console.ReadLine();
        }
        public static string replaceSpace(string str) {
            string[] div=str.Split(' ');
            string sum="";
            for (int i = 0; i < div.Length; i++) {
                if (i==div.Length-1) {
                    sum += div[i];
                }
                else {
                    sum += div[i] + "%20";
                }
                
            }

            return sum;
        }
    }
}
