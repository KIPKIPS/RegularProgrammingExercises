using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._084_二分法 {
    /// <summary>
    /// 二分法查找数组中的元素,第一行为数组元素,以空格间隔,第二行为查找的key值
    /// </summary>
    class Program {
        static void Main(string[] args) { 
            string[] input = Console.ReadLine().Split(' ');
            int[] num=new int[input.Length];
            for (int i = 0; i < num.Length; i++) {
                num[i] = Convert.ToInt32(input[i]);
            }

            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("数组的第"+(BinarySearch(num,0,num.Length,key)+1)+"位是查找的元素");
            Console.ReadLine();
        }
        public static int BinarySearch(int[] num, int start, int end, int key) {
            int ret = -1;// 未搜索到数据返回-1下标
            int mid;
            while (start <= end) {
                mid = start + (end - start) / 2; //直接平均可能会溢位，所以用此算法
                if (num[mid] < key)
                    start = mid + 1;
                else if (num[mid] > key)
                    end = mid - 1;
                else {// 最后检测相等是因为多数搜索状况不是大于要不就小于
                    ret = mid;  
                    break;
                }
            }
            return ret;// 单一出口
        }
    }
}
