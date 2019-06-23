using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 列表List的创建和使用
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> num= new List<int>(){666,666,666};//正常方式创建列表
            List<string>str=new List<string>(){"adsf","asf","asdfre","wrhtd","d4fh5656","阿尔法"};
            List<char>ch=new List<char>(){'s','a',' ','1'};
            var num1=new List<int>();//匿名形式创建列表
            var num2=new List<int>(){1,2,3,15,16};
            num2.Add(15);
            int q=num2.IndexOf(15);//寻找列表中第一个值为15的数字,并返回它的索引
            Console.WriteLine(q);
            num2.Insert(0,666);

            str.Insert(3,null);//null类型不能插入到int,char等类型的列表,可以插入到string类型的列表中去
            
            Console.WriteLine(num2.IndexOf(664536));

            num2.InsertRange(4,num);//将num插入num2的索引4位置
            Console.WriteLine(num2.Count);
            //num2.Sort();
            foreach (var VARIABLE in num2)
            {
                Console.Write(VARIABLE+" ");
            }

            Console.ReadLine();
        }
    }
}
