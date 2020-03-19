using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._131_双栈排序 {
    class Program {
        static void Main(string[] args) {
            List<int> num = twoStacksSort(new[] {5, 1, 2, 3, 4, 5});
            for (int i = 0; i < num.Count; i++) {
                Console.WriteLine(num[i]+" ");
            }
            Console.ReadLine();
        }
        public static List<int> twoStacksSort(int[] numbers) {
            // write code here
            List< int>temp=new List<int>();//存储numbers的值的初始链表
            for (int i = 0; i < numbers.Length; i++) {
                temp.Add(numbers[i]);
            }
            List<int>data=new List<int>();//缓存链表,用于存储删掉最大值的temp链表
            List<int>res=new List<int>();//排序链表
            for (int i = 0; i < numbers.Length; i++) {
                //当前状态temp满,data为空链表
                //将temp的值依次赋给data链表,并且查找到最大值,查找到之后将temp值为空
                if (i%2==0) {
                    int max = temp[0];//初始化max
                    //查找到当前temp表中的max值
                    for (int j = 0; j < temp.Count; j++) {
                        if (temp[j]>max) {
                            max = temp[j];//更新max的值
                        }
                        //将temp的数据添加到data中
                        data.Add(temp[j]);
                    }
                    temp=new List<int>();//初始化temp链表
                    res.Add(max);//将一轮搜索的max值添加到排序链表中
                    data.Remove(max);//从data中移除已经查找到的max值
                }
                //当前状态data满,temp为空链表
                //将data的值依次赋给temp链表,并且查找到最大值,查找到之后将data值为空
                else {
                    int max = data[0];
                    //查找到当前data表中的max值
                    for (int j = 0; j < data.Count; j++) {
                        if (data[j]>max) {
                            max = data[j];//更新max值
                        }
                        //将data的数据添加到temp中
                        temp.Add(data[j]);
                    }
                    data=new List<int>();//清空data的值
                    res.Add(max);//max值添加到排序表中
                    temp.Remove(max);//temp表移除查找的max值
                }
            }
            return res;
        }
    }
}
