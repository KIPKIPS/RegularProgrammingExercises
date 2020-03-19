using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二分法 {
    class Program {
        static void Main(string[] args) {
            string[] inp = Console.ReadLine().Split(' ');
            int[] data=new int[inp.Length];
            for (int i = 0; i < data.Length; i++) {
                data[i] = Convert.ToInt32(inp[i]);
            }

            Console.WriteLine(Bisection(data,5));
            Console.ReadLine();
        }
        //二分查找
        static int Bisection(int[] data,int key) {
            int low = 0;
            int mid = -1;
            int high = data.Length - 1;
            while (low<=high) {
                mid = (low + high) / 2;
                if (data[mid]==key) {
                    return mid;
                }
                else if (data[mid]>key) {
                    high = mid - 1;
                }
                else {
                    low = mid + 1;
                }
            }
            return mid;
        }
    }
}
