using System;
using System.Collections.Generic;
namespace NO._029_解析加减法运算 {
    class Program {
        static void Main(string[] args) {
            string str = Console.ReadLine();
            Stack<char> operatorSatck = new Stack<char>();
            Stack<int> num = new Stack<int>();
            int p = str.Length-1;
            for (int i = str.Length-1; i >=0; i--) {
                if (str[i]=='+'||str[i]=='-') {
                    string temp = "";
                    for (int j = i+1; j <= p; j++) {
                        temp += str[j]+"";
                    }
                    num.Push(Convert.ToInt32(temp));
                    //Console.WriteLine(temp); Console.WriteLine(str[i]);
                    operatorSatck.Push(str[i]);
                    p = i - 1;
                }
            }
            string firstNum = "";
            for (int j = 0; j <= p; j++) {
                firstNum += str[j] + "";
            }
            //Console.WriteLine(firstNum);
            num.Push(Convert.ToInt32(firstNum));
            int res = 0;
            while (operatorSatck.Count != 0) {
                if (operatorSatck.Peek() == '+') {
                    res = num.Pop() + num.Pop();
                    num.Push(res);
                    operatorSatck.Pop();
                }
                else {
                    res = num.Pop() - num.Pop();
                    num.Push(res);
                    operatorSatck.Pop();
                }
            }
            Console.WriteLine(num.Pop());
            Console.ReadLine();
        }
    }
}
