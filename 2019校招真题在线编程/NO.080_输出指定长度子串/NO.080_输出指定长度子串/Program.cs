using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._080_输出指定长度子串 {
    class Program {
        static void Main(string[] args) {
            string obj = Console.ReadLine();
            int num = Convert.ToInt32(Console.ReadLine());
            if (num>obj.Length||obj.Length==0||num<0) {
                Console.WriteLine("-1");
            }
            else {
                for (int i = 0; i <= obj.Length - num; i++) {
                    string temp = "";
                    for (int j = i; j < i + num; j++) {
                        temp += obj[j];
                    }
                    if (i == obj.Length - num)
                        Console.Write(temp);
                    else
                        Console.Write(temp + " ");
                }
            }
            
            Console.ReadLine();
        }
    }
}
