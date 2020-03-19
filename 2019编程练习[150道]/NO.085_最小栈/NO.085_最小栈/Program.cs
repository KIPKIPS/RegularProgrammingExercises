using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._085_最小栈 {
    class Program {
        static void Main(string[] args) {
            int times = Convert.ToInt32(Console.ReadLine());
            Queue<int> res = new Queue<int>();
            List<int> stack = new List<int>();
            for (int i = 0; i < times; i++) {
                string temp = Console.ReadLine();
                if (temp.Length == 1) {
                    if (temp == "0")
                        res.Enqueue(stack.Min());
                    else {
                        res.Enqueue(stack[stack.Count - 1]);
                        stack.RemoveAt(stack.Count - 1);
                    }
                }
                else
                    stack.Add(Convert.ToInt32(temp.Split(' ')[1] + ""));
            }
            while (res.Count != 0) {
                Console.WriteLine(res.Dequeue());
            }
            Console.ReadLine();
        }
    }
}
