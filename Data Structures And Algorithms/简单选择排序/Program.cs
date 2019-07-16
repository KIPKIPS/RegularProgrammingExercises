using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单选择排序 {
    class Program {
        static void Main(string[] args) {
            int[] arr = { 4,64,64,64,6,4,654,564,65,4,554,53,132,1644,6541,31,32,465, };
            SelectSort(arr);
            foreach (var VARIABLE in arr) {
                Console.Write(VARIABLE+" ");
            }
            Console.ReadLine();
        }

        static void SelectSort(int[] dataArray) {

            for (int i = 0; i < dataArray.Length - 1; i++) {
                int min = dataArray[i];
                int minIndex=i;//最小值索引

                //找出i后面的最小值
                for (int j = i + 1; j < dataArray.Length; j++) {
                    if (dataArray[j] < min) {
                        min = dataArray[j];
                        minIndex = j;
                    }
                }
                //最小值与第i位交换位置
                if (minIndex!=i) {
                    int temp = dataArray[i];
                    dataArray[i] = dataArray[minIndex];
                    dataArray[minIndex] = temp;
                }
            }
        }
    }
}
