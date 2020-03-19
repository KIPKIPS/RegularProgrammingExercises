using System;
using System.Collections.Generic;
using System.Linq;

namespace NO._024_合并数组 {
    class Program {
        static void Main(string[] args) {
            string inp = Console.ReadLine();
            string inp2 = Console.ReadLine();

            List<int> num = new List<int>();
            List<int> num2 = new List<int>();

            if (inp.Length!=0) {
                string[] temp = inp.Split(',');
                for (int i = 0; i < temp.Length; i++) {
                    num.Add(Convert.ToInt32(temp[i]));
                }
            }
            if (inp2.Length != 0) {
                string[] temp2 = inp2.Split(',');
                for (int i = 0; i < temp2.Length; i++) {
                    num2.Add(Convert.ToInt32(temp2[i]));
                }
            }
            List<int>res=new List<int>();
            while (num.Count != 0 || num2.Count != 0) {
                if (num.Count!=0 && num2.Count != 0) {
                    if (num.Min()<=num2.Min()) {
                        res.Add(num.Min());
                        num.Remove(num.Min());
                    }
                    else {
                        res.Add(num2.Min());
                        num2.Remove(num2.Min());
                    }
                }

                if (num.Count!=0||num2.Count!=0) {
                    if (num.Count == 0 && num2.Count != 0) {
                        res.Add(num2.Min());
                        num2.Remove(num2.Min());
                    }
                    if (num2.Count == 0 && num.Count != 0) {
                        res.Add(num.Min());
                        num.Remove(num.Min());
                    }
                }
                    
                
            }

            if (res.Count!=0) {
                for (int i = 0; i < res.Count; i++) {
                    if (i < res.Count - 1) {
                        Console.Write(res[i] + ",");
                    }
                    else {
                        Console.Write(res[i]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
