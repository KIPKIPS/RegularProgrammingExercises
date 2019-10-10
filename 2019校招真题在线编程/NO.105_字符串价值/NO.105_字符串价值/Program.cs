using System;
using System.Collections;
using System.Collections.Generic;

namespace NO._105_字符串价值 {

    //不断将最多出现的个数-1,知道K值等于0
    class Program {
        static void Main(string[] args) {
            string s = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());

            if (k == s.Length) {
                Console.WriteLine(0);
                return;
            }
            int[] num = new int[26];
            for (int i = 0; i < s.Length; i++) {
                num[s[i] - 'a']++;
            }
            for (int i = 0; i < 26; i++) {
                for (int j = i + 1; j < 26; j++) {
                    if (num[i] < num[j]) {
                        int temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            int index = 0;
            for (int i = k; i > 0; i--) {
                int max = num[0];
                if (num[index] < max) { index = 1; num[0]--; max--; }
                else {
                    num[index]--;
                    index++;
                }
            }
            int sum = 0;
            for (int i = 0; i < 26; i++) {
                sum += num[i] * num[i];
            }
            Console.WriteLine(sum);
        }
    }
}