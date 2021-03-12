using System;
//https://github.com/KipKips/VisualStudioWorkStation.git
namespace HeapSort {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }

        //堆化,维护堆的性质,自顶向下
        public void Heapify(int[] tree, int index) {
            int length = tree.Length;
            int leftIndex = index * 2 + 1;//左子索引
            int rightIndex = index * 2 + 2;//右子索引
            int tempMaxIndex = index;//值最大的索引
            //查找最大值索引
            if (leftIndex < length && tree[leftIndex] > tree[tempMaxIndex]) {
                tempMaxIndex = leftIndex;
            }
            if (rightIndex < length && tree[rightIndex] > tree[tempMaxIndex]) {
                tempMaxIndex = rightIndex;
            }

            if (tempMaxIndex != index) { //将最大值放到根上
                Swap(tree, tempMaxIndex, index);
                Heapify(tree, tempMaxIndex);
            }
        }

        void Swap(int[] tree, int a, int b) {
            int temp = tree[a];
            tree[a] = tree[b];
            tree[b] = temp;
        }

        //建堆 从最后一个非叶子结点开始,自底向上Heapify
        void BuildHeap(int[] tree) {
            int lastNode = tree.Length - 1;
            int parentIndex = (int)MathF.Floor((lastNode - 1) / 2);//查找到最后一个非叶子节点
            for (int i = parentIndex; i >= 0; i++) {
                Heapify(tree, i);
            }
        }
    }
}
