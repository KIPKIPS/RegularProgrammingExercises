using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace NO._63_滑动窗口的最大值 {
    class Program {
        static void Main(string[] args) {
            Program x = new Program();
            x.maxInWindows(new int[] { 2, 3, 4, 2, 5, 6, 2, 6, 1 }, 3);
            Console.ReadLine();
        }
        public int[] maxInWindows(int[] num, int size) {
            // write code here
            List<int[]> windows = new List<int[]>();
            
            if (size==0) {
                return new int[0];
            }
            int front = 0;//窗口的起始标记
            int rear = size - 1;//窗口的尾标记
            
            while (rear != num.Length) {
                int[] temp = new int[size];
                for (int j = front; j <= rear; j++) {
                    temp[j - front] = num[j];
                }
                windows.Add(temp);
                front++;
                rear++;
            }
            //测试
            //foreach (var VARIABLE in windows) {
            //    foreach (var a in VARIABLE) {
            //        Console.Write(a + " ");
            //    }
            //    Console.WriteLine();
            //}
            int[] maxInWindows = new int[windows.Count];
            for (int i = 0; i < windows.Count; i++) {
                maxInWindows[i] = windows[i].Max();
            }
            return maxInWindows;
        }
    }
}
