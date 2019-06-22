using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3 v=new Vector3();
            float[] target = new float[3];
            //是否继续计算向量的模
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("请输入向量的X,Y,Z值(以空格间隔,如需停止请输入$符号): ");
                while (true)
                {
                    try
                    {
                        string input = Console.ReadLine();
                        if (input == "$")
                        {
                            isContinue = false;
                            break;
                        }
                        string[] vTemp = input.Split(' ');
                        if (vTemp.Length > 3)//输入的数字超出三位
                        {
                            Console.WriteLine("输入的数字超出限制(三位)!请重新输入");
                            Console.WriteLine();
                            break;
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            target[i] = (float)(Convert.ToDouble(vTemp[i]));
                        }
                        v.SetX(target[0]);
                        v.SetY(target[1]);
                        v.SetZ(target[2]);
                        Console.WriteLine("向量的模为: "+v.Length());
                        Console.WriteLine();
                        break;

                    }
                    //输入的数字不足三位
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("请输入三位数字!");
                    }
                    //输入非数字字符
                    catch (FormatException e)
                    {
                        Console.WriteLine("输入的值不是数字!请重新输入!");
                    }
                }
            }
        }
    }
}
