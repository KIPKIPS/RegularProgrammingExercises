using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuaInterface;
using System.Reflection;
namespace TestLuaInterface {
    public class Program {
        public string name = "wkp";
        static void Main(string[] args) {
            Lua lua=new Lua();
            //lua["num"] = 21;
            //lua["1"] = "string";
            //lua.NewTable("tab");//创建表

            //lua.DoString("num=2");
            //lua.DoString("str='string'");
            //lua.DoString("tab={}");
            //lua.DoString("tab[1]='xxx'");
            //lua.DoString("print(tab[1],tab[2])");
            //Object[] obj = lua.DoString("print(num,str)");
            //Console.WriteLine(obj[0]+" "+obj[1]);
            lua.DoFile("MyLua.lua");
            Program p=new Program();
            //向lua里面注册一个方法,该方法在lua里面叫做LuaMethod,它是p对象的CLRMethod方法
            lua.RegisterFunction("LuaMethod", p, p.GetType().GetMethod("CLRMethod"));
            lua.DoString("LuaMethod()");

            //两种注册静态方法的方法
            //1.与第一种方法类似
            lua.RegisterFunction("LuaMethod_Static_1", null, p.GetType().GetMethod("CLRStaticMethod"));
            //通过typeof(类名).GetMethod("methodName")来注册
            lua.RegisterFunction("LuaMethod_Static_2", null, typeof(Program).GetMethod("CLRStaticMethod"));
            lua.DoString("LuaMethod_Static_1()");
            lua.DoString("LuaMethod_Static_2()");

            Lua lua2=new Lua();
            lua2.DoFile("MyClass.lua");
            Console.ReadLine();
        }

        //需要向lua注册的普通方法
        public void CLRMethod() {
            Console.WriteLine("对不起我太可爱了");
        }
        //向lua注册的静态方法
        public static void CLRStaticMethod() {
            Console.WriteLine("我是个好孩子");
        }

        public void Method() {
            Console.WriteLine("王学习");
        }
    }
}
