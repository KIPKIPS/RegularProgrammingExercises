using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._125_数组查值
{
    class Program
    {
        static void Main(string[] args) {
            string info = Console.ReadLine();
            List<int> data=new List<int>();
            for (int i = 0; i < int.Parse(info[0] + ""); i++) {
                string[] temp = Console.ReadLine().Split(' ');
                for (int j = 0; j < temp.Length; j++) 
                    data.Add(int.Parse(temp[j]));
            }
            Console.WriteLine(data.Contains(int.Parse(info.Split(' ')[2] + "")) ?"Yes":"No");
            Console.ReadLine();
        }
    }
}
