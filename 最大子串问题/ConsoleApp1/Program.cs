using System;
using System.Collections.Generic;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            string tar = Console.ReadLine();//读取控制台输入
            char[] tarCharArray = tar.ToCharArray();//将字符串转化成字符数组
            Array.Sort(tarCharArray);//字符数组排序
            Array.Reverse(tarCharArray);//逆置
            string sortStr = "";
            string result = "";//存储最大子串
            HashSet<char> dic=new HashSet<char>();//字符串的hash表
            foreach (char VARIABLE in tarCharArray) {
                if (!dic.Contains(VARIABLE)) {
                    dic.Add(VARIABLE);
                    sortStr += VARIABLE;
                }
            }
            //Console.WriteLine("降序字典"+d);
            for (int i = 0; i < tar.Length; i++) {
                for (int j = 0; j < sortStr.Length; j++) {
                    if (j > 0) {
                        if (tar[i] == sortStr[j] && i > IndexOfLastChar(sortStr[j - 1], tar)) {
                            result += tar[i];
                        }
                    }
                    else {
                        if (tar[i] == sortStr[j]) {
                            result += tar[i];
                        }
                    }
                    
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
        //最后一个字符在串中的位置
        static int IndexOfLastChar(char tar, string s) {
            for (int i = s.Length-1; i >=0; i--) {
                if (s[i]==tar) {
                    return i;
                }
            }
            return -1;
        }
    }
}
