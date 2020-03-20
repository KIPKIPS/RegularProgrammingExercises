using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 华为笔试题 {
    class Program {
        static void Main(string[] args) {
            int num = Convert.ToInt32(Console.ReadLine());
            int[] data=new int[num];
            
            for (int i = 0; i < data.Length; i++) {
                data[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine(Fun(data));
            Console.ReadLine();
        }

        static int Fun(int[]data) {
            if (data.Length<=1) {
                return data.Length;
            }
            int res = 1;
            int front = 0;
            int step = data[0];
            for (int i = 0; i < data.Length; i++) {
                int max = data[front + 1];
                int tempStep = 0;
                int tempFront = 0;
                for (int j = front + 1; j <= front + step; j++) {
                    if (front + step>data.Length-1) {
                        return res + 1;
                    }
                    else {
                        if (data[j] >= max) {
                            max = data[j];
                            tempFront = j;
                            tempStep = max;
                        }
                    }
                    
                }
                front = tempFront;
                step = tempStep;
                if (front + step >= data.Length - 1) {
                    return res+1;
                }
                else {
                    res++;
                }
            }
            return res;
        }
    }
}
