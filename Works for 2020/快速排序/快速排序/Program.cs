using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 快速排序 {
    class Program {
        static void Main(string[] args) {
            int[] y = new int[] { 4, 8, 2222, 2, 1, 121, 13, 434, 56, 1111, 65, 7, 8 };
            QuickSort(y,0,y.Length-1);
            foreach (var item in y) {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        private static void QuickSort(int[] numbers, int left, int right) {
            if (left < right) {
                int middle = numbers[(left + right) / 2];
                int i = left - 1;
                int j = right + 1;
                while (true) {
                    while (numbers[++i] < middle) { }
                    while (numbers[--j] > middle) {}
                    if (i >= j) {
                        break;
                    }
                        
                    Swap(numbers, i, j);
                }
                QuickSort(numbers, left, i - 1);
                QuickSort(numbers, j + 1, right);
            }
        }
        private static void Swap(int[] numbers, int i, int j) {
            int number = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = number;
        }
    }
}
