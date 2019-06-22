using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 四舍五入
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字: ");
            double num = Convert.ToDouble(Console.ReadLine());
            int temp = (int)(num * 10%10);
            //Console.WriteLine(temp);
            if (temp <= 4)
            {
                num = (int) num;
            }
            else
            {
                num = (int)num+1;
            }
            Console.WriteLine("四舍五入后的值为: "+num);
            Console.ReadLine();
        }
            
    }
}
