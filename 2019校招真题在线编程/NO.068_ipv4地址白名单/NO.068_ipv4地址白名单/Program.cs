using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._068_ipv4地址白名单 {
    class Program {
        static void Main(string[] args) {
            HashSet<string> whiteList = new HashSet<string>();
            List<string> cmdList = new List<string>();
            while (true) {
                string cmd = Console.ReadLine();
                if (cmd == "end")
                    break;
                switch (cmd[0]) {
                    case 'i': //insert
                        string tempIpI = cmd.Substring(2, cmd.Length - 2);
                        if (!whiteList.Contains(tempIpI))
                            whiteList.Add(tempIpI);
                        Console.WriteLine("ok");
                        break;
                    case 's'://search
                        string tempIpS = cmd.Substring(2, cmd.Length - 2);
                        if (whiteList.Contains(tempIpS))
                            Console.WriteLine("true");
                        else
                            Console.WriteLine("false");
                        break;
                    case 'd'://delete
                        string tempIpD = cmd.Substring(2, cmd.Length - 2);
                        if (whiteList.Contains(tempIpD))
                            whiteList.Remove(tempIpD);
                        Console.WriteLine("ok");
                        break;
                }
            }
        }
    }
}
