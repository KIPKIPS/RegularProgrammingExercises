using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._62_数据流中的中位数 {
    class Program {
        static void Main(string[] args) {
        }
        List<int>data=new List<int>();
        public void Insert(int num) {
            // write code here
            data.Add(num);
        }

        public double GetMedian() {
            data.Sort();
            // write code here
            if (data.Count%2==0) {
                return (double) (data[data.Count / 2 - 1] + data[data.Count / 2]) / 2;
            }
            return (double) data[(data.Count - 1) / 2];
        }
    }
}
