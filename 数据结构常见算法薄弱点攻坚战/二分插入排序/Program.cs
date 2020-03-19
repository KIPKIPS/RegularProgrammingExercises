using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二分插入排序 {
    class Program {
        static void Main(string[] args) {
            string[] inp = Console.ReadLine().Split(' ');
            int[] data = new int[inp.Length];
            for (int i = 0; i < data.Length; i++) {
                data[i] = Convert.ToInt32(inp[i]);
            }

            BinaryInsertionSort(data);
            foreach (var VARIABLE in data) {
                Console.Write(VARIABLE + " ");
            }
            Console.ReadLine();
        }

        //二分插入排序
        static void BinaryInsertionSort(int[] data) {
            int i, j;
            int low, high, mid;
            for (i = 1; i <data.Length; i++) {
                int key = data[i];
                low = 0;
                high = i - 1;
                while (low<=high) {
                    mid = (low + high) / 2;
                    if (data[mid]>key) {
                        high = mid - 1;
                    }
                    else {
                        low = mid + 1;
                    }
                }
                for (j = i-1; j >=high+1; j--) {
                    data[j + 1] = data[j];
                }
                data[high + 1] = key;
            }
        }
    }
}
