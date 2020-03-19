using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 包含min函数的栈 {
    class Program {
        static void Main(string[] args) {
            Program x = new Program();
            x.push(1);
            x.push(-100);
            x.push(2);
            x.push(0);
            x.push(4);
            x.push(-1);
            Console.WriteLine(x.min());
            
            Console.Read();
        }
        List<int> data = new List<int>();
        public void push(int node) {
            data.Add(node);
        }
        public void pop() {
            if (data.Count>0) {
                data.RemoveAt(data.Count - 1);
            }
            
        }
        public int top() {
            if (data.Count>0) {
                return data[data.Count - 1];
            }
            return -1;
        }
        public int min() {
            //if (data.Count!=0) {
            //    int min = data[data.Count - 1];
            //    pop();
            //    while (data.Count != 0) {
            //        if (top() < min) {
            //            min = top();
            //            pop();
            //        }
            //        else {
            //            pop();
            //        }
            //    }
            //    return min;
            //}
            //return -1;
            return data.Min();
        }
    }
}
