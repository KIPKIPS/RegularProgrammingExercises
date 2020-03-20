using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._067_密码破译 {
    class Program {
        static void Main(string[] args) {
            UnZip("25475276");
            Console.ReadLine();
        }
        static List<string>res=new List<string>();
        public static string UnZip(string str) {
            for (int i = 0; i < str.Length;) {
                
                if (str.Length>=2) {
                    int num = Convert.ToInt32(str[i] + "" + str[i + 1]);
                    if (num<=26) {
                        string temp = (char) (num + 96) + "";
                        string newStr = "";
                        for (int j = i + 2; j < str.Length; j++) {
                            newStr += str[j];
                        }
                        return temp + UnZip(newStr);
                    }
                    string temp1 = (char)(Convert.ToInt32(str[0] + "") + 96) + "";
                        string newStr1 = "";
                        for (int j = i+1; j < str.Length; j++) {
                            newStr1 += str[j];
                        }
                        return temp1 + UnZip(newStr1);
                }

                if (str.Length==1) {
                    string temp = (char)(Convert.ToInt32(str[0] + "") + 96)+"";
                    return temp;
                }

                if (str.Length==0) {
                    return "";
                }
            }
            return "";
        }
    }
}
