using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 米哈游笔试题二 {
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            int row = int.Parse(input[0]);//行
            int col = int.Parse(input[1]);//列
            List<List<char> >data=new List<List<char>>();
            for (int i = 0; i < row; i++) {
                string temp = Console.ReadLine();
                List<char>t=new List<char>();
                for (int j = 0; j < col; j++) {
                    t.Add(temp[j]);
                }
                data.Add(t);
            }
            //交换操作
            string[] inp = Console.ReadLine().Split(' ');
            int row1 = int.Parse(inp[0]);
            int col1 = int.Parse(inp[1]);
            int row2 = int.Parse(inp[2]);
            int col2 = int.Parse(inp[3]);
            char c = data[row1][col1];
            data[row1][col1] = data[row2][col2];
            data[row2][col2] = c;
            int count1Up = 0;
            int count1Down = 0;
            int count1Left = 0;
            int count1Right = 0;
            int count2Up = 0;
            int count2Down = 0;
            int count2Right = 0;
            int count2Left = 0;
            //点1向下查找
            for (int i = row1+1; i < row; i++) {
                char f = data[row1][col1];
                if (data[i][col1]==f) {
                    count1Down++;
                    f = data[i][col1];
                }
                else {
                    break;
                }
            }
            //点1向上查找
            for (int i = row1 -1; i >=0 ; i--) {
                char f = data[row1][col1];
                if (data[i][col1] == f) {
                    count1Up++;
                    f = data[i][col1];
                }
                else {
                    break;
                }
            }
            //点1向右
            for (int i = col1 + 1; i < col; i++) {
                char f = data[row1][col1];
                if (data[row1][i] == f) {
                    count1Right++;
                    f = data[row1][i];
                }
                else {
                    break;
                }
            }
            //点1向左
            for (int i = col1 - 1; i >=0; i--) {
                char f = data[row1][col1];
                if (data[row1][i] == f) {
                    count1Left++;
                    f = data[row1][i];
                }
                else {
                    break;
                }
            }

            //点2向上
            int count2 = 0;
            for (int i = row2 + 1; i < row; i++) {
                char f = data[row2][col2];
                if (data[i][col2] == f) {
                    count2Up++;
                    f = data[i][col2];
                }
                else {
                    break;
                }
            }
            //点2向下
            for (int i = row2 - 1; i >= 0; i--) {
                char f = data[row2][col2];
                if (data[i][col2] == f) {
                    count2Down++;
                    f = data[i][col2];
                }
                else {
                    break;
                }
            }//点2向右
            for (int i = col2 + 1; i < col; i++) {
                char f = data[row2][col2];
                if (data[row2][i] == f) {
                    count2Right++;
                    f = data[row2][i];
                }
                else {
                    break;
                }
            }
            //点2向左
            for (int i = col2 - 1; i >= 0; i--) {
                char f = data[row2][col2];
                if (data[row2][i] == f) {
                    count2Left++;
                    f = data[row2][i];
                }
                else {
                    break;
                }
            }

            int r1 = 0;
            int c1 = 0;
            int r2 = 0;
            int c2 = 0;
            if (count1Up+count1Down>=2) {
                r1 = count1Up + count1Down;
            }
            if (count1Left + count1Right >= 2) {
                c1 = count1Left + count1Right;
            }
            if (count2Up + count2Down >= 2) {
                r2 = count2Up + count2Down;
            }
            if (count2Left + count2Right >= 2) {
                c2 = count2Left + count2Right;
            }

            int res1 = 0;
            if (r1!=0||c1!=0) {
                res1 = r1 + c1 + 1;
            }
            int res2 = 0;
            if (r2 != 0 || c2 != 0) {
                res2 = r2 + c2 + 1;
            }
            Console.WriteLine(res1+res2);
            Console.ReadLine();
        }
    }
}
