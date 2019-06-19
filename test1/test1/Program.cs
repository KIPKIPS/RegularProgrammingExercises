using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class 练习2
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            string handle = Console.ReadLine();
            switch (handle)
            {
                case "0": Console.WriteLine(num1+num2);
                    break;
                case "1":
                    Console.WriteLine(num1 - num2);
                    break;
                case "2":
                    Console.WriteLine(num1 * num2);
                    break;

            }
            Console.ReadLine();
        }
    }
}
