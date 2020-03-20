using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 复杂链表的复制 {
    class Program {
        public class RandomListNode {
            public int label;
            public RandomListNode next, random;
            public RandomListNode(int x) {
                this.label = x;
            }
        }
        static void Main(string[] args) {
            Program x = new Program();
            RandomListNode newNode = new RandomListNode(1);
            RandomListNode temp = newNode;
            for (int j = 2; j < 10; j++) {
                RandomListNode newN=new RandomListNode(j);
                temp.next = newN;
                temp = temp.next;
            }
            int goon = 0;
            int i = 1;
            while (goon==0) {
                Console.WriteLine("第"+i+"次随机节点 : ");
                RandomListNode na = newNode;
                x.Clone(newNode);
                while (na != null) {
                    if (na.random == null) {
                        Console.WriteLine("random : NULL\tLabel : " + na.label);
                    }
                    else {
                        Console.WriteLine("random : " + na.random.label + "\tLabel : " + na.label);
                    }
                    na = na.next;
                }
                Console.WriteLine();
                Console.Write("请输入指令是否继续测试(0代表继续测试,1退出程序)");
                goon = Convert.ToInt32(Console.ReadLine());
                i++;
                Console.WriteLine();
            }
        }
        public RandomListNode Clone(RandomListNode pHead) {
            // write code here
            if (pHead==null) {
                return pHead;
            }
            List<RandomListNode>randomList=new List<RandomListNode>();
            List<RandomListNode> sourceList = new List<RandomListNode>();
            RandomListNode num = pHead;
            int count = 0;
            while (num != null) {
                sourceList.Add(num);
                num = num.next;
                count++;
            }
            RandomListNode temp = pHead;
            Random a = new Random();
            while (temp != null) {
                int ran = a.Next(-1, count);
                RandomListNode random = pHead;
                if (ran==-1) {
                    randomList.Add(null);
                }
                else {
                    for (int i = 0; i < ran; i++) {
                        random = random.next;
                        randomList.Add(random);
                    }
                }
                temp.random = random;
                temp = temp.next;
            }
            RandomListNode head=new RandomListNode(sourceList[0].label);
            head.random = randomList[0];
            RandomListNode newTemp = head;
            for (int i = 1; i < sourceList.Count; i++) {
                newTemp.next = sourceList[i];
                newTemp.random = randomList[i];
                newTemp = newTemp.next;
            }
            return head;
        }
    }
}
