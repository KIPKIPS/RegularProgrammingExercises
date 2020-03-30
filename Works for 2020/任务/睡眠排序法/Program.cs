using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 睡眠排序法 {
    class Program {
        static void Main(string[] args) {
            int[] num = new[] {9,8,7,6,5,4,3,2,1};
            for (int i = 0; i < num.Length; i++) {
                Thread temp=new Thread(x =>
                {
                    int time = int.Parse(x.ToString());//将object类型的数组元素转换成int类型
                    Thread.Sleep(time*15);//线程休眠
                    Console.WriteLine(x+" ");//输出
                });
                temp.Start(num[i]);//线程开始运行
            }
            Console.ReadLine();  
        }
    }
}
