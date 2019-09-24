using System;
namespace NO._093_交错01串 {
    class Program {
        static void Main(string[] args) {
            {
                string input = Console.ReadLine();
                int max = 1;
                int len = 1;
                for (int i = 0; i < input.Length - 1; i++) {
                    if (input[i + 1] - input[i] !=0)
                        len++;
                    else {
                        if (len > max) 
                            max = len;
                        len = 1;
                    }
                    if (len > max) 
                        max = len;
                }
                Console.WriteLine(max);
            }
        }
    }
}
