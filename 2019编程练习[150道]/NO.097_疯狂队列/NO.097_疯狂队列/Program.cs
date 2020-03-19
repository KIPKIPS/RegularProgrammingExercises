using System;
using System.Collections.Generic;
using System.Linq;
namespace NO_097_疯狂队列_ {
    class Program {

        static void Main(string[] args) {
            string s = Console.ReadLine();
            s = Console.ReadLine();

            //string s = "1 2 3 4 5 6";
            string[] numStringArray = s.Split(' ');
            int[] numArray = new int[numStringArray.Length];
            for (int i = 0; i < numStringArray.Length; i++) {
                numArray[i] = int.Parse(numStringArray[i]);
            }

            List<int> oriNumList = new List<int>(numArray);
            List<int> newNumList = new List<int>();


            int max, min;

            while (true) {
                //
                if (oriNumList.Count >= 2) {
                    max = oriNumList.Max();
                    min = oriNumList.Min();

                    oriNumList.Remove(max);
                    oriNumList.Remove(min);

                    newNumList.Add(max);//后面
                    newNumList.Insert(0, min);//前面
                }
                else { break; }

                //
                if (oriNumList.Count >= 2) {
                    min = oriNumList.Max();
                    max = oriNumList.Min();

                    oriNumList.Remove(max);
                    oriNumList.Remove(min);

                    newNumList.Add(max);//后面
                    newNumList.Insert(0, min);//前面
                }
                else { break; }
            }
            if (oriNumList.Count == 1) {
                int t = oriNumList[0];
                if (Math.Abs(t - newNumList[0]) < Math.Abs(t - newNumList[newNumList.Count - 1])) {
                    newNumList.Add(t);//后面
                }
                else {
                    newNumList.Insert(0, t);//前面
                }
            }
            int sum = 0;
            for (int i = 0; i < newNumList.Count - 1; i++) {
                sum += Math.Abs(newNumList[i] - newNumList[i + 1]);
            }
            Console.WriteLine(sum);

            //Console.ReadLine();
        }

    }
}