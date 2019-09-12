using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._058_会话列表 {
    class Program {
        static void Main(string[] args) {
            List<Dictionary<int,int> >res=new List<Dictionary<int, int>>();
            int testNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < testNum; i++) {
                int sesStr = Convert.ToInt32(Console.ReadLine());
                int []sesNum=new int[sesStr];
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < sesNum.Length; j++) {
                    sesNum[j] = Convert.ToInt32(input[j]);
                }

                Dictionary<int,int>dic=new Dictionary<int, int>();
                for (int j = sesNum.Length-1; j >=0 ; j--) {
                    if (!dic.ContainsKey(sesNum[j])) {
                        dic.Add(sesNum[j],1);
                    }
                }

                res.Add(dic);
            }

            for (int i = 0; i < res.Count; i++) {
                int count = 0;
                foreach (KeyValuePair<int, int> VARIABLE in res[i]) {
                    if (count != res[i].Count - 1) {
                        Console.Write(VARIABLE.Key + " ");
                    }
                    else {
                        Console.Write(VARIABLE.Key);
                    }
                    count++;
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
