using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 把数组排成最小的数 {
    class Program {
        static void Main(string[] args) {
            Program x=new Program();
            int[] array = new int[] { 3334, 3, 3333332 };
            x.PrintMinNumber(array);

            Console.WriteLine();
            Console.ReadLine();
        }
        public string PrintMinNumber(int[] numbers) {
            //0.合法性校验
            if (numbers == null || numbers.Length == 0) {
                return "";
            }
            //1.复制一个新数组：修改时在临时数组中修改
            int[] temp = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++) {
                temp[i] = numbers[i];
            }
            Array.Sort(temp);
            //2.将新数组升序排列
            int itemp;
            for (int i = 0; i < temp.Length; i++) {
                for (int j = i; j < temp.Length; j++) {
                    itemp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = itemp;
                }
            }
            List<string> coll=new List<string>();
            string a = "";
            foreach (var UPPER in temp) {
                a += UPPER.ToString();
            }
            coll.Add(a);
            //3.依次寻找并打印全排序
            //PrintArray(temp);
            while (!isDesc(temp)) {
                FindNextArray(temp);
                string b= "";
                foreach (var UPPER in temp) {
                    b += UPPER.ToString();
                }
                coll.Add(b);
            }
            double[] c=new double[coll.Count];
            for (int i = 0; i < coll.Count; i++) {
                c[i] = double.Parse(coll[i]);
            }
            foreach (var VARIABLE in coll) {
                Console.WriteLine(VARIABLE);
            }
            return  c.Min().ToString();

            
        }
        public void PrintArray(int[] array) {
            for (int i = 0; i < array.Length; i++) {
                Console.Write(array[i].ToString() +" ");
            }
            Console.WriteLine();
        }
        /// 判断一个数组内元素是否降序排列
        public bool isDesc(int[] array) {
            int temp = array[0];
            for (int i = 1; i < array.Length; i++) {
                if (array[i] > array[i - 1]) {
                    return false;
                }
            }
            return true;
        }
        /// 找到下一组排列
        public void FindNextArray(int[] array) {
            //1.找出数组的最大值
            int max = array[0];
            for (int i = 1; i < array.Length; i++) {
                if (max < array[i]) {
                    max = array[i];
                }
            }
            //2.从后向前找：找到第一组后数大于前数，以后数位置为signer
            int signer = array.Length - 1;
            for (int i = array.Length - 1; i > 0; i--) {
                if (array[i] > array[i - 1]) {
                    signer = i;
                    break;
                }
            }
            //3.从signer向后找：找到大于且最接近于array[signer-1]的数array[t]
            int t = signer;
            for (int i = signer; i < array.Length; i++) {
                if (array[i] > array[signer - 1] && array[i] < max) {
                    t = i;
                    max = array[t];
                }
            }
            //4.将找到的array[t]和array[signer-1]互换
            int temp = array[t];
            array[t] = array[signer - 1];
            array[signer - 1] = temp;
            //5.为signer之后的元素升序排序
            for (int i = signer; i < array.Length; i++) {
                for (int j = i + 1; j < array.Length; j++) {
                    if (array[i] > array[j]) {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
