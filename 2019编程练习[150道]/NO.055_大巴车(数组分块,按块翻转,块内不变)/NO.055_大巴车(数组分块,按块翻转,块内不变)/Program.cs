using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._055_大巴车_数组分块_按块翻转_块内不变_ {
    class Program {
        static void Main(string[] args) {
            string[] str = Console.ReadLine().Split(' ');
            int peopleNum = Convert.ToInt32(str[0]);//员工人数
            int carCapacity = Convert.ToInt32(str[1]);//卡车容量
            string[] strIndex = Console.ReadLine().Split(' ');
            int[] peopleIndex = new int[strIndex.Length];//员工到达顺序数组int
            for (int i = 0; i < peopleIndex.Length; i++) {
                peopleIndex[i] = Convert.ToInt32(strIndex[i]);
            }
            List<int[]>group=new List<int[]>();
            for (int i = 0; i < peopleIndex.Length;) {
                if (i + carCapacity-1 <= peopleIndex.Length - 1) {
                    int[] temp = new int[carCapacity];
                    for (int j = i; j < i+ carCapacity; j++) {
                        temp[j-i] = peopleIndex[j];
                    }
                    group.Add(temp);
                    i += carCapacity;
                }
                if (i + carCapacity-1 > peopleIndex.Length - 1&&i<peopleIndex.Length) {
                    int[] temp = new int[peopleIndex.Length-i];
                    for (int j = i; j < peopleIndex.Length; j++) {
                        temp[j-i] = peopleIndex[j];
                    }
                    group.Add(temp);
                    i = peopleIndex.Length - 1;
                }
                if (i==peopleIndex.Length-1) {
                    break;
                }
            }
            group.Reverse();
            foreach (var arr in group) {
                for (int i = 0; i < arr.Length; i++) {
                    Console.Write(arr[i]+" ");
                }
            }
            //Console.WriteLine(group.Count);
            Console.ReadLine();

        }
    }
}
