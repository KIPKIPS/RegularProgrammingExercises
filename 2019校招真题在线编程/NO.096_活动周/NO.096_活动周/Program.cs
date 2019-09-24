using System;
namespace NO._096_活动周 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(IsInActivityWeek(2000,1,8,1999,1,1));
            Console.ReadLine();
        }
        /// <summary>
        /// 判断两个日期是否在同一周
        /// </summary>
        /// <param name="activityYear"></param>
        /// <param name="activityMonth"></param>
        /// <param name="activityDay"></param>
        /// <param name="playerYear"></param>
        /// <param name="playerMonth"></param>
        /// <param name="playerDay"></param>
        /// <returns></returns>
        public static bool IsInActivityWeek(int activityYear, int activityMonth, int activityDay, int playerYear, int playerMonth, int playerDay) {
            if (DaysNum(playerYear, playerMonth, playerDay)%7== DaysNum(activityYear, activityMonth, activityDay) % 7&& DaysNum(playerYear, playerMonth, playerDay) / 7 == DaysNum(activityYear, activityMonth, activityDay) / 7) 
                return true;
            if (DaysNum(playerYear, playerMonth, playerDay) % 7==0&& DaysNum(playerYear, playerMonth, playerDay) / 7- DaysNum(activityYear, activityMonth, activityDay) / 7==1) {
                return true;
            }
            if (DaysNum(activityYear, activityMonth, activityDay) % 7==0&& DaysNum(activityYear, activityMonth, activityDay) / 7- DaysNum(playerYear, playerMonth, playerDay) / 7==1) {
                return true;
            }
            return false;
        }/// <summary>
        /// 是否闰年
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static bool IsLeapYear(int year) {
            if (year%400==0||(year%4==0&&year%100!=0))
                return true;
            return false;
        }
        /// <summary>
        /// 日期在一年的第几天
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static int DaysNum(int year, int month, int day) {
            if (IsLeapYear(year)) {
                switch (month) {
                    case 1: return day;
                    case 2: return 31+day;
                    case 3: return 60+day;
                    case 4: return 91+day;
                    case 5: return 121+day;
                    case 6: return 152+day;
                    case 7: return 182+day;
                    case 8: return 213+day;
                    case 9: return 244+day;
                    case 10: return 274+day;
                    case 11: return 305+day;
                    case 12: return 335+day;
                }
            }
            if (!IsLeapYear(year)) {
                switch (month) {
                    case 1: return day;
                    case 2: return 31 + day;
                    case 3: return 59 + day;
                    case 4: return 90 + day;
                    case 5: return 120 + day;
                    case 6: return 151 + day;
                    case 7: return 181 + day;
                    case 8: return 212 + day;
                    case 9: return 243 + day;
                    case 10: return 273 + day;
                    case 11: return 304 + day;
                    case 12: return 334 + day;
                }
            }
            return 0;
        }
    }
}
