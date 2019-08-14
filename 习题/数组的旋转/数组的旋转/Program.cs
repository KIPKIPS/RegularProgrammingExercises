using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //把一个数组最开始的若干个元素搬到数组的末尾，我们称之为数组的旋转。
    //输入一个非递减排序的数组的一个旋转，输出旋转数组。
    //例如数组{3,4,5,1,2}为{1,2,3,4,5}的一个旋转，该数组的最小值为1。
    //NOTE：给出的所有元素都大于0，若数组大小为0，请返回0
namespace 数组的旋转 {
    class Program {
        static void Main(string[] args) {
            int[] arr = new int[] {5, 6, 4, 5,1, 2, 3,4,5,6,7};
            arr = minNumberInRotateArray(arr);
            foreach (var VARIABLE in arr) {
                Console.Write(VARIABLE+" ");
            }

            Console.ReadLine();
        }
        public static int[] minNumberInRotateArray(int[] rotateArray) {
            if (rotateArray==null) {
                return null;
            }

            bool doit = false;
            int min = rotateArray.Min();
            List<int> rear=new List<int>();//后面
            List<int> front = new List<int>();
            for (int i = 0; i < rotateArray.Length; i++) {
                if (doit==false) {
                    rear.Add(rotateArray[i]);
                }
                if (doit) {
                    front.Add(rotateArray[i]);
                }
                if (rotateArray[i] == min) {
                    doit = true;
                }
            }

            for (int i = 0; i < rear.Count; i++) {
                front.Add(rear[i]);
            }
            rotateArray[0] = min;
            for (int i = 0; i < front.Count-1; i++) {
                rotateArray[i+1] = front[i];
            }

            return rotateArray;
        }
    }
}
