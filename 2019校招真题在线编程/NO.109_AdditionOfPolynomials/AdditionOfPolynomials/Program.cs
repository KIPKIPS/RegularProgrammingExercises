using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionOfPolynomials {

    class Program {
        class Node {
            public int coef; //系数
            public int exp; //指数
            public Node next; //下一个节点地址   
        }

        static void Main(string[] args) {
            Node polyA, polyB;
            Console.WriteLine("输入第一个多项式的系数和指数,以系数0结束:");
            polyA = CreatePoly();

            Console.WriteLine("输入第二个多项式的系数和指数,以系数0结束:");
            polyB = CreatePoly();
            Disp(Add(polyA, polyB));
            Console.WriteLine();
            Console.ReadLine();
        }

        //创建多项式
        static Node CreatePoly() {
            Node head, start, last;
            int coef, exp; //系数，指数变量
            //建立多项式对象
            head = new Node();
            last = head;

            while (true) {
                Console.WriteLine("请输入系数:");
                coef = Convert.ToInt32(Console.ReadLine());
                if (coef == 0) {
                    //输入系数为0时，表示多项式的输入结束.
                    break;
                }

                Console.WriteLine("请输入指数:");
                exp = Convert.ToInt32(Console.ReadLine());
                start = new Node(); //给新节点分配内存
                start.coef = coef; //赋值
                start.exp = exp;
                last.next = start; //在尾部插入新节点   
                last = start; //last始终指向单链表的末尾
            }

            last.next = null;
            return head;

        }

        //输出多项式
        static void Disp(Node poly) {
            while (poly.next != null) {
                if (poly.next.coef != 1 && poly.next.exp != 1) {

                    if (poly.next.exp == 0) {
                        Console.Write(poly.next.coef + "X");
                    }
                    else {
                        Console.Write(poly.next.coef + "X^" + poly.next.exp);
                    }
                }

                if (poly.next.coef != 1 && poly.next.exp == 1) {
                    Console.Write(poly.next.coef + "X");
                }

                if (poly.next.coef == 1 && poly.next.exp != 1) {
                    if (poly.next.exp == 0) {
                        Console.Write(poly.next.coef);
                    }
                    else {
                        Console.Write("X^" + poly.next.exp);
                    }
                }

                if (poly.next.coef == 1 && poly.next.exp == 1) {
                    Console.Write("X");
                }

                poly.next = poly.next.next;
                if (poly.next != null) {
                    Console.Write(" + ");
                }
            }
        }

        //多项式相加
        static Node Add(Node p1, Node p2) {
            Node sum = p1,LA=p1.next,LB=p2.next;
            while (LA!=null&&LB!=null) {
                if (LA.exp>LB.exp) {
                    Node temp = LB.next;
                    LB.next = sum.next;
                    sum.next = LB;
                    LB = temp;
                }
                if(LA.exp == LB.exp) {
                    if (LA.coef+LB.coef==0) {
                        LA = LA.next;
                        LB = LB.next;
                    }
                    else {
                        sum.next.coef += LB.coef;
                        LB = LB.next;
                    }
                    
                }

                if (LA.exp < LB.exp) {
                    if (LA.next!=null) {
                        LA = LA.next;
                    }
                    else {
                        LA.next = LB;
                    }
                    
                }
            }
            if (LA != null)
                sum.next = LA;
            else
                sum.next = LB;
            return sum;
        }
    }
}
