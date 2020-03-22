using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01 {
    
    class Program {
        class Node {
            public int data;
            public Node next;
            public Node(int x) {
                data = x;
            }
        }
        static void Main(string[] args) {
            string[] inp = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(inp[0]);
            int k= Convert.ToInt32(inp[1]);
            string[] d = Console.ReadLine().Split(' ');
            int[]data=new int[d.Length];
            for (int i = 0; i < d.Length; i++) {
                data[i] = Convert.ToInt32(d[i]);
            }
            Node head=new Node(-1);
            Node t = head;
            for (int i = 0; i < n; i++) {
                Node temp=new Node(data[i]);
                t.next = temp;
                t = t.next;
            }

            t = head;
            for (int i = 0; i < n-k; i++) {
                t = t.next;
            }
            t.next= t.next.next == null?null:t.next.next;//删除操作

            t = head.next;
            while (t!=null) {
                Console.Write(t.data+" ");
                t = t.next;
            }
            Console.ReadLine();
        }
    }
}
