using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 正则表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "Hello KipKips";
            //string s1 = Regex.Replace(s, "^", "Hi");
            //Console.WriteLine(s1);

            //Console.WriteLine("请输入密码(纯数字)");
            //string password = Console.ReadLine(); 
            //普通方法
            //bool isMatch = true;
            //for (int i = 0; i < password.Length; i++)
            //{
            //    if (password[i] < '0' || password[i] > '9')
            //    {
            //        isMatch = false;
            //        break;
            //        ;
            //    }
            //}

            //if (isMatch == true)
            //{
            //    Console.WriteLine("合法密码");
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("不合法密码");
            //    Console.WriteLine();
            //}

            //纯数字的正则表达式
            //string pattern = @"^\d*$";
            //bool res = Regex.IsMatch(password, pattern);

            //if (res == true)
            //{
            //    Console.WriteLine("合法密码");
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("不合法密码");
            //    Console.WriteLine();
            //}

            //string str2 = @"^\w*$";
            //bool res2 = Regex.IsMatch("dasAAA__555", str2);//正则表达式/w匹配任何数字、下划线、大小写字符,/W正好为/w的补集
            //Console.WriteLine(res2);

            //string str3 = "aasdfo";
            //string res = @"[^a]";//除了a都匹配
            //string s = Regex.Replace(str3, res, "*");//把除了a的字符都替换成*
            //Console.WriteLine(s);

            //简单的侮辱性词汇过滤
            //string target = "我草你妈,你个傻逼";
            //string res = "草";
            //string res1 = "妈";
            //string res2 = "傻逼";
            //string s = Regex.Replace(target, res, "*");//把匹配res的字符都替换成*
            //string s1 = Regex.Replace(s, res1, "*");//把匹配res1的字符都替换成*
            //string s2 = Regex.Replace(s1, res2, "**");//把匹配res2的字符都替换成*
            //Console.WriteLine(s2);

            //匹配数字或者大写字母
            //string s = "ks##af%@#n#%^ja#$65jksj6534654#IHIUHJBNB阿克苏DNF扩散吃撒";
            //string pattern = @"\d|[A-Z]";
            //MatchCollection res = Regex.Matches(s, pattern);
            //foreach (var VARIABLE in res)
            //{
            //    Console.Write(VARIABLE+" ");
            //}

            //校验IPV4地址 0-255.0-255.0-255.0-255
            string pattern = @"^(((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?))$";
            string s = "552.56.52.255";
            Console.WriteLine(Regex.IsMatch(s,pattern));



            Console.ReadLine();
        }
    }
}
