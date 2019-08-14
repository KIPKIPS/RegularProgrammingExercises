using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 奇偶数整理位置 {
    class Program {
        static void Main(string[] args) {
            int[] arr = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            reOrderArray(arr);
            foreach (var VARIABLE in arr) {
                Console.Write(VARIABLE+" ");
            }
            Console.ReadLine();
        }
        public static int[] reOrderArray(int[] array) {
            List<int> odd=new List<int>();//奇数List
            List<int> even=new List<int>();//偶数List
            for (int i = 0; i < array.Length; i++) { //判断奇偶数,分别向奇偶List添加元素
                if (array[i]%2==0) {
                    even.Add(array[i]);
                }
                else {
                    odd.Add(array[i]);
                }
            }
            for (int i = 0; i < even.Count; i++) {
                odd.Add(even[i]);
            }

            for (int i = 0; i < odd.Count; i++) {
                array[i] = odd[i];
            }
            return array;
        }
    }
}
