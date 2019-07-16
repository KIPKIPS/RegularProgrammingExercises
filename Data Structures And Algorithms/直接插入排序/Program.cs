using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 直接插入排序 {
    class Program {
        static void Main(string[] args) {
            int[] arr ={111, 21, 13, 4};
            InsertSort(arr);
            foreach (var VARIABLE in arr) {
                Console.Write(VARIABLE+" ");
            }
            Console.ReadLine();
        }

        static void InsertSort(int[] dataArray) {
            for (int i = 1; i < dataArray.Length; i++) {
                //记录dataArray[i]的值
                int iValue=dataArray[i];
                bool isInsert = false;
                //拿到i位置的元素,与前面的元素比较,如果前面的元素大于i,就将前面的元素后移
                for (int j = i-1; j >=0; j--) {
                    if (dataArray[j] > iValue) {
                        dataArray[j + 1] = dataArray[j];
                    }
                    else {
                        //发现比i小的值
                        dataArray[j+1] = iValue;
                        isInsert = true;
                        break;
                    }
                }
                if (isInsert == false) {
                    dataArray[0] = iValue;
                }

            }
        }
    }
}
