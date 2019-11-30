using System;
using System.Collections.Generic;

namespace NO._056_时钟 {
    class Program {
        static void Main(string[] args) {
            int num = Convert.ToInt32(Console.ReadLine());
            List<string[]> target = new List<string[]>();
            for (int i = 0; i < num; i++) {
                string[] str = Console.ReadLine().Split(':');
                target.Add(str);
            }

            for (int i = 0; i < target.Count; i++) {
                int hour = Convert.ToInt32(target[i][0]);
                int minute = Convert.ToInt32(target[i][1]);
                int second = Convert.ToInt32(target[i][2]);
                if (hour > 23)
                    target[i][0] = "0" + hour % 10;
                if (minute > 59)
                    target[i][1] = "0" + minute % 10;
                if (second > 59)
                    target[i][2] = "0" + second % 10;
                Console.WriteLine(target[i][0] + ":" + target[i][1] + ":" + target[i][2]);
            }
            Console.ReadLine();
        }
    }
}
