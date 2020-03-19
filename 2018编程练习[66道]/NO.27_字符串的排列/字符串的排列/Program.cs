using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串的排列 {
    class Program {
        static void Main(string[] args) {
            Program x=new Program();
            char[] b = new[] {'c', 'b', 'a', 'd', 'f', 'e'};
            foreach (var VARIABLE in x.Permutation("cbad")) {
                Console.WriteLine(VARIABLE+" ");
            }
            Console.ReadLine();
        }
        public List<string> Permutation(string str) {
            // write code here
            List<string> coll = new List<string>();
            char[] st = new char[str.Length];
            for (int i = 0; i < str.Length; i++) {
                st[i] = str[i];
            }
            if (st == null || st.Length == 0) {
                return coll;
            }
            char[] temp = new char[st.Length];
            for (int i = 0; i < st.Length; i++) {
                temp[i] = st[i];
            }
            Array.Sort(temp);
            //2.将新数组升序排列
            char itemp;
            for (int i = 0; i < temp.Length; i++) {
                for (int j = i; j < temp.Length; j++) {
                    itemp = st[i];
                    st[i] = st[j];
                    st[j] = itemp;
                }
            }

            string c = "";
            for (int i = 0; i < temp.Length; i++) {
                c += temp[i];
            }
            coll.Add(c);
            while (!isDesc(temp)) {
                FindNextArray(temp);
                string d = "";
                for (int i = 0; i < temp.Length; i++) {
                    d += temp[i];
                }
                coll.Add(d);
            }

            return coll;
        }
        /// 判断一个数组内元素是否降序排列
        public bool isDesc(char[] array) {
            char temp = array[0];
            for (int i = 1; i < array.Length; i++) {
                if (array[i] > array[i - 1]) {
                    return false;
                }
            }
            return true;
        }
        /// 找到下一组排列
        public void FindNextArray(char[] array) {
            //1.找出数组的最大值
            char max = array[0];
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
            char temp = array[t];
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
