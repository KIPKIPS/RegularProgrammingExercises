using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 华为笔试题二 {
    class Program {
        static void Main(string[] args) {
            List<int[]> data=new List<int[]>();
            while (true) {
                string temp= Console.ReadLine();
                if (temp=="") {
                    break;
                }
                else {
                    string[] tempArr = temp.Split(' ');
                    int[] tempIntArr=new int[tempArr.Length];
                    for (int i = 0; i < tempArr.Length; i++) {
                        tempIntArr[i] = Convert.ToInt32(tempArr[i])>=10?1:0;
                    }
                    data.Add(tempIntArr);
                }
            }
            List<string>res=new List<string>();
            for (int i = 0; i < data.Count; i++) {
                bool getJG = false;
                bool get = false;
                //01 间隔出现
                for (int j = 0; j < data[i].Length-1; j++) {
                    if (Math.Abs(data[i][j + 1] - data[i][j]) != 1) {
                        break;
                    }
                    else {
                        if (j==data[i].Length-2) {
                            res.Add("true");
                            getJG = true;
                            break;
                        }
                    }
                }
                if (getJG) {
                    continue;
                }
                
                //首尾0中1
                if (data[i][0]==0&&data[i][data[i].Length-1]==0) {
                    for (int j = 1; j < data[i].Length-1; j++) {
                        if (data[i][j]!=1) {
                            res.Add("false");
                            break;
                        }
                        else {
                            if (j== data[i].Length - 2) {
                                res.Add("true");
                                get = true;
                            }
                        }
                    }
                }
                if (get) {
                    continue;
                }
                //首尾1中0
                if (data[i][0] == 1 && data[i][data[i].Length - 1] == 1) {
                    for (int j = 1; j < data[i].Length - 1; j++) {
                        if (data[i][j] != 0) {
                            res.Add("false");
                            break;
                        }
                        else {
                            if (j == data[i].Length - 2) {
                                res.Add("true");
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < res.Count; i++) {
                if (i==res.Count-1) {
                    Console.Write(res[i]);
                }
                else {
                    Console.Write(res[i] + " ");
                }
                
            }
            Console.ReadLine();
        }
    }
}
