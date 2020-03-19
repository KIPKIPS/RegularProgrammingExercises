using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组中的逆序对 {
    class Program {
        static void Main(string[] args) {
            Program x=new Program();
            
                Console.WriteLine(x.InversePairs(new[] { 1, 2, 1,0,1,0,0,0,0,0,0,0,4,7 }));
                Console.ReadLine();
        }
        public int InversePairsA(int[] data) {
            int count = 0;
            // write code here
            for (int i = 1; i < data.Length; i++) {
                for (int j = 0; j < i; j++) {
                    if (data[j] > data[i]) {
                        count++;
                    }
                }
            }

            return count;
        }
        public int InversePairs(int[] data) {
            //二分归并算法     
            //新建辅助数组
            int[] temp = new int[data.Length];
            return (int)(DoubleSearch(data, temp, 0, data.Length - 1) % 1000000007);
        }
        public long DoubleSearch(int[] data, int[] temp, int start, int end) {
            if (start >= end) {
                return 0;
            }
            //取数组中值，将数组分两半
            int mid = (start + end) / 2;
            //用于记录逆序对数量(由于数值过大，所以使用long型)
            long count = 0;
            //递归对左右子数组进行二分
            long left = DoubleSearch(data, temp, start, mid);
            long right = DoubleSearch(data, temp, mid + 1, end);
            //利用辅助数组合并以排序的子数组并统计逆序对数目
            int i = mid, j = end, k = end;
            while (i >= start && j >= (mid + 1)) {
                //若排好序的左子数组最左边的数大于排好序的右子数组最右边的数的，
                //则说明逆序对添加为右子数组的元素个数,同时将左子数组最大值赋值到辅助数组中，然后变量指示位置前移
                if (data[i] > data[j]) {
                    count += j - mid;
                    temp[k--] = data[i--];
                }
                //说明左子数组中没有大于右子数组中的逆序对，则直接将右子数组最大值加入到辅助数组中
                else {
                    temp[k--] = data[j--];
                }

            }
            //若只剩下左子数组，则将其元素添加到辅助数组中
            while (i >= start) {
                temp[k--] = data[i--];
            }
            //若只剩下右子数组，则将其元素直接添加到辅助数组中
            while (j >= mid + 1) {
                temp[k--] = data[j--];
            }
            //将有序辅助数组中赋值到data中
            for (int l = start; l <= end; l++) {
                data[l] = temp[l];
            }
            return left + right + count;
        }
    }
}
