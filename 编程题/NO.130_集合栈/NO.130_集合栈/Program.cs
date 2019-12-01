using System;
using System.Collections.Generic;

namespace NO._130_集合栈 {
    class Program {
        static void Main(string[] args) {
            Console.ReadLine();
        }
        public static List<List<int>> setOfStacks(int[][] ope, int size) {
            // write code here
            List<List<int>> setOfStacks = new List<List<int>>();//集合栈
            List<int> dataStack = new List<int>();//存储栈
            for (int i = 0; i < ope.Length; i++) {
                ///push
                //栈满将栈添加到集合栈里面,将当前栈初始化,初始化后再执行push操作
                if (ope[i][0] == 1) {
                    if (dataStack.Count == size) {
                        setOfStacks.Add(dataStack);
                        dataStack = new List<int>();
                    }
                    dataStack.Add(ope[i][1]);
                }
                ///pop
                else if (ope[i][0] == 2) {
                    //当前栈容量为0,表示已经删空,将当前栈置为集合栈的上一个栈,并删除当前空栈
                    if (dataStack.Count == 0 && setOfStacks.Count > 0) {
                        dataStack = setOfStacks[setOfStacks.Count - 1];
                        setOfStacks.RemoveAt(setOfStacks.Count - 1);
                    }
                    //当前栈容量大于0,从当前栈删除元素,执行pop操作
                    if (dataStack.Count > 0)
                        dataStack.RemoveAt(dataStack.Count - 1);
                }
            }
            //操作序列结束后,栈不为空则将该栈添加到集合栈
            if (dataStack.Count > 0)
                setOfStacks.Add(dataStack);
            return setOfStacks;
        }
    }
}
