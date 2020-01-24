using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._032_今年的第几天 {
    class Program {
        static void Main(string[] args) {
            string[] inp = Console.ReadLine().Split(' ');
            int[] date = { Convert.ToInt32(inp[0]), Convert.ToInt32(inp[1]), Convert.ToInt32(inp[2]) };

            Console.WriteLine(DaysNum(date));
            Console.ReadLine();
        }

        public static bool IsLeapYear(int year) {
            if (year % 4 == 0) {
                if (year % 100 == 0 && year % 400 != 0)
                    return false;
                return true;
            }

            return false;
        }

        public static int DaysNum(int[] date) {
            if (IsLeapYear(date[0])) {
                switch (date[1]) {
                    case 1: return date[2];
                    case 2: return 31 + date[2];
                    case 3: return 60 + date[2];
                    case 4: return 91 + date[2];
                    case 5: return 121 + date[2];
                    case 6: return 152 + date[2];
                    case 7: return 182 + date[2];
                    case 8: return 213 + date[2];
                    case 9: return 244 + date[2];
                    case 10: return 274 + date[2];
                    case 11: return 305 + date[2];
                    case 12: return 335 + date[2];
                }
            }
            else {
                switch (date[1]) {
                    case 1: return date[2];
                    case 2: return 31 + date[2];
                    case 3: return 59 + date[2];
                    case 4: return 90 + date[2];
                    case 5: return 120 + date[2];
                    case 6: return 151 + date[2];
                    case 7: return 181 + date[2];
                    case 8: return 212 + date[2];
                    case 9: return 243 + date[2];
                    case 10: return 273 + date[2];
                    case 11: return 304 + date[2];
                    case 12: return 334 + date[2];
                }
            }
            return 0;
        }
    }
}
