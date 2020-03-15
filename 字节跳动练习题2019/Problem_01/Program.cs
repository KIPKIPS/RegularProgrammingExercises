using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01 {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> res = new List<string>();
            for (int i = 0; i < n; i++) {
                string t = Console.ReadLine();
                List<char> temp = t.ToList();
                for (int j = 0; j <= temp.Count;) {
                    //AAA格式
                    if (j + 3 <= temp.Count && temp[j] == temp[j + 1] && temp[j] == temp[j + 2]) {
                        temp.RemoveAt(j);
                    }
                    if (j + 2 <= temp.Count && j - 1 >= 0 && temp[j - 1] == temp[j] && temp[j] == temp[j + 1]) {
                        temp.RemoveAt(j-1);
                    }
                    if (j + 1 <= temp.Count && j - 2 >= 0 && temp[j - 2] == temp[j - 1] && temp[j - 1] == temp[j]) {
                        temp.RemoveAt(j -2);
                    }
                    //AABB格式
                    if (j + 4 <= temp.Count && temp[j] == temp[j + 1] && temp[j + 2] == temp[j + 3]) {
                        temp.RemoveAt(j + 2);
                    }

                    if (j + 3 <= temp.Count && j - 1 >= 0 && temp[j - 1] == temp[j] && temp[j + 1] == temp[j + 2]) {
                        temp.RemoveAt(j + 1);
                    }

                    if (j + 2 <= temp.Count && j - 2 >= 0 && temp[j - 2] == temp[j - 1] && temp[j] == temp[j + 1]) {
                        temp.RemoveAt(j);
                    }

                    if (j + 1 <= temp.Count && j - 3 >= 0 && temp[j - 3] == temp[j - 2] && temp[j - 1] == temp[j]) {
                        temp.RemoveAt(j);
                    }

                    //AABBCC格式
                    if (j + 6 <= temp.Count && temp[j] == temp[j + 1] && temp[j + 2] == temp[j + 3] && temp[j + 4] == temp[j + 5]) {
                        temp.RemoveAt(j + 2);
                    }
                    if (j + 5 <= temp.Count && j - 1 >= 0 && temp[j - 1] == temp[j] && temp[j + 1] == temp[j + 2] && temp[j + 3] == temp[j + 4]) {
                        temp.RemoveAt(j + 1);
                    }
                    if (j + 4 <= temp.Count && j - 2 >= 0 && temp[j - 2] == temp[j - 1] && temp[j] == temp[j + 1] && temp[j + 2] == temp[j + 3]) {
                        temp.RemoveAt(j);
                    }
                    if (j + 3 <= temp.Count && j - 3 >= 0 && temp[j - 3] == temp[j - 2] && temp[j - 1] == temp[j] && temp[j + 1] == temp[j + 2]) {
                        temp.RemoveAt(j);
                    }
                    if (j + 2 <= temp.Count && j - 4 >= 0 && temp[j - 4] == temp[j - 3] && temp[j - 2] == temp[j - 1] && temp[j] == temp[j + 1]) {
                        temp.RemoveAt(j - 1);
                    }
                    if (j + 1 <= temp.Count && j - 5 >= 0 && temp[j - 5] == temp[j - 4] && temp[j - 3] == temp[j - 2] && temp[j - 1] == temp[j]) {
                        temp.RemoveAt(j - 2);
                    }
                    j++;
                }

                string tem = "";
                foreach (var c in temp)
                    tem += c;
                res.Add(tem);
                //Console.WriteLine(tem);
            }

            int index = 0;
            foreach (var r in res) {
                Console.WriteLine(r);
                index++;
            }
            Console.ReadLine();
        }
    }
}
