using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 直接插入排序 {
    class Program {
        static void Main(string[] args) {
            string[] inp = Console.ReadLine().Split(' ');
            int[] data = new int[inp.Length];
            for (int i = 0; i < data.Length; i++) {
                data[i] = Convert.ToInt32(inp[i]);
            }

            StraightInsertionSort(data);
            foreach (var VARIABLE in data) {
                Console.Write(VARIABLE+" ");
            }

            Console.ReadLine();
        }

        //直接插入排序
        //基本思路是先将待排序序列的第一个元素看做一个有序序列,把第二个元素到最后一个元素当成是未排序序列
        //然后从头到尾依次扫描未排序序列,将扫描到的每个元素插入有序序列的适当位置,直到所有数据都完成排序,
        //如果待插入的元素与有序序列中的某个元素相等,则将待插入元素插入到相等元素的后面
        static void StraightInsertionSort(int[] data) {
            for (int i = 1; i < data.Length; i++) {
                int key = data[i];
                int j;
                for (j = i-1; j >=0; j--) {
                    if (key < data[j]) {
                        data[j + 1] = data[j];
                    }
                    else {
                        break;
                    }
                }
                data[j + 1] = key;
            }
        }
    }
}
