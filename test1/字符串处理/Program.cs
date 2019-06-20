using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串处理
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "kjahfasjklasjiljfisdygguIGuygUYGwyugIHIUHIUHFAHSK";
            Console.WriteLine(str.ToUpper());//转换成大写
            Console.WriteLine(str.ToLower());//转换成小写

            string str1 = "       laksdjask        ";
            Console.WriteLine(str1.Trim());//移除头部和尾部的所有空格
            Console.WriteLine(str1.TrimEnd());//移除尾部空格
            Console.WriteLine(str1.TrimStart());//移除头部空格

            //Split函数使用
            string str2 = "asdf.a.sdf.asf.as.fd.asf.as.f.df.f.se.g.th.f.g.sd.wt.ywt.h.fghd.df.hd.gs.shg.rth.fg";
            string[] str3=str2.Split('.');
            foreach(string temp in str3)
            {
                Console.Write(temp+" ");
            }
            Console.ReadLine();
        }
    }
}
