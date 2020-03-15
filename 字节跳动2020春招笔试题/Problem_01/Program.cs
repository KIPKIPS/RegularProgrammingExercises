using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01 {
    class Program {
        static void Main(string[] args) {
            int num = Convert.ToInt32(Console.ReadLine());
            Dictionary<string,List<string>> dic=new Dictionary<string, List<string>>();
            List<string[]>userData=new List<string[]>();
            for (int i = 0; i < num; i++) {
                string[] data = Console.ReadLine().Split(' ');
                userData.Add(data);
            }
            for (int i = 0; i < userData.Count; i++) {
                if (dic.ContainsKey(userData[i][1])) {
                    dic[userData[i][1]].Add(userData[i][0]);
                }
                else {
                    List<string>temp=new List<string>();
                    temp.Add(userData[i][0]);
                    dic.Add(userData[i][1],temp);
                }
            }
            foreach (KeyValuePair<string,List<string>> kvp in dic) {
                kvp.Value.Sort();
            }
            foreach (KeyValuePair<string, List<string>> kvp in dic) {
                Console.Write(kvp.Key);
                foreach (string v in kvp.Value) {
                    Console.Write(" "+v);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
