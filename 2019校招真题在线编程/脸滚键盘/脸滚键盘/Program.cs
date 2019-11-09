using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Timeout
namespace 脸滚键盘 {
    class Program {
        static void Main(string[] args) {
            List<string> res = new List<string>();
            List<string> input = new List<string>();
            while (true) {
                string temp = Console.ReadLine();
                if (temp != "")
                    input.Add(temp);
                else
                    break;
            }
            for (int i = 0; i < input.Count; i++) {
                string temp = input[i].Substring(2);//temp0存储k值,temp1存储数据
                //Console.WriteLine(temp);
                Dictionary<char, int> dic = new Dictionary<char, int>();
                for (int j = 0; j < temp.Length; j++) {
                    if (dic.ContainsKey(temp[j])) {
                        dic[temp[j]]++;
                    }
                    else {
                        dic.Add(temp[j], 1);
                    }
                }
                int count = 0;
                int num = 0;
                foreach (KeyValuePair<char, int> kvp in dic) {
                    num++;
                    if (kvp.Value == 1) {
                        count++;
                    }
                    if (count == int.Parse(input[i][0]+"")) {
                        res.Add("[" + kvp.Key + "]");
                        break;
                    }
                    if (count < int.Parse(input[i][0] + "") && num == dic.Count) {
                        res.Add("Myon~");
                        break;
                    }
                }
            }

            foreach (var temp in res) {
                Console.WriteLine(temp);
            }
            Console.ReadLine();
        }
    }
}
