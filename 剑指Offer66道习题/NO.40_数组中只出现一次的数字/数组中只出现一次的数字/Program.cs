using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组中只出现一次的数字 {
    class Program {
        //num1,num2分别为长度为1的数组。传出参数
        //将num1[0],num2[0]设置为返回结果
        //一个整型数组里除了两个数字之外，其他的数字都出现了两次。请写程序找出这两个只出现一次的数字。
        static void Main(string[] args) {
        }
        public void FindNumsAppearOnce(int[] array, int[] num1, int[] num2) {
            // write code here
            Dictionary<int, int> find = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++) {
                if (find.ContainsKey(array[i]))
                    find[array[i]]++;
                else
                    find.Add(array[i], 1);

            }
            int[] numTemp = new int[2];
            int index = 0;
            foreach (KeyValuePair<int, int> temp in find) {
                if (temp.Value == 1) {
                    numTemp[index] = temp.Key;
                    index++;
                }
            }
            num1[0] = numTemp[0];
            num2[0] = numTemp[1];
        }
    }
}
