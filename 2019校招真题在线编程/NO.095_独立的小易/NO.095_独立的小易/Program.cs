using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._095_独立的小易 {
    class Program {
        static void Main(string[] args) {
            string s = Console.ReadLine();
            string[] input = s.Split(' ');
            int houseRent = Convert.ToInt32(input[0]);
            int fruitsNum = Convert.ToInt32(input[1]);
            int money = Convert.ToInt32(input[2]);
            int fruitPrice = Convert.ToInt32(input[3]);
            if (money - fruitsNum * houseRent > 0) 
                Console.WriteLine((money - fruitsNum * houseRent) / (fruitPrice + houseRent) + fruitsNum);
            else 
                Console.WriteLine(money / houseRent);
            Console.ReadLine();
        }
    }
}
