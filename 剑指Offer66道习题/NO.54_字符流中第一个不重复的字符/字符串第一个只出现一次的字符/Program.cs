using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace 字符串第一个只出现一次的字符 {
    class Program {
         static void Main(string[] args) {
             Program a=new Program();
             a.Insert('a');
             a.Insert('a');
             a.Insert('d');
             a.Insert('c');
             Console.WriteLine(a.FirstAppearingOnce());
             Console.ReadLine();
        }


         Dictionary<char, int> dir = new Dictionary<char, int>();
        private  StringBuilder data = new StringBuilder();
        public  char FirstAppearingOnce() {
            // write code here
            string str = data.ToString();
            for (int i = 0; i < str.Length; i++) {
                if (dir[str[i]] == 1)
                    return str[i];
            }
            return '#';
        }

        public  void Insert(char c) {
            // write code here
            data.Append(c);
            if (dir.ContainsKey(c))
                dir[c]++;
            else
                dir[c] = 1;
        }
    }
}
