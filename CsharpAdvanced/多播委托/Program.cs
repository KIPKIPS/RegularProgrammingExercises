using System;

namespace 多播委托
{
    class Program
    {
        static void Test1()
        {
            Console.WriteLine("test1");
        }

        static void Test2()
        {
            Console.WriteLine("test2");
        }
        static void Test3() {
            Console.WriteLine("test3");
        }
        public static int Test<T1, T2>(Func<T1, T2, int> func, T1 a, T2 b) {
            return func(a, b);
        }
        private static int Fun(int a, int b) {
            return a + b;
        }

        static void Main(string[] args) {
            Func<int, int, int> p = delegate(int arg1, int arg2) { return arg1 + arg2; };
            //多播委托
            Action a = Test1;
            a += Test2;//这时既指向test1也指向test2
            a += Test3;
            a();
            Predicate<int> isEven = num=> num%2==0;
            Console.WriteLine(isEven(5));

            Console.WriteLine(Test<int, int>(Fun, 100, 200));
            Console.ReadKey();
            //a -= Test2;
            //a -= Test1;

            //if(a!=null)//当委托为一个空方法的时候,调用这个委托会报错(空指针),所以在此 判断一下a!=null
            //a();
            //else
            //{
            //    throw new Exception("该委托为空方法!");//抛出异常
            //}


            //Delegate[] delegates = a.GetInvocationList();//GetInvocationList方法返回一个Delegate数组,通过遍历这个数组可以逐次调用委托a的全部方法
            //foreach (Delegate VARIABLE in delegates)
            //{
            //    VARIABLE.DynamicInvoke();//调用委托方法
            //}

            //匿名方法
            //Func<int, int, int> plus = delegate(int b, int c) { return c + b; };

            //Lambda表达式是匿名方法的简写形式
            Func<int, int, int> plus = (b, c) => { return b + c; };//func委托前两个类型为参数类型,最后一个为返回值类型
            Func<int, int> set = d => d++;//Lambda表达式的参数只有一个的时候可以不写参数的括号,当方法体只有一句代码的时候,可以不加{ };,也可以不加return

            plus(2, 54);
            Console.ReadLine();
        }
    }
}
