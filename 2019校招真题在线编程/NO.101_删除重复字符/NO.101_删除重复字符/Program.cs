using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._101_删除重复字符 {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            HashSet<char> sets = new HashSet<char>();
            for (int i = 0; i < input.Length; i++)
                sets.Add(input[i]);
            foreach (var VARIABLE in sets)
                Console.Write(VARIABLE);
        }
    }
}
