using System;

namespace 冒泡排序 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            int[] array = { 1, 5, 2, 45, 125, 55, 123, 10, 8 };
            BubbleSort(array);
            for(int i = 0;i < array.Length; i++) {
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();
        }
        static void BubbleSort(int[] arr) {
            for (int i = 0; i < arr.Length - 1; i++) {
                for (int j = 0; j < arr.Length - 1 - i; j++) {
                    if (arr[j] > arr[j + 1]) {
                        Swap(arr, j, j + 1);
                    }
                }   
            }
        }
        static void Swap(int[] arr,int i,int j) {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
