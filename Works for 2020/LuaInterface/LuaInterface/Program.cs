using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuaInterface;
namespace LuaInterface {
    class Program {
        static void Main(string[] args) {
            Lua lua=new Lua();
            lua["num"] = 21;
            Console.WriteLine(lua["num"]);
            Console.ReadLine();
        }
    }
}
