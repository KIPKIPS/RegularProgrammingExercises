using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._023_latex爱好者 {
    class Program {
        static void Main(string[] args) {
            string[]info= Console.ReadLine().Split(' ');
            int paragraph = Convert.ToInt32(info[0]);//段落
            int pages = Convert.ToInt32(info[1]);//页数
            int height = Convert.ToInt32(info[2]);//行数
            int width = Convert.ToInt32(info[3]);//列数
            string[] paraInfo = Console.ReadLine().Split(' ');//每一段的字数
            int[]paraInfoNum=new int[paraInfo.Length];
            for (int i = 0; i < paraInfoNum.Length; i++) {
                paraInfoNum[i] = Convert.ToInt32(paraInfo[i]);
            }
        }
    }
}
