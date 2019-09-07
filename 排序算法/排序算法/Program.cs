using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序算法 {
    class Program {
        static void Main(string[] args) {

            foreach (var VARIABLE in Shell_Sort(new[] { 3, 7, 5, 4, 2, 1, 0, 6, 8, 9 })) {
                Console.Write(VARIABLE + " ");
            }
            Console.ReadLine();
        }

        //冒泡排序是排序算法中较为简单的一种,英文称为Bubble Sor。它遍历所有的数据,每次对相邻元素进行两两比较
        //如果顺序和预先规定的顺序不一致,则进行位置交换;这样一次遍历会将最大或最小的数据上浮到顶端,之后再重复
        //同样的操作,直到所有的数据有序。
        public static int[] Bubble_Sort(int[] data) {
            for (int i = 0; i < data.Length - 1; i++) {
                for (int j = i + 1; j < data.Length; j++) {
                    if (data[i] > data[j]) {
                        int temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
            return data;
        }

        //选择排序简单直观,英文称为Selection Sort,先在数据中找出最大或最小的元素,放到序列的起始;然后再从余下的
        //数据中继续寻找最大或最小的元素,依次放到排序序列中,直到所有数据样本排序完成。
        public static int[] Selection_Sort(int[] data) {
            for (int i = 0; i < data.Length; i++) {
                int min = data[i];
                for (int j = i + 1; j < data.Length; j++) {
                    if (data[j] < min) {
                        min = data[j];
                        data[j] = data[i];
                        data[i] = min;
                    }
                }
            }
            return data;
        }
        //插入排序英文称为Insertion Sort,它通过构建有序序列,对于未排序的数据序列,在已排序序列中从后向前扫描,找
        //到相应的位置并插入,类似打扑克牌时的码牌。插入排序有一种优化的算法,可以进行拆半插入。

        //基本思路是先将待排序序列的第一个元素看做一个有序序列,把第二个元素到最后一个元素当成是未排序序列;然
        //后从头到尾依次扫描未排序序列,将扫描到的每个元素插入有序序列的适当位置,直到所有数据都完成排序;如果待
        //插入的元素与有序序列中的某个元素相等,则将待插入元素插入到相等元素的后面。
        public static int[] Insertion_Sort(int[] data) {
            for (int i = 1; i < data.Length; i++) {
                if (data[i - 1] > data[i]) {
                    int temp = data[i];
                    int j = i;
                    while (j > 0 && data[j - 1] > temp) {
                        data[j] = data[j - 1];
                        j--;
                    }
                    data[j] = temp;
                }
            }
            return data;
        }
        //希尔排序在插入排序的基础上进行了改进,它的基本思路是先将整个数据序列分割成若干子序列分别进行直接插入
        //排序,待整个序列中的记录基本有序时,再对全部数据进行依次直接插入排序。
        public static int[] Shell_Sort(int[] data) {
            //增量gap，并逐步缩小增量
            for (int gap = data.Length / 2; gap > 0; gap /= 2) {
                //从第gap个元素，逐个对其所在组进行直接插入排序操作
                for (int i = gap; i < data.Length; i++) {
                    int j = i;
                    while (j - gap >= 0 && data[j] < data[j - gap]) {
                        //插入排序采用交换法
                        swap(data, j, j - gap);
                        j -= gap;
                    }
                }
            }
            return data;
        }
        //希尔排序的交换法函数
        public static void swap(int[] arr, int a, int b) {
            arr[a] = arr[a] + arr[b];
            arr[b] = arr[a] - arr[b];
            arr[a] = arr[a] - arr[b];
        }


        //归并排序英文称为Merge Sort,归并排序是建立在归并操作上的一种有效的排序算法。该算法是采用分治法(Divide and Conquer)的
        //一个非常典型的应用。它首先将数据样本拆分为两个子数据样本,并分别对它们排序,最后再将两个子数据样本合并在一起; 拆分后的两
        //个子数据样本序列,再继续递归的拆分为更小的子数据样本序列,再分别进行排序,直到最后数据序列为1而不再拆分,此时即完成对数据样
        //本的最终排序。
    }
}
