using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工资不找零
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的工资：");
            string money = Console.ReadLine();
            int num = Convert.ToInt32(money);
            int hunder, fifty, ten, five, two, one;
            hunder = num / 100;
            fifty= (num % 100)/50;
            ten= ((num % 100) %50)/10;
            five= (((num % 100) % 50) % 10)/5;
            two = ((((num % 100) % 50) % 10) % 5) / 2;
            one= ((((num % 100) % 50) % 10) % 5) % 2;
            Console.WriteLine("需要支付{0}张100元，{1}张50元，{2}张10元，{3}张5元，{4}张2元，{5}张1元",hunder,fifty,ten,five,two,one);
            Console.ReadLine();
        }
    }
}
