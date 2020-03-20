using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._075_找异数 {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine(Trans("16#FFFFF"));
            List<string> input = new List<string>();
            while (true) {
                string inp = Console.ReadLine();
                if (inp == "END") {
                    break;
                }
                else
                    input.Add(inp);
            }
            Dictionary<string, long> dic = new Dictionary<string, long>();
            for (int i = 0; i < input.Count; i++) {
                if (dic.ContainsKey(input[i])) {
                    dic[input[i]]++;
                }
                else {
                    dic.Add(input[i], Trans(input[i]));
                }
                
            }
            Dictionary<long, long> dic2 = new Dictionary<long, long>();
            foreach (KeyValuePair<string, long> VARIABLE in dic) {
                if (dic2.ContainsKey(VARIABLE.Value))
                    dic2[VARIABLE.Value]++;
                else dic2.Add(VARIABLE.Value, 1);
            }

            int count = 0;
            foreach (KeyValuePair<long, long> VARIABLE in dic2) {
                if (VARIABLE.Value==1) {
                    foreach (KeyValuePair<string, long> temp in dic) {
                        if (temp.Value==VARIABLE.Key) {
                            Console.WriteLine(temp.Key);
                        }
                    }
                }
                else {
                    if (count==dic2.Count-1) {
                        Console.WriteLine("None");
                    }
                }
                count++;
            }
            Console.ReadLine();
        }

        public static int Trans(string str) {
            int num;
            int sum = 0;
            //十进制以内
            if (int.TryParse(str.Split('#')[1],out num)) {
                int R = Convert.ToInt32(str.Split('#')[0]);
                if (R == 10)
                    return num;
                for (int i = 0; i < num.ToString().Length; i++) {
                    int temp = 1;
                    for (int j = 0; j < num.ToString().Length - i - 1; j++)
                        temp *= R;
                    temp *= Convert.ToInt32(num.ToString()[i] + "");
                    sum += temp;
                }
            }
            else {
                int R = Convert.ToInt32(str.Split('#')[0]);
                string numNot= str.Split('#')[1];
                for (int i = 0; i < numNot.Length; i++) {
                    int temp = 1;
                    for (int j = 0; j < numNot.Length - i - 1; j++)
                        temp *= R;
                    int n;
                    if (numNot[i]>='A'&& numNot[i]<='F') {
                        n = (int)numNot[i] - 55;
                        //Console.WriteLine(n);
                    }
                    else {
                        n = Convert.ToInt32(numNot[i] + "");
                    }
                    temp *= n;
                    sum += temp;
                }
            }
            return sum;
        }
    }
}
