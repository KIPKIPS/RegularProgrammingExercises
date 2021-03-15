using System;
using System.ComponentModel.Design;

//大根堆排序为升序,求topK小,小根堆排序为升序,求topK大

namespace HeapSort {
    class Program {
        static void Main(string[] args) {
            int[] array = { 1, 5, 4, 2, 56, 12, 78, 9, 20, 15 };
            //HeapSort(array);

            // HeapSort(array, array.Length);
            // for (int i = 0; i < array.Length; i++) {
            //     Console.Write(array[i] + " ");
            // }
            int topK = TopK(array, 1, false);
            Console.WriteLine(topK);
            Console.Read();
        }

        static int TopK(int[] tree, int k, bool isTokMin) { //是否求第K小
            BuildHeap(tree, k, isTokMin);
            for (int i = k; i < tree.Length; i++) {
                bool checkCondition = isTokMin ? tree[i] < tree[0] : tree[i] > tree[0];
                if (checkCondition) {
                    Swap(tree, i, 0);
                    Heapify(tree, k, 0, isTokMin);
                }
            }
            return tree[0];
        }

        //堆化,维护堆的性质,自顶向下
        public static void Heapify(int[] tree, int length, int index, bool isBigRootHeap) {
            if (index >= length) {
                return;
            }
            //Console.WriteLine(index);
            int leftIndex = index * 2 + 1;//左子索引
            int rightIndex = index * 2 + 2;//右子索引
            int tempMaxIndex = index;//值最大的索引
            //查找最大值索引
            if (leftIndex < length) {
                bool leftCondition = isBigRootHeap ? tree[leftIndex] > tree[tempMaxIndex] : tree[leftIndex] < tree[tempMaxIndex];
                if (leftCondition) {
                    tempMaxIndex = leftIndex;
                }
            }
            if (rightIndex < length) {
                bool rightCondition = isBigRootHeap ? tree[rightIndex] > tree[tempMaxIndex] : tree[rightIndex] < tree[tempMaxIndex];
                if (rightCondition) {
                    tempMaxIndex = rightIndex;
                }
            }
            if (tempMaxIndex != index) { //将最大值放到根上
                Swap(tree, tempMaxIndex, index);
                Heapify(tree, length, tempMaxIndex, isBigRootHeap);
            }
        }

        static void Swap(int[] tree, int a, int b) {
            int temp = tree[a];
            tree[a] = tree[b];
            tree[b] = temp;
        }

        //建堆 从最后一个非叶子结点开始,自底向上Heapify
        static void BuildHeap(int[] tree, int length, bool isBigRootHeap) { //是否大根堆
            int lastNode = length - 1;
            int parentIndex = (int)MathF.Floor((lastNode - 1) / 2);//查找到最后一个非叶子节点
            for (int i = parentIndex; i >= 0; i--) {
                Heapify(tree, length, i, isBigRootHeap);
            }
        }
        //堆排序
        static void HeapSort(int[] tree, int length, bool isAsce) { //isAsce是否升序
            BuildHeap(tree, length, isAsce);
            for (int i = length - 1; i >= 0; i--) {
                Swap(tree, i, 0);
                Heapify(tree, i, 0, isAsce);
            }
        }
        //TODO:堆插,堆删
        // static void HeapRemove(int[] tree) {
        //     int min = tree[0];
        //     Swap(tree, 0, tree.Length -1);
        //     for (int i = 0; i < tree.Length - 1; i++) {
        //         Heapify(tree, tree.Length - 1,0);
        //     }
        // }
    }
}
